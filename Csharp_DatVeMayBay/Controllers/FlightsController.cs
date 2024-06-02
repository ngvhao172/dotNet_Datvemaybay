using Csharp_DatVeMayBay.Command_Pattern;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace Csharp_DatVeMayBay.Controllers
{
    public class FlightsController : Controller
    {
        private readonly DBContext dbContext;
        private FlightService _flightService;

        Invoker commandInvoker = new Invoker();
        public FlightsController(DBContext dbContext, FlightService flightService)
        {
            this.dbContext = dbContext;
            _flightService = flightService;
        }
        public class FormData
        {
            public string Type { get; set; }
            public string FlightClass { get; set; }
            public DateTime DepartureDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public Airport DepartureAirport { get; set; }
            public Airport ArrivalAirport { get; set; }
            public string Message { get; set; }
            public Flight OutBoundFlight { get; set; }
            public Flight ReturnFlight { get; set; }
            public List<string> SeatPicker { get; set; }
            public List<int> NumberOfMeals { get; set; }
            public List<int> NumberOfLuggages { get; set; }
        }
        public class FlightViewModel
        {
            public FormData FormData { get; set; }
            public List<Flight> Flights { get; set; }
            public List<Airline> Airlines { get; set; }
            public List<string> AirlineChecked { get; set; }

            public int TotalPages { get; set; }
            public int PageNumber { get; set; }
        }
        public class BookingSeatViewModel
        {
            public FormData FormData { get; set; }
            public Flight Flight { get; set; }
            public List<Seat> Seats { get; set; }
        }

        static FlightViewModel flightViewModel;
        static FormData formData;
        static List<Flight> flightList;
        static List<Flight> flightListPage;

        private static BookingSeatViewModel bookingFlightDetail;
        [Route("/select-flight"), HttpGet]
        [Route("/select-return-flight"), HttpGet]
        public IActionResult GetFlightListing(int page)
        {
            int pageSize = 5;
            int pageNumber;

            if (page < 1)
            {
                page = 1;
            }
            pageNumber = page;
            if (flightViewModel != null)
            {
                if (pageNumber > Math.Ceiling(flightListPage.Count / (double)pageSize))
                {
                    pageNumber = (int)Math.Ceiling(flightListPage.Count / (double)pageSize);
                }
                int totalItems = flightListPage.Count;
                int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
                flightViewModel.Flights = flightListPage.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                //Tổng số trang
                flightViewModel.TotalPages = totalPages;
                flightViewModel.PageNumber = pageNumber;

                ViewData["Message"] = "Không tìm thấy chuyến bay nào";

                return View("FlightListing", flightViewModel);
            }
            return RedirectToAction("Error404", "Error");
        }


        /*Route*/
        [Route("/select-flight")]
        [HttpPost]
        public async Task<IActionResult> FlightListing()
        {
            var type = Request.Form["type"];
            var flightClass = Request.Form["class"];
            var departureAirportId = int.Parse(Request.Form["departure_airport_id"]);
            var arrivalAirportId = int.Parse(Request.Form["arrival_airport_id"]);
            if (Request.Form["departure_datetime"] == "")
            {
                return Redirect("/");
            }
            var inputDate = DateTime.Parse(Request.Form["departure_datetime"]).Date;
            var date = Request.Form["return_datetime"];

            DateTime returnDate;
            if (date != "")
            {
                returnDate = DateTime.Parse(date).Date;
            }
            else
            {
                returnDate = new DateTime();
            }
            var airportDeparture = dbContext.Airports.FirstOrDefault(a => departureAirportId == a.AirportId);
            var airportArrival = dbContext.Airports.FirstOrDefault(a => arrivalAirportId == a.AirportId);
            formData = new FormData
            {
                Type = type,
                FlightClass = flightClass,
                DepartureDate = inputDate,
                ReturnDate = returnDate,
                DepartureAirport = airportDeparture,
                ArrivalAirport = airportArrival,
                Message = "Chọn vé đi"
            };
            ICommand searchFlightsCommand = new SearchFlightsCommand(_flightService, formData);
            commandInvoker.SetCommand(searchFlightsCommand);
            await commandInvoker.ExecuteCommand();

            flightList = ((SearchFlightsCommand)searchFlightsCommand).GetResult();
            var Airlines = await dbContext.Airlines.ToListAsync();
            flightViewModel = new FlightViewModel
            {
                FormData = formData,
                Flights = flightList,
                Airlines = Airlines,
                AirlineChecked = null
            };
            flightListPage = flightList;
            return Redirect("/select-flight");
        }
        [Route("/{select_type}/filter")]
        [HttpPost]
        public async Task<IActionResult> FlightListingFilter(string select_type)
        {
            if (select_type != "select-return-flight" && select_type != "select-flight")
            {
                return Redirect("Error/Error404");
            }
            var AirlinesIdValue = Request.Form["airlines"];
            var AllAirlinesChecked = Request.Form["allairlines"];

            //Biến tách request
            var checkVariable = Request.Form["checkTrue"];

            //Trường hợp default được gửi lên
            /* || StringValues.IsNullOrEmpty(AllAirlinesChecked) && StringValues.IsNullOrEmpty(AirlinesIdValue)*/
            if (StringValues.IsNullOrEmpty(AirlinesIdValue) && StringValues.IsNullOrEmpty(checkVariable))
            {
                return Redirect($"/{select_type}");
            }
            else if (!StringValues.IsNullOrEmpty(AllAirlinesChecked) || StringValues.IsNullOrEmpty(AllAirlinesChecked) && StringValues.IsNullOrEmpty(AirlinesIdValue))
            {
                var Airlines = await dbContext.Airlines.ToListAsync();
                flightViewModel = new FlightViewModel
                {
                    FormData = formData,
                    Flights = flightList,
                    Airlines = Airlines,
                    AirlineChecked = null
                };
                flightListPage = flightList;
                return Redirect($"/{select_type}");
            }
            //Trường hợp chỉ check airline
            else
            {
                var AirlinesId = AirlinesIdValue.ToString().Split(",");
                List<string> airlinesStringList = AirlinesId.ToList();
                var Flights = flightList.Where(f => airlinesStringList.Contains(f.AirlineId.ToString())).ToList();
                var Airlines = await dbContext.Airlines.ToListAsync();
                flightViewModel = new FlightViewModel
                {
                    FormData = formData,
                    Flights = Flights,
                    Airlines = Airlines,
                    AirlineChecked = airlinesStringList
                };
                flightListPage = Flights;
                return Redirect($"/{select_type}");
            }
        }


        [Route("/select-return-flight")]
        [HttpPost]
        public async Task<IActionResult> FlightListingReturn()
        {
            var FlightData = Request.Form["FlightData"];

            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);

            var seat = Request.Form["seat"];
            List<string> seats = new List<string>();
            seats.Add(seat);
            FormData.SeatPicker = seats;
            formData.SeatPicker = seats;

            var returnFormData = FormData;
            returnFormData.DepartureDate = formData.ReturnDate;
            returnFormData.DepartureAirport = formData.ArrivalAirport;
            returnFormData.ArrivalAirport = formData.DepartureAirport;



            ICommand searchFlightsCommand = new SearchFlightsCommand(_flightService, returnFormData);
            commandInvoker.SetCommand(searchFlightsCommand);
            await commandInvoker.ExecuteCommand();

            flightList = ((SearchFlightsCommand)searchFlightsCommand).GetResult();


            /*flightList = dbContext.Flights.Where(f =>
                f.DepartureAirportId == FormData.ArrivalAirport.AirportId &&
                f.ArrivalAirportId == FormData.DepartureAirport.AirportId &&
                f.DepartureDatetime.Date == FormData.ReturnDate && f.DepartureDatetime > DateTime.Now).Include(a => a.DepartureAirport).Include(a => a.ArrivalAirport).Include(a => a.Airline)
                .ToList();*/
            var Airlines = await dbContext.Airlines.ToListAsync();
            formData.Message = "Chọn vé về";
            flightViewModel = new FlightViewModel
            {
                FormData = formData,
                Flights = flightList,
                Airlines = Airlines,
                AirlineChecked = null
            };
            flightListPage = flightList;
            return Redirect("/select-return-flight");
        }


        [Route("/{select_type}/booking-seat")]
      /*  [Route("/select-return-flight/booking-seat")]*/
        [HttpPost]
        public async Task<IActionResult> BookingSeat(string select_type)
        {
            if (select_type != "select-return-flight" && select_type != "select-flight")
            {
                return Redirect("Error/Error404");
            }
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);

            List<Seat> Seats = await dbContext.Seats.Where(s => s.FlightId == Flight.FlightId).Where(s => s.Status == SeatStatus.Busy).ToListAsync();
            if (FormData.Type == "Khứ hồi")
            {
                if (FormData.OutBoundFlight != null)
                {
                    FormData.ReturnFlight = Flight;
                    formData.ReturnFlight = Flight;
                }
                else
                {
                    FormData.OutBoundFlight = Flight;
                    formData.OutBoundFlight = Flight;
                    FormData.ReturnFlight = null;
                }
            }
            else
            {
                FormData.OutBoundFlight = Flight;
                formData.OutBoundFlight = Flight;
            }
            var BookingSeatViewModel = new BookingSeatViewModel
            {
                FormData = FormData,
                Flight = Flight,
                Seats = Seats
            };
            HttpContext.Session.SetString("BookingSeatViewModel", JsonConvert.SerializeObject(BookingSeatViewModel));

            return Redirect($"/{select_type}/booking-seat");
         /*   return RedirectToAction("BookingSeatGET");*/
        }

        [Route("/select-flight/booking-seat")]
        [Route("/select-return-flight/booking-seat")]
        [HttpGet]
        public async Task<IActionResult> BookingSeatGET()
        {
            var json = HttpContext.Session.GetString("BookingSeatViewModel");
            if (!string.IsNullOrEmpty(json))
            {
                var model = JsonConvert.DeserializeObject<BookingSeatViewModel>(json);
                return View("BookingSeat", model);
            }
            return RedirectToAction("Error404", "Error");
        }

        [Route("/flight-detail-booking")]
        [HttpPost]
        public IActionResult FLightDetailBooking()
        {
            HttpContext.Session.Remove("BookingSeatViewModel");
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);
            var SeatNo = Request.Form["seat"];
            if (FormData.SeatPicker == null)
            {
                List<String> seats = new List<string>();
                FormData.SeatPicker = seats;
                formData.SeatPicker = seats;
            }
            FormData.SeatPicker.Add(SeatNo);
            formData.SeatPicker.Add(SeatNo);

            var BookingViewModel = new BookingSeatViewModel
            {
                Flight = Flight,
                FormData = FormData
            };
            HttpContext.Session.SetString("BookingViewModel", JsonConvert.SerializeObject(BookingViewModel));
            bookingFlightDetail = BookingViewModel;
            return RedirectToAction("FLightDetailBookingGET");
        }
        [Route("/flight-detail-booking")]
        [HttpGet]
        public IActionResult FLightDetailBookingGET()
        {
            var json = HttpContext.Session.GetString("BookingViewModel");
            if (!string.IsNullOrEmpty(json))
            {
                var model = JsonConvert.DeserializeObject<BookingSeatViewModel>(json);
                return View("FLightDetailBooking", model);
            }
            else if(bookingFlightDetail != null)
            {
                var model = bookingFlightDetail;
                return View("FLightDetailBooking", model);
            }
            return RedirectToAction("Error404", "Error");
        }
    }
}
