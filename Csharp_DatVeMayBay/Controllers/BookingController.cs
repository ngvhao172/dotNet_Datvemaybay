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
        /*      private bool isPost*/
        static FinalTicketModel finalTicketValue;
        public class TicketFlightModel
        {
            public Ticket Ticket;
            public CustomFlight Flight;
        }
        public class FinalTicketModel
        {
            public List<Creditcard> creditcards;
            public Ticket Ticket { get; set; }
            public CustomFlight CustomFlight { get; set; }
            public PassengerInfo PassengerInfo { get; set; }
        }

        [Route("/payment-booking")]
        [HttpPost]
        public async Task<IActionResult> BookingDetail()
        {
            if (!User.Identity.IsAuthenticated)
            {
                var firstName = Request.Form["firstName"];
                var lastName = Request.Form["lastName"];
                var phoneNumber = Request.Form["phoneNumber"];
                var address = Request.Form["address"];
                var Dob = DateOnly.Parse(Request.Form["Dob"]);
                var seatNo = Request.Form["seatNo"];
                var passengerInfo = new PassengerInfo(firstName, lastName, phoneNumber, address, Dob, seatNo);
                var flightData = Request.Form["flightData"];
                var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
                var viewModel = new FinalTicketModel
                {
                    CustomFlight = customFlight,
                    PassengerInfo = passengerInfo
                };

                return View(viewModel);
            }
            else
            {
                var flightData = Request.Form["flightData"];
                var seatNo = Request.Form["seatNo"];
                Console.WriteLine(flightData.ToString());
                var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
                /* PassengerInfo passengerInfo = new PassengerInfo ;*/
                var user = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).FirstAsync();
                var creditcardsUser = dbContext.Creditcards.Where(c => c.UserId == user.UserId).ToList();
                
                var viewModel = new FinalTicketModel
                {
                    CustomFlight = customFlight,
                    PassengerInfo = new PassengerInfo(user.FirstName, user.LastName, user.PhoneNumber, user.Address, DateOnly.Parse(user.Dob.Date.ToString("yyyy-MM-dd")), seatNo),
                    creditcards = creditcardsUser
                };
                return View(viewModel);
            }
           
        }
        [Route("/ticket-info")]
        [HttpPost]
        public async Task<IActionResult> TicketProcessing()
        {
            var passenger = Request.Form["passengerInfo"];
            var passengerInfo = JsonConvert.DeserializeObject<PassengerInfo>(passenger);

            var flightData = Request.Form["flightData"];
            var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
            var creditcards = Request.Form["cardCreditList"];
            List<Creditcard> cardList = JsonConvert.DeserializeObject<List<Creditcard>>(creditcards);
/*            foreach (var creditcardValue in creditcards)
            {
                Console.WriteLine(creditcardValue);
                Creditcard creditcardObject = JsonConvert.DeserializeObject<Creditcard>(creditcardValue);
                creditcardList.Add(creditcardObject);

            }*/
            var user = new User();
            /*Tạo user nếu chưa tồn tại hoặc chưa login*/
            if (!User.Identity.IsAuthenticated)
            {
                user = new User
                {
                    FirstName = passengerInfo.firstName,
                    LastName = passengerInfo.lastName,
                    Address = passengerInfo.address,
                    UserEmail = null,
                    PhoneNumber = passengerInfo.phoneNumber,
                    Dob = DateTime.Parse(passengerInfo.Dob.ToString())
                };
                /*Save user*/
                dbContext.Add(user);
                await dbContext.SaveChangesAsync();
                /*Lưu lại creditcard*/
                foreach(var creditcard in cardList)
                {
                    creditcard.UserId = user.UserId;
                    dbContext.Add(creditcard);
                }
                await dbContext.SaveChangesAsync();
            }
            /*Trường hợp User đã login*/
            else
            {
                /*Get User from UserEmail */
                var userExist = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).FirstAsync();
                if (userExist != null)
                {
                    user = userExist;
                }
                foreach (var creditcard in cardList)
                {
                    creditcard.UserId = userExist.UserId;
                    dbContext.Add(creditcard);
                }
                await dbContext.SaveChangesAsync();
            }
            /*Get flight cũ*/
            var taskFlight = dbContext.Flights.Where(flight => flight.FlightId == customFlight.FlightId).FirstOrDefaultAsync();

            Flight Flight = await taskFlight;
            /**/
            if (user!=null)
            {
                /*Tạo booking, tạo ticket và trả về View*/
                /*var Booking = dbContext.Bookings.Add(new Booking { })*/
                var newBooking = new Booking
                {
                    UserId = user.UserId,
                    User = user,
                    FlightId = Flight.FlightId,
                    Flight = Flight,
                    BookingDatime = DateTime.Now,
                    PassengerCount = 1,
                    Status = Models.Enums.BookingStatus.Booked
                };
                dbContext.Add(newBooking);
                await dbContext.SaveChangesAsync();
                int BookingIdValue = newBooking.BookingId;
                if(BookingIdValue != null) {
/*                    if (passengerInfo == null)
                    {
                        passengerInfo = new PassengerInfo(user.FirstName, user.LastName, user.PhoneNumber, user.Address, DateOnly.Parse(user.Dob.Date.ToString("yyyy-MM-dd")), customFlight.seatNo);
                    }*/
                    Console.WriteLine("Seat: " + passengerInfo.seat[0],passengerInfo.seat[1]);
                    Console.WriteLine("FlightID: " + Flight.FlightId);
                    var seatRow = passengerInfo.seat[0];
                    var seatColumn = int.Parse(passengerInfo.seat[1].ToString());

                    /* Console.WriteLine("SeatBooked: " + Flight.Seats);*/

                    /*Lấy id của seat đã chọn*/
                    var seatTask = await dbContext.Seats.Where(seat => seat.FlightId == Flight.FlightId && seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstOrDefaultAsync();
                    /*  Seat SeatBooked = Flight.Seats.Where(seat => seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstOrDefault();*/

                    /*Đợi tác vụ hoàn thành*/
                    Seat SeatBooked = seatTask;
                    Console.WriteLine("SeatBooked: "+ SeatBooked);

                    if (SeatBooked != null)
                    {
                        /*Update Seat Status*/
                        SeatBooked.Status = Models.Enums.SeatStatus.Busy;
                        dbContext.Update(SeatBooked);
        /*                 dbContext.SaveChangesAsync();*/
                        /*Tạo ticket*/
                        /*Retreiving the last ticket*/
                        var code = "0001";
                        /*Lấy ticket cuối cùng*/
                        var Date = DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "");
                        var AirlineCode = customFlight.airlineInfo.AirlineCode.ToString();

                        var TicketString = AirlineCode + Date;

                        var getLastTicketId = dbContext.Tickets
                        .Where(ticket => ticket.TicketId.Contains(TicketString))
                        .OrderBy(ticket => ticket.TicketId) 
                        .LastOrDefaultAsync();


                        Ticket lastTicketId = await getLastTicketId;
                        if(lastTicketId != null)
                        {
                            var lastId = lastTicketId.TicketId.Substring(lastTicketId.TicketId.Length - 4, 4);
                            Console.WriteLine("LastID: " + lastId);

                            var lastfourId = int.Parse(lastId) + 1;

                            code = string.Format("{0:D4}", lastfourId);
                        }
                        /*Tạo ticket*/
                        var newTicket = new Ticket
                        {
                            TicketId = customFlight.airlineInfo.AirlineCode + DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-","") + code,
                            BookingId = BookingIdValue,
                            Booking = newBooking,
                            Flight = Flight,
                            FlightId = Flight.FlightId,
                            SeatId = SeatBooked.SeatId,
                            Seat = SeatBooked,
                            Status = Models.Enums.TicketStatus.Paid,
                            TicketPrice = customFlight.classPricing
                        };
                        dbContext.Add(newTicket);
                        dbContext.SaveChanges();
                        finalTicketValue = new FinalTicketModel
                        {
                            Ticket = newTicket,
                            CustomFlight = customFlight,
                            PassengerInfo = passengerInfo,
                        };
                        /*Trả Data về View*/
                        return Redirect("/ticket-info");
                    }
                    else
                    {
                        /*Không tìm được Seat*/
                        TempData["error"] = "Không tìm thấy Seat được chọn";
                        return RedirectToAction("Error505", "Error");
                    }
                }
                else
                {
                    /*Không tìm được Booking hay không tạo được Booking*/
                    TempData["error"] = "Không tìm được Booking hay không tạo được Booking";
                    return RedirectToAction("Error505", "Error");
                }

            }
            else
            {
                /*Không tìm được User hay không tạo được User*/
                TempData["error"] = "Không tìm được User hay không tạo được User";
                return RedirectToAction("Error505", "Error");
            }
        }
        [Route("/ticket-info")]
        [HttpGet]
        public IActionResult BookingTicket()
        {
            if (finalTicketValue!=null)
            {
                return View(finalTicketValue);
            }
            return RedirectToAction("Error505","Error");
        }

        [Route("/search-booking")]
        [HttpGet]
        public IActionResult SearchBooking()
        {
            return View();
        }


        [Route("/search-booking")]
        [HttpPost]
        public IActionResult SearchBooking(Ticket ticket)
        {
            var ticketID = Request.Form["ticketId"].ToString();
            Console.WriteLine(ticketID);
            var ticketResult = dbContext.Tickets.Where(t => t.TicketId == ticketID).Include(f => f.Flight).Include(b => b.Booking).ThenInclude(u=>u.User).Include(s => s.Seat).FirstOrDefault();
            if(ticketResult!=null)
            {
                Console.WriteLine(ticketResult.Flight.ToString());
                var airportDeparture = dbContext.Airports.FirstOrDefault(a => ticketResult.Flight.DepartureAirportId == a.AirportId);
                var airportArrival = dbContext.Airports.FirstOrDefault(a => ticketResult.Flight.ArrivalAirportId == a.AirportId);
                var flight = dbContext.Flights.Where(f => f.FlightId == ticketResult.FlightId).FirstOrDefault();
                var customFlight = new CustomFlight()
                {
                    FlightId = flight.FlightId,
                    AirlineId = flight.AirlineId,
                    DepartureAirportId = flight.AirlineId,
                    ArrivalAirportId = flight.AirlineId,
                    DepartureDatetime = flight.DepartureDatetime,
                    ArrivalDatetime = flight.ArrivalDatetime,
                    EconomyPrice = flight.EconomyPrice,
                    BussinessPrice = flight.BussinessPrice,
                    airlineInfo = dbContext.Airlines.FirstOrDefault(a => flight.AirlineId == a.AirlineId),
                    from = airportDeparture,
                    to = airportArrival
                };
                var TicketFlight = new TicketFlightModel
                {
                    Ticket = ticketResult,
                    Flight = customFlight
                };
                return View(TicketFlight);
            }
            return View(null);
        }

    }
}
