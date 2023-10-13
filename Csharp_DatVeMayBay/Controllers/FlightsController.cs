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

        }
        public class FlightViewModel
        {
            public FormData FormData { get; set; }
            public List<Flight> Flights { get; set; }

            public List<Airline> Airlines { get; set; }
        }

        /* public class MyViewModel
         {
             public List<CustomFlight> Flights { get; set; }
             public List<Airline> Airlines { get; set; }
         }*/
        /*public class CustomFlightViewModel
        {
            public List<Seat> FlightSeats { get; set; }
            public CustomFlight CustomFlight { get; set; }
            public string seatNo { get; set; }
        }*/
        public class CustomFlight : Flight
        {
            public string duration;
            public string type { get; set; }
            public string flightClass { get; set; }
            public Airline airlineInfo { get; set; }
            public Airport from { get; set; }
            public Airport to { get; set; }
            public decimal classPricing { get; set; }

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
            Flight FlightDataWithSeats = await dbContext.Flights.Where(f => f.FlightId == Flight.FlightId).Include(s => s.Seats).FirstOrDefaultAsync();
            /*var FlightSeats = dbContext.Seats.Where(s => s.FlightId == Flight.FlightId).ToList();*/

            /*   Console.WriteLine(flightSeats.ToString());*/
            /*  foreach (var flight in flightSeats)
              {
                  Console.WriteLine(flight.Status);
              }*/
            //var BusySeats = FlightSeats.Where(seat => seat.Status == Csharp_DatVeMayBay.Models.Enums.SeatStatus.Busy);
            /*  foreach (var flight in FlightSeats)
              {
                  Console.WriteLine(flight.Status);
              }*/
            /*var viewModel = new CustomFlightViewModel
            {
                FlightSeats = flightSeats,
            };*/

            return View(FlightDataWithSeats);

        }
        /*[Route("/select-flight/flight-detail-booking")]
        [HttpPost]
        public IActionResult FLightDetailBooking()
        {
            var flightData = Request.Form["flightData"];
            var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
            var seatNo = Request.Form["seat"];
            var viewModel = new CustomFlightViewModel
            {
                CustomFlight = customFlight,
                seatNo = seatNo
            };

            return View(viewModel);

        }*/

        /* public IActionResult Passeng()
         {
             var flightData = Request.Form["flightData"];
             Console.WriteLine(flightData.ToString());
             var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
             customFlight.seat = Request.Form["seat"];
             var viewModel = new CustomFlightViewModel
             {
                 CustomFlight = customFlight,
             };

             return View(viewModel);

         }*/
    }
}
