using Csharp_DatVeMayBay.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Csharp_DatVeMayBay.Controllers.FlightsController;
using static Csharp_DatVeMayBay.Controllers.PassengerController;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Csharp_DatVeMayBay.Strategy;
using Csharp_DatVeMayBay.Models.Enums;
using Csharp_DatVeMayBay.Template_Method;
using Csharp_DatVeMayBay.Services.EmailService;
using Csharp_DatVeMayBay.Command_Pattern;
using Csharp_DatVeMayBay.Decorator_BookingPrice;

namespace Csharp_DatVeMayBay.Controllers
{
    public class BookingController : Controller
    {

        private readonly DBContext dbContext;

        private readonly IEmailService _emailService;

        private readonly IConfiguration _config;

        private PaymentContext paymentContext;

        private SimplePaymentFactory simplePaymentFactory = new SimplePaymentFactory();

        private FlightService _flightService;

        Invoker commandInvoker = new Invoker();

        public BookingController(DBContext dbContext, IEmailService emailService, IConfiguration config, FlightService flightService)
        {
            this.dbContext = dbContext;
            this._emailService = emailService;
            this._config = config;
            this._flightService = flightService;

        }
        private static List<Ticket> finalTicketValue;

        private static BookingDetailModel finalBookingData;
        public class BookingDetailModel
        {
            public List<Creditcard> Creditcards;

            public Flight Flight;

            public FormData FormData;

            public PassengerInfo PassengerInfo;

            public decimal Total;
        }
        [Route("/payment-booking")]
        [HttpGet]
        public async Task<IActionResult> BookingDetailGET()
        {
            if (finalTicketValue != null)
            {
               finalBookingData = null;
            }
            if (finalBookingData != null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    var user = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).Include(c => c.Creditcards).FirstOrDefaultAsync();
                    finalBookingData.Creditcards = user.Creditcards.ToList();
                }
                //Check if seat is already booked
                var seatRow = finalBookingData.FormData.SeatPicker[0][0];
                var seatColumn = int.Parse(finalBookingData.FormData.SeatPicker[0][1].ToString());
                Seat seat = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.OutBoundFlight.FlightId && seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstAsync();
                Console.WriteLine("SeatOUTBOUND: " + seat.Status);
                
