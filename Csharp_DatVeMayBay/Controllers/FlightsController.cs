using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.Enums;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        }
        public class BookingSeatViewModel
        {
            public FormData FormData { get; set; }
            public Flight Flight { get; set; }
            public List<Seat> Seats { get; set; }
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
            var inputDate = DateTime.Parse(Request.Form["departure_datetime"]).Date;

            var airportDeparture = dbContext.Airports.FirstOrDefault(a => departureAirportId == a.AirportId);
            var airportArrival = dbContext.Airports.FirstOrDefault(a => arrivalAirportId == a.AirportId);
            var FormData = new FormData
            {
                Type = type,
                FlightClass = flightClass,
                DepartureDate = inputDate,
                DepartureAirport = airportDeparture,
                ArrivalAirport = airportArrival
            };

            var Flights = dbContext.Flights.Where(f =>
                f.DepartureAirportId == departureAirportId &&
                f.ArrivalAirportId == arrivalAirportId &&
                f.DepartureDatetime.Date == inputDate).Include(a => a.DepartureAirport).Include(a => a.ArrivalAirport).Include(a => a.Airline)
                .ToList();
            var Airlines = await dbContext.Airlines.ToListAsync();
            var FlightViewModel = new FlightViewModel
            {
                FormData = FormData,
                Flights = Flights,
                Airlines = Airlines
            };
            ViewData["Message"] = "Không tìm thấy chuyến bay nào";
            return View(FlightViewModel);
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
