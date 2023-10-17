using Csharp_DatVeMayBay.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Csharp_DatVeMayBay.Controllers.FlightsController;
using static Csharp_DatVeMayBay.Controllers.PassengerController;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Csharp_DatVeMayBay.Controllers
{
    public class BookingController : Controller
    {

        private readonly DBContext dbContext;
        public BookingController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        static Ticket finalTicketValue;
        public class BookingDetailModel
        {
            public List<Creditcard> Creditcards;

            public Flight Flight;

            public FormData FormData;

            public PassengerInfo PassengerInfo;
        }
        [Route("/payment-booking")]
        [HttpPost]
        public async Task<IActionResult> BookingDetail()
        {
            if (!User.Identity.IsAuthenticated)
            {
                var FirstName = Request.Form["FirstName"];
                var LastName = Request.Form["LastName"];
                var PhoneNumber = Request.Form["PhoneNumber"];
                var Address = Request.Form["Address"];
                var Dob = DateOnly.Parse(Request.Form["Dob"]);
                var PassengerInfo = new PassengerInfo(FirstName, LastName, PhoneNumber, Address, Dob);
                var FlightData = Request.Form["FlightData"];
                var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
                var Form = Request.Form["FormData"];
                var FormData = JsonConvert.DeserializeObject<FormData>(Form);
                var viewModel = new BookingDetailModel
                {
                    Flight = Flight,
                    FormData = FormData,
                    PassengerInfo = PassengerInfo
                };

                return View(viewModel);
            }
            else
            {
                var FlightData = Request.Form["FlightData"];
                var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
                var Form = Request.Form["FormData"];
                var FormData = JsonConvert.DeserializeObject<FormData>(Form);
                //var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
                PassengerInfo passengerInfo;
                var user = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).Include(c => c.Creditcards).FirstAsync();

                var BookingDetailModel = new BookingDetailModel
                {
                    PassengerInfo = new PassengerInfo(user.FirstName, user.LastName, user.PhoneNumber, user.Address, DateOnly.Parse(user.Dob.Date.ToString("yyyy-MM-dd"))),
                    Creditcards = user.Creditcards.ToList(),
                    Flight = Flight,
                    FormData = FormData
                };
                return View(BookingDetailModel);
            }

        }
        [Route("/ticket-info")]
        [HttpPost]
        public async Task<IActionResult> TicketProcessing()
        {
            var passenger = Request.Form["PassengerInfo"];
            var PassengerInfo = JsonConvert.DeserializeObject<PassengerInfo>(passenger);
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);
            var creditcards = Request.Form["cardCreditList"];
            List<Creditcard> cardList = JsonConvert.DeserializeObject<List<Creditcard>>(creditcards);
            var user = new User();
            //Tạo user nếu chưa tồn tại hoặc chưa login
            if (!User.Identity.IsAuthenticated)
            {
                user = new User
                {
                    FirstName = PassengerInfo.FirstName,
                    LastName = PassengerInfo.LastName,
                    Address = PassengerInfo.Address,
                    UserEmail = null,
                    PhoneNumber = PassengerInfo.PhoneNumber,
                    Dob = DateTime.Parse(PassengerInfo.Dob.ToString())
                };
                //Save user
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                //Lưu lại creditcard
                if (cardList!=null)
                {
                    foreach (var creditcard in cardList)
                    {
                        creditcard.UserId = user.UserId;
                        await dbContext.AddAsync(creditcard);
                    }
                }
               
                await dbContext.SaveChangesAsync();
            }
            //Trường hợp User đã login
            else
            {
                //Get User from UserEmail
                var userExist = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).FirstAsync();
                if (userExist != null)
                {
                    user = userExist;
                }
                if (cardList != null)
                {
                    foreach (var creditcard in cardList)
                    {
                        creditcard.UserId = user.UserId;
                        await dbContext.AddAsync(creditcard);
                    }
                }
                await dbContext.SaveChangesAsync();
            }
            //Get flight cũ
            //var taskFlight = dbContext.Flights.Where(flight => flight.FlightId == customFlight.FlightId).FirstOrDefaultAsync();

            // Flight Flight = await taskFlight;

            if (user != null)
            {
                //Tạo booking, tạo ticket và trả về View
                //var Booking = dbContext.Bookings.Add(new Booking { })
                var newBooking = new Booking
                {
                    UserId = user.UserId,
                    FlightId = Flight.FlightId,
                    BookingDatime = DateTime.Now,
                    PassengerCount = 1,
                    Status = Models.Enums.BookingStatus.Booked
                };
                await dbContext.AddAsync(newBooking);
                await dbContext.SaveChangesAsync();
                int BookingIdValue = newBooking.BookingId;
                if (BookingIdValue != null)
                {
                    if (PassengerInfo == null)
                    {
                        PassengerInfo = new PassengerInfo(user.FirstName, user.LastName, user.PhoneNumber, user.Address, DateOnly.Parse(user.Dob.Date.ToString("yyyy-MM-dd")));
                    }
                   /* Console.WriteLine("Seat: " + passengerInfo.seat[0], passengerInfo.seat[1]);
                    Console.WriteLine("FlightID: " + Flight.FlightId);*/
                    var seatRow = FormData.SeatPicker[0];
                    var seatColumn = int.Parse(FormData.SeatPicker[1].ToString());

                    //Lấy id của seat đã chọn
                    var seatTask = await dbContext.Seats.Where(seat => seat.FlightId == Flight.FlightId && seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstOrDefaultAsync();

                    //Đợi tác vụ hoàn thành
                    Seat SeatBooked = seatTask;
                    Console.WriteLine("SeatBooked: " + SeatBooked);

                    if (SeatBooked != null)
                    {
                        if(SeatBooked.Status == Models.Enums.SeatStatus.Available)
                        {
                            //Update Seat Status
                            SeatBooked.Status = Models.Enums.SeatStatus.Busy;
                            dbContext.Update(SeatBooked);
                            await dbContext.SaveChangesAsync();
                            //Tạo ticket
                            //Retreiving the last ticket
                            var code = "0001";
                            //Lấy ticket cuối cùng
                            var Date = DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "");
                            var AirlineCode = Flight.Airline.AirlineCode.ToString();

                            var TicketString = AirlineCode + Date;

                            var getLastTicketId = dbContext.Tickets
                            .Where(ticket => ticket.TicketId.Contains(TicketString))
                            .OrderBy(ticket => ticket.TicketId)
                            .LastOrDefaultAsync();


                            Ticket lastTicketId = await getLastTicketId;
                            if (lastTicketId != null)
                            {
                                var lastId = lastTicketId.TicketId.Substring(lastTicketId.TicketId.Length - 4, 4);
                                Console.WriteLine("LastID: " + lastId);

                                var lastfourId = int.Parse(lastId) + 1;

                                code = string.Format("{0:D4}", lastfourId);
                            }
                            //Tạo ticket
                            var newTicket = new Ticket
                            {
                                TicketId = Flight.Airline.AirlineCode + DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "") + code,
                                BookingId = BookingIdValue,
                                FlightId = Flight.FlightId,
                                SeatId = SeatBooked.SeatId,
                                Status = Models.Enums.TicketStatus.Paid,
                                TicketPrice = FormData.FlightClass == "PT" ? Flight.EconomyPrice : Flight.BussinessPrice,
                                TicketClass = FormData.FlightClass == "PT" ? "Phổ thông" : "Thương"
                            };
                            await dbContext.AddAsync(newTicket);
                            await dbContext.SaveChangesAsync();



                            finalTicketValue = await dbContext.Tickets
                                .Where(t => t.TicketId == newTicket.TicketId)
                                .Include(f => f.Flight)
                                    .ThenInclude(a => a.Airline)
                                .Include(f => f.Flight)
                                    .ThenInclude(a => a.DepartureAirport)
                                .Include(f => f.Flight)
                                    .ThenInclude(a => a.ArrivalAirport)
                                .Include(f => f.Booking)
                                    .ThenInclude(a => a.User)
                                .FirstAsync();
                            //Trả Data về View
                            return Redirect("/ticket-info");
                        }
                        else
                        {
                            //Seat đã được đặt
                            TempData["error"] = "Chỗ ngồi đó đã được đặt, vui lòng chọn chỗ ngồi khác.";
                            return RedirectToAction("Error500", "Error");
                        }
                    }
                    else
                    {
                        //Không tìm được Seat
                        TempData["error"] = "Không tìm thấy Seat được chọn";
                        return RedirectToAction("Error500", "Error");
                    }
                }
                else
                {
                    //Không tìm được Booking hay không tạo được Booking
                    TempData["error"] = "Không tìm được Booking hay không tạo được Booking";
                    return RedirectToAction("Error500", "Error");
                }
            }
            else
            {
                //Không tìm được User hay không tạo được User
                TempData["error"] = "Không tìm được User hay không tạo được User";
                return RedirectToAction("Error500", "Error");
            }
        }
        [Route("/ticket-info")]
        [HttpGet]
        public IActionResult BookingTicket()
        {
            if (finalTicketValue != null)
            {
                return View(finalTicketValue);
            }
            return RedirectToAction("Error500", "Error");
        }

        [Route("/search-booking")]
        [HttpGet]
        public IActionResult SearchBooking()
        {
            return View();
        }
        [Route("/search-booking")]
        [HttpPost]
        public async Task<IActionResult> SearchBooking(Ticket ticket)
        {
            var TicketResult = Request.Form["ticketId"].ToString();
            Ticket Ticket = await dbContext.Tickets
                .Where(t => t.TicketId == TicketResult)
                .Include(f => f.Flight)
                .ThenInclude(a => a.Airline)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.DepartureAirport)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.ArrivalAirport)
                .Include(s => s.Seat)
                .Include(f => f.Booking)
                    .ThenInclude(a => a.User).FirstAsync();
            if (TicketResult != null)
            {
                var airportDeparture = dbContext.Airports.FirstOrDefault(a => Ticket.Flight.DepartureAirportId == a.AirportId);
                var airportArrival = dbContext.Airports.FirstOrDefault(a => Ticket.Flight.ArrivalAirportId == a.AirportId);
                var flight = dbContext.Flights.Where(f => f.FlightId == Ticket.FlightId).FirstOrDefault();
                return View(Ticket);
            }
            return View(null);
        }

    }
}