                if (seat.Status == Models.Enums.SeatStatus.Busy)
                {
                    TempData["booked"] = true;
                }
                if (finalBookingData.FormData.Type == "Khứ hồi")
                {
                    var seatRowReturn = finalBookingData.FormData.SeatPicker[1][0];
                    var seatColumnReturn = int.Parse(finalBookingData.FormData.SeatPicker[1][1].ToString());
                    Seat seatReturn = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.ReturnFlight.FlightId && seat.SeatRow == seatRowReturn && seat.SeatColumn == seatColumnReturn).FirstAsync();
                    Console.WriteLine("SeatRETURN: " + seatReturn.Status);
                    if (seatReturn.Status == Models.Enums.SeatStatus.Busy)
                    {
                        TempData["booked"] = true;
                    }
                }
                if (TempData["cancelled"] !=null)
                {
                    TempData["warning"] = "Đơn hàng chưa được thanh toán thành công.";
                    Logger.GetInstance().Log($"User({User.FindFirst(ClaimTypes.NameIdentifier)?.Value : null}, {finalBookingData.PassengerInfo.FirstName +" "+finalBookingData.PassengerInfo.LastName}) cancelled the payment");
                }
                return View("BookingDetail", finalBookingData);
            }
            else
            {
                return Redirect("/Error/404");
            }
        }

        [Route("/payment-booking")]
        [HttpPost]
        public async Task<IActionResult> BookingDetail()
        {
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);
            var NumberOfLuggage = Request.Form["numberOfLuggages"];
            var NumberOfMeal = Request.Form["numberOfMeals"];
            var NumberOfLuggageReturn = Request.Form["numberOfLuggagesReturn"];
            var NumberOfMealReturn = Request.Form["numberOfMealsReturn"];
            List<int> numberOfLuggage = new List<int>();

            List<int> numberOfMeal = new List<int>();
            if (User.Identity.IsAuthenticated)
            {
                numberOfLuggage.Add(Int16.Parse(NumberOfLuggage));

                numberOfMeal.Add(Int16.Parse(NumberOfMeal));
                if (FormData.ReturnFlight != null)
                {
                    numberOfLuggage.Add(Int16.Parse(NumberOfLuggageReturn));
                    numberOfMeal.Add(Int16.Parse(NumberOfMealReturn));
                }
                FormData.NumberOfLuggages = numberOfLuggage;
                FormData.NumberOfMeals = numberOfMeal;
            }
            //Tinh tong tien = decorator

            var ticketClass = (FormData.FlightClass == "PT") ? TicketClass.Economy : TicketClass.Business;
            BookingBase bookingPrice;
            if (FormData.ReturnFlight != null)
            {
                bookingPrice = new RoundTripBooking(ticketClass, FormData.OutBoundFlight, FormData.ReturnFlight);
                int totalMeals = FormData.NumberOfMeals.Sum();
                for (int i = 0; i < totalMeals; i++)
                {
                    bookingPrice = new MealService(bookingPrice);
                }
                int totalLuggages = FormData.NumberOfLuggages.Sum();
                for (int i = 0; i < totalLuggages; i++)
                {
                    bookingPrice = new LuggageService(bookingPrice);
                }
            }
            else
            {
                bookingPrice = new OnewayBooking(ticketClass, FormData.OutBoundFlight);
                int totalMeals = FormData.NumberOfMeals[0];
                for (int i = 0; i < totalMeals; i++)
                {
                    bookingPrice = new MealService(bookingPrice);
                }
                int totalLuggages = FormData.NumberOfLuggages[0];
                for (int i = 0; i < totalLuggages; i++)
                {
                    bookingPrice = new LuggageService(bookingPrice);
                }
            }
            var TotalPrice = bookingPrice.CalculatePrice();
            if (!User.Identity.IsAuthenticated)
            {
                var FirstName = Request.Form["FirstName"];
                var LastName = Request.Form["LastName"];
                var PhoneNumber = Request.Form["PhoneNumber"];
                var Address = Request.Form["Address"];
                var Dob = DateOnly.Parse(Request.Form["Dob"]);
                var PassengerInfo = new PassengerInfo(FirstName, LastName, PhoneNumber, Address, Dob);

                var viewModel = new BookingDetailModel
                {
                    Flight = Flight,
                    FormData = FormData,
                    PassengerInfo = PassengerInfo,
                    Total = TotalPrice
                };
                finalBookingData = viewModel;
                finalTicketValue = null;
                return Redirect("/payment-booking");
            }
            else
            {
                PassengerInfo passengerInfo;
                var user = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).Include(c => c.Creditcards).FirstOrDefaultAsync();
                var BookingDetailModel = new BookingDetailModel
                {
                    PassengerInfo = new PassengerInfo(user.FirstName, user.LastName, user.PhoneNumber, user.Address, DateOnly.Parse(user.Dob.Date.ToString("yyyy-MM-dd"))),
                    Creditcards = user.Creditcards.ToList(),
                    Flight = Flight,
                    FormData = FormData,
                    Total = TotalPrice
                };

                finalBookingData = BookingDetailModel;
                finalTicketValue = null;
                return Redirect("/payment-booking");
            }
        }

        //New code_strategy
        [Route("/payment-method")]
        [HttpPost]
        public async Task<IActionResult> PaymentStrategy()
        {
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);
            var paymentMethod = Request.Form["method"];

            //Trường hợp ghế đã được đặt
            var seatRow = finalBookingData.FormData.SeatPicker[0][0];
            var seatColumn = int.Parse(finalBookingData.FormData.SeatPicker[0][1].ToString());
            Seat seat = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.OutBoundFlight.FlightId && seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstAsync();
            if (seat.Status == Models.Enums.SeatStatus.Busy)
            {
                TempData["booked"] = true;
                return View("BookingDetail", finalBookingData);
            }
            if (finalBookingData.FormData.ReturnFlight != null)
            {
                var seatRowReturn = finalBookingData.FormData.SeatPicker[1][0];
                var seatColumnReturn = int.Parse(finalBookingData.FormData.SeatPicker[1][1].ToString());
                Seat seatReturn = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.ReturnFlight.FlightId && seat.SeatRow == seatRowReturn && seat.SeatColumn == seatColumnReturn).FirstAsync();

                if (seatReturn.Status == Models.Enums.SeatStatus.Busy)
                {
                    TempData["booked"] = true;
                    return View("BookingDetail", finalBookingData);
                }
            }



            //Tạo booking

            var newBooking = await CreateBooking();

            //Logger
            Logger.GetInstance().Log($"User({User?.FindFirst(ClaimTypes.NameIdentifier)?.Value: 'null'}, {finalBookingData.PassengerInfo.FirstName + " " + finalBookingData.PassengerInfo.LastName}) chose {paymentMethod} as the payment method for the Booking(Id: {newBooking.BookingId})");

            double TicketPrice = (double)finalBookingData.Total;
            
            //Payment_Strategy

            IPaymentStrategy payment = simplePaymentFactory.CreatePayment(paymentMethod);
            paymentContext = new PaymentContext(payment);

            

            return Redirect(await paymentContext.Pay(newBooking.BookingId, TicketPrice));

            //Payment_Strategy
        }
        //
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public async Task<Booking> CreateBooking()
        {
            var PassengerInfo = finalBookingData.PassengerInfo;
            var Flight = finalBookingData.Flight;
            var FormData = finalBookingData.FormData;
            var paymentMethod = finalBookingData.FormData;
            List<Creditcard> cardList = finalBookingData.Creditcards;
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
            //Trường hợp User đã login
            else
            {
                //Get User from UserEmail
                var userExist = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).FirstAsync();
                if (userExist != null)
                {
                    user = userExist;
                }
                var userCreditCards = await dbContext.Creditcards
                .Where(c => c.UserId == userExist.UserId)
                .ToListAsync();

                var newCreditCards = cardList.Where(c => !userCreditCards.Any(uc => uc.CardId == c.CardId));
                //Lưu lại creditcard
                if (cardList != null)
                {
                    foreach (var creditcard in newCreditCards)
                    {
                        creditcard.UserId = user.UserId;
                        await dbContext.AddAsync(creditcard);
                    }
                    await dbContext.SaveChangesAsync();
                }

            }
            //Tạo booking
            string bookingId = GenerateBookingId();
            var newBooking = new Booking
            {
                BookingId = bookingId,
                UserId = user.UserId,
                BookingDatime = DateTime.Now,
                FlightId = FormData.OutBoundFlight.FlightId,
                FlightReturnId = FormData.ReturnFlight?.FlightId,
                PassengerCount = 1,
                BookingType = (FormData.Type == "Khứ hồi") ? BookingType.Return : BookingType.Oneway,
                Status = BookingStatus.NotPaid // Chưa thanh toán
            };
            await dbContext.AddAsync(newBooking);
            await dbContext.SaveChangesAsync();

            return newBooking;
        }
        static string GenerateBookingId()
        {
            long timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            string timestampHex = timestamp.ToString("X8");

            Random random = new Random();
            string randomPart = random.Next(10, 99).ToString(); 

            string bookingId = timestampHex + randomPart;
            return bookingId;
        }

        [Route("/ticket-processing/{bookingId}")]
        [HttpGet]
        public async Task<IActionResult> GenerateTicket(string bookingId)
        {
            if (finalTicketValue != null)
            {
                return Redirect("/ticket-info");
            }
            Booking Booking = await 
                dbContext.Bookings.Where(b => b.BookingId == bookingId)
                .Include(b => b.User)
                .Include(b => b.Flight)
                .ThenInclude(f => f.Airline)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.DepartureAirport)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.ArrivalAirport)
                .Include(b => b.FlightReturn)
                .ThenInclude(f => f.Airline)
                .Include(b => b.Tickets)
                .ThenInclude(t => t.Seat)
                .FirstAsync();

            string BookingIdValue = Booking.BookingId;
            if (BookingIdValue != null)
            {
                /* Console.WriteLine("Seat: " + passengerInfo.seat[0], passengerInfo.seat[1]);
                 Console.WriteLine("FlightID: " + Flight.FlightId);*/
                
                if(Booking.BookingType == BookingType.Oneway)
                {
                    var seatRow = finalBookingData.FormData.SeatPicker[0][0];
                    var seatColumn = int.Parse(finalBookingData.FormData.SeatPicker[0][1].ToString());
                    Seat SeatBooked = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.OutBoundFlight.FlightId && seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstAsync();

                    if (SeatBooked != null)
                    {
                        if (SeatBooked.Status == Models.Enums.SeatStatus.Available)
                        {
                            SeatBooked.Status = Models.Enums.SeatStatus.Busy;
                            dbContext.Update(SeatBooked);
                            await dbContext.SaveChangesAsync();

                            //Tạo ticket
                            //Retreiving the last ticket
                            var code = "0001";
                            //Lấy ticket cuối cùng
                            var Date = DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "");
                            var AirlineCode = finalBookingData.Flight.Airline.AirlineCode.ToString();

                            var TicketString = AirlineCode + Date;

                            Ticket? lastTicketId = await dbContext.Tickets.Where(ticket => ticket.TicketId.Contains(TicketString)).OrderBy(ticket => ticket.TicketId).LastOrDefaultAsync();

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
                                TicketId = finalBookingData.Flight.Airline.AirlineCode + DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "") + code,
                                BookingId = BookingIdValue,
                                FlightId = finalBookingData.Flight.FlightId,
                                SeatId = SeatBooked.SeatId,
                                Status = Models.Enums.TicketStatus.Paid,
                                TicketPrice = finalBookingData.FormData.FlightClass == "PT" ? finalBookingData.Flight.EconomyPrice : finalBookingData.Flight.BussinessPrice,
                                TicketClass = finalBookingData.FormData.FlightClass == "PT" ? TicketClass.Economy : TicketClass.Business
                            };
                            await dbContext.AddAsync(newTicket);
                            await dbContext.SaveChangesAsync();

                            if (User.Identity.IsAuthenticated)
                            {
                                //Send mail
                                EmailBookingNotification bookingNotification = new OneWayBookingNotification(Booking, _emailService);
                                bookingNotification.Notify();
                            }
                          


                            //render ticket
                            finalTicketValue = new List<Ticket>();
                            var outboundTicket = await dbContext.Tickets
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
                            finalTicketValue.Add(outboundTicket);

                            if (TempData["AlertShown"] == null)
                            {
                                TempData["AlertShown"] = true;
                            }
                            return Redirect("/ticket-info");
                        }
                        else
                        {
                            //Seat đã được đặt
                            TempData["error"] = "Chỗ ngồi đó đã được đặt, vui lòng chọn chỗ ngồi khác.";
                            return RedirectToAction("GeneralError", "Error");
                        }
                    }
                    else
                    {
                        //Không tìm được Seat
                        TempData["error"] = "Không tìm thấy Seat được chọn";
                        return RedirectToAction("GeneralError", "Error");
                    }
                }
                else
                {
                    var seatRow = finalBookingData.FormData.SeatPicker[0][0];
                    var seatColumn = int.Parse(finalBookingData.FormData.SeatPicker[0][1].ToString());
                    Seat SeatBooked = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.OutBoundFlight.FlightId && seat.SeatRow == seatRow && seat.SeatColumn == seatColumn).FirstAsync();

                    var seatRowReturn = finalBookingData.FormData.SeatPicker[1][0];
                    var seatColumnReturn = int.Parse(finalBookingData.FormData.SeatPicker[1][1].ToString());
                    Seat SeatReturn = await dbContext.Seats.Where(seat => seat.FlightId == finalBookingData.FormData.ReturnFlight.FlightId && seat.SeatRow == seatRowReturn && seat.SeatColumn == seatColumnReturn).FirstAsync();

                    if (SeatBooked != null && SeatReturn != null)
                    {
                        Console.WriteLine(SeatBooked.Status);
                        Console.WriteLine(SeatReturn.Status);
                        if (SeatBooked.Status == SeatStatus.Available && SeatReturn.Status == SeatStatus.Available)
                        {
                            SeatBooked.Status = SeatStatus.Busy;
                            SeatReturn.Status = SeatStatus.Busy;
                            dbContext.Update(SeatBooked);
                            dbContext.Update(SeatReturn);
                            await dbContext.SaveChangesAsync();

                            //Tạo ticket
                            //Retreiving the last ticket
                            var code = "0001";
                            var codeReturn = "0001";
                            //Lấy ticket cuối cùng
                            var Date = DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "");
                            var AirlineCode = finalBookingData.FormData.OutBoundFlight.Airline.AirlineCode.ToString();

                            var AirlineCodeReturn = finalBookingData.FormData.ReturnFlight.Airline.AirlineCode.ToString();

                            var TicketString = AirlineCode + Date;

                            var TicketStringReturn = AirlineCodeReturn + Date;

                            Ticket? lastTicketId = await dbContext.Tickets.Where(ticket => ticket.TicketId.Contains(TicketString)).OrderBy(ticket => ticket.TicketId).LastOrDefaultAsync();

                            Ticket? lastTicketIdReturn = await dbContext.Tickets.Where(ticket => ticket.TicketId.Contains(TicketStringReturn)).OrderBy(ticket => ticket.TicketId).LastOrDefaultAsync();

                            if (lastTicketId != null)
                            {
                                var lastId = lastTicketId.TicketId.Substring(lastTicketId.TicketId.Length - 4, 4);
                               

                                var lastfourId = int.Parse(lastId) + 1;

                                code = string.Format("{0:D4}", lastfourId);
                                Console.WriteLine("LastID: " + code);
                            }
                            else
                            {
                                code = "0001";
                            }
                            if(lastTicketIdReturn != null)
                            {
                                var lastIdReturn = lastTicketIdReturn.TicketId.Substring(lastTicketIdReturn.TicketId.Length - 4, 4);
                                Console.WriteLine(lastIdReturn);
                                var lastfourIdReturn = int.Parse(lastIdReturn) + 1;
                                if (AirlineCode == AirlineCodeReturn)
                                {

                                    lastfourIdReturn = int.Parse(lastIdReturn) + 2;
                                }
                                codeReturn = string.Format("{0:D4}", lastfourIdReturn);
                                Console.WriteLine("LastIDReturn: " + codeReturn);
                            }
                            else
                            {
                                codeReturn = "0002";
                            }
                            
                            //Tạo ticket 
                            var newTicket = new Ticket
                            {
                                TicketId = finalBookingData.FormData.OutBoundFlight.Airline.AirlineCode + DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "") + code,
                                BookingId = BookingIdValue,
                                FlightId = finalBookingData.FormData.OutBoundFlight.FlightId,
                                SeatId = SeatBooked.SeatId,
                                Status = Models.Enums.TicketStatus.Paid,
                                TicketPrice = finalBookingData.FormData.FlightClass == "PT" ? finalBookingData.FormData.OutBoundFlight.EconomyPrice : finalBookingData.FormData.OutBoundFlight.BussinessPrice,
                                TicketClass = finalBookingData.FormData.FlightClass == "PT" ? TicketClass.Economy : TicketClass.Business
                            };
                            //Tạo ticket return
                            var newTicketReturn = new Ticket
                            {
                                TicketId = finalBookingData.FormData.ReturnFlight.Airline.AirlineCode + DateTime.Now.Date.ToString("yyyy-MM-dd").Replace("-", "") + codeReturn,
                                BookingId = BookingIdValue,
                                FlightId = finalBookingData.FormData.ReturnFlight.FlightId,
                                SeatId = SeatReturn.SeatId,
                                Status = Models.Enums.TicketStatus.Paid,
                                TicketPrice = finalBookingData.FormData.FlightClass == "PT" ? finalBookingData.FormData.ReturnFlight.EconomyPrice : finalBookingData.FormData.ReturnFlight.BussinessPrice,
                                TicketClass = finalBookingData.FormData.FlightClass == "PT" ? TicketClass.Economy : TicketClass.Business
                            };
                            await dbContext.Tickets.AddRangeAsync(newTicket, newTicketReturn);
                            await dbContext.SaveChangesAsync();

                            if (User.Identity.IsAuthenticated)
                            {
                                //Send mail
                                EmailBookingNotification bookingNotification = new RoundTripBookingNotification(Booking, _emailService);
                                bookingNotification.Notify();
                            }

                            //render ticket
                            finalTicketValue = new List<Ticket>();

                            var outboundTicket =  await dbContext.Tickets
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
                            var returnTicket = await dbContext.Tickets
                                .Where(t => t.TicketId == newTicketReturn.TicketId)
                                .Include(f => f.Flight)
                                    .ThenInclude(a => a.Airline)
                                .Include(f => f.Flight)
                                    .ThenInclude(a => a.DepartureAirport)
                                .Include(f => f.Flight)
                                    .ThenInclude(a => a.ArrivalAirport)
                                .Include(f => f.Booking)
                                    .ThenInclude(a => a.User)
                                .FirstAsync();

                            finalTicketValue.Add(outboundTicket);
                            finalTicketValue.Add(returnTicket);

                            if (TempData["AlertShown"] == null)
                            {
                                TempData["AlertShown"] = true;
                            }
                            HttpContext.Session.Remove("BookingViewModel");
                            return Redirect("/ticket-info");
                        }
                        else
                        {
                            //Seat đã được đặt
                            TempData["error"] = "Chỗ ngồi đó đã được đặt, vui lòng chọn chỗ ngồi khác.";
                            return RedirectToAction("GeneralError", "Error");
                        }
                    }
                    else
                    {
                        //Không tìm được Seat
                        TempData["error"] = "Không tìm thấy Seat được chọn";
                        return RedirectToAction("GeneralError", "Error");
                    }
                }      
            }
            else
            {
                //Không tìm được Booking hay không tạo được Booking
                TempData["error"] = "Không tìm được Booking hay không tạo được Booking";
                return RedirectToAction("GeneralError", "Error");
            }
        }
        [Route("/ticket-info")]
        [HttpGet]
        public IActionResult BookingTicket()
        {
            if (finalTicketValue != null)
            {
                if (TempData["AlertShown"] != null)
                {
                    TempData.Remove("AlertShown");
                    ViewBag.ShowAlert = true;
                }
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
        public async Task<IActionResult> SearchBookingPost()
        {
<<<<<<< HEAD
            var TicketId = Request.Form["ticketId"].ToString();
            var BookingId = Request.Form["bookingId"].ToString();
            List<Ticket> tickets = null;

            if (string.IsNullOrWhiteSpace(TicketId) && string.IsNullOrWhiteSpace(BookingId))
=======
            var TicketResult = Request.Form["ticketId"].ToString();
            Ticket? Ticket = await dbContext.Tickets
                .Where(t => t.TicketId == TicketResult)
                .Include(f => f.Flight)
                .ThenInclude(a => a.Airline)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.DepartureAirport)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.ArrivalAirport)
                .Include(s => s.Seat)
                .Include(f => f.Booking)
                    .ThenInclude(a => a.User).FirstOrDefaultAsync();
            if (Ticket != null)
>>>>>>> 1410fb0aa031d0c4bbf14b0dfd7d287c2370ddb8
            {
                TempData["error"] = true;
            }
            else
            {
                tickets = new List<Ticket>();

                if (!string.IsNullOrWhiteSpace(TicketId))
                {
                    ICommand getTicketInfoCommand = new GetTicketInfoCommand(_flightService, TicketId);
                    commandInvoker.SetCommand(getTicketInfoCommand);
                    await commandInvoker.ExecuteCommand();

                    var Ticket = ((GetTicketInfoCommand)getTicketInfoCommand).GetResult();
                    if (Ticket != null)
                    {
                        tickets.Add(Ticket);
                    }
                }
                else if (!string.IsNullOrWhiteSpace(BookingId))
                {
                    ICommand getBookingInfoCommand = new GetBookingInfoCommand(_flightService, BookingId);
                    commandInvoker.SetCommand(getBookingInfoCommand);
                    await commandInvoker.ExecuteCommand();

                    var Booking = ((GetBookingInfoCommand)getBookingInfoCommand).GetResult();

                    Console.WriteLine("Ticket Count" + Booking.Tickets.Count);
                    if (Booking != null)
                    {
                        tickets.AddRange(Booking.Tickets);
                    }
                }
            }

            if (tickets == null || tickets.Count == 0)
            {
                TempData["error"] = true;
            }

            return View("SearchBooking", tickets);

        }
    }

}
