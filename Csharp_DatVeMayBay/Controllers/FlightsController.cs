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
        public FlightsController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public class FormData
        {
            public string Type { get; set; }
            public string FlightClass { get; set; }
            public DateTime DepartureDate { get; set; }
            public Airport DepartureAirport { get; set; }
            public Airport ArrivalAirport { get; set; }
            public string SeatPicker { get; set; }
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
        [Route("/select-flight"), HttpGet]
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
            var AirlinesIdValue = Request.Form["airlines"];
            var AllAirlinesChecked = Request.Form["allairlines"];

            //Biến tách request
            var checkVariable = Request.Form["checkTrue"]; 

            //Trường hợp default được gửi lên
            /* || StringValues.IsNullOrEmpty(AllAirlinesChecked) && StringValues.IsNullOrEmpty(AirlinesIdValue)*/
            if (StringValues.IsNullOrEmpty(AirlinesIdValue) && StringValues.IsNullOrEmpty(checkVariable))
            {
                var type = Request.Form["type"];
                var flightClass = Request.Form["class"];
                var departureAirportId = int.Parse(Request.Form["departure_airport_id"]);
                var arrivalAirportId = int.Parse(Request.Form["arrival_airport_id"]);
                var inputDate = DateTime.Parse(Request.Form["departure_datetime"]).Date;

                var airportDeparture = dbContext.Airports.FirstOrDefault(a => departureAirportId == a.AirportId);
                var airportArrival = dbContext.Airports.FirstOrDefault(a => arrivalAirportId == a.AirportId);
                formData = new FormData
                {
                    Type = type,
                    FlightClass = flightClass,
                    DepartureDate = inputDate,
                    DepartureAirport = airportDeparture,
                    ArrivalAirport = airportArrival
                };
                flightList = dbContext.Flights.Where(f =>
                    f.DepartureAirportId == departureAirportId &&
                    f.ArrivalAirportId == arrivalAirportId &&
                    f.DepartureDatetime.Date == inputDate).Include(a => a.DepartureAirport).Include(a => a.ArrivalAirport).Include(a => a.Airline)
                    .ToList();
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
            //Lọc hãng bay
            //Trường hợp không check all + không check airline và có check all đồng thời check airline
             else if(!StringValues.IsNullOrEmpty(AllAirlinesChecked) || StringValues.IsNullOrEmpty(AllAirlinesChecked) && StringValues.IsNullOrEmpty(AirlinesIdValue))
            {
                var Airlines = await dbContext.Airlines.ToListAsync();
                flightViewModel = new FlightViewModel
                {
                    FormData = formData,
                    Flights = flightList,
                    Airlines = Airlines,
                    AirlineChecked = null
                };
                return Redirect("/select-flight");
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
                return Redirect("/select-flight");
            }
        }
        [Route("/select-flight/booking-seat")]
        [HttpPost]
        public async Task<IActionResult> BookingSeat()
        {
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);

            List<Seat> Seats = dbContext.Seats.Where(s => s.FlightId == Flight.FlightId).Where(s => s.Status == SeatStatus.Busy).ToList();
            var newFormData = new FormData
            {
                Type = FormData.Type,
                FlightClass = FormData.FlightClass
            };
            var BookingSeatViewModel = new BookingSeatViewModel
            {
                FormData = newFormData,
                Flight = Flight,
                Seats = Seats
            };
            return View(BookingSeatViewModel);

        }
        [Route("/select-flight/flight-detail-booking")]
        [HttpPost]
        public IActionResult FLightDetailBooking()
        {
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);
            var SeatNo = Request.Form["seat"];
            FormData.SeatPicker = SeatNo;
            var BookingViewModel = new BookingSeatViewModel
            {
                Flight = Flight,
                FormData = FormData
            };

            return View(BookingViewModel);

        }
    }
}
