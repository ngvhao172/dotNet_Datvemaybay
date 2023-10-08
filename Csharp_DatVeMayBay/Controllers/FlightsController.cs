using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
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
        public class MyViewModel
        {
            public List<CustomFlight> Flights { get; set; }
            public List<Airline> Airlines { get; set; }
        }
        public class CustomFlightViewModel
        {
            public List<Seat> FlightSeats { get; set; }
            public CustomFlight CustomFlight { get; set; }
            public string seatNo { get; set; }
        }
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

            var flights = dbContext.Flights.Where(f =>
                f.DepartureAiportId == departureAirportId &&
                f.ArrivalAiportId == arrivalAirportId &&
                f.DepartureDatetime.Date == inputDate)
                .ToList();
            var airlines = await dbContext.Airlines.ToListAsync();
            var airportDeparture = dbContext.Airports.FirstOrDefault(a => departureAirportId == a.AirportId);
            var airportArrival = dbContext.Airports.FirstOrDefault(a => arrivalAirportId == a.AirportId);

            var customFlights = new List<CustomFlight>();
            foreach (var flight in flights)
            {
                var cleanedTimeDifference = (flight.ArrivalDatetime - flight.DepartureDatetime).ToString().TrimStart('0').TrimEnd('0').TrimEnd(':');
                var customFlight = new CustomFlight()
                {
                    FlightId = flight.FlightId,
                    AirlineId = flight.AirlineId,
                    DepartureAiportId = flight.AirlineId,
                    ArrivalAiportId = flight.AirlineId,
                    DepartureDatetime = flight.DepartureDatetime,
                    ArrivalDatetime = flight.ArrivalDatetime,
                    EconomyPrice = flight.EconomyPrice,
                    BussinessPrice = flight.BussinessPrice,
                    airlineInfo = dbContext.Airlines.FirstOrDefault(a => flight.AirlineId == a.AirlineId),
                    from = airportDeparture,
                    to = airportArrival,
                    duration = cleanedTimeDifference + "h",
                    flightClass = flightClass,
                    type = type
                };
                if(flightClass == "PT")
                {
                    customFlight.classPricing = customFlight.EconomyPrice;
                }
                else
                {
                    customFlight.classPricing = customFlight.BussinessPrice;
                }
                customFlights.Add(customFlight);
            }

            var viewModel = new MyViewModel
            {
                Flights = customFlights,
                Airlines = airlines
            };
            if (flights.Any())
            {
                return View(viewModel);
            }
            else
            {
                ViewData["Message"] = "Không tìm thấy chuyến bay nào";
                return View(viewModel);
            }
        }
        [Route("/select-flight/booking-seat")]
        [HttpPost]
        public  IActionResult BookingSeat()
        {
            var flightData = Request.Form["flightData"];
            var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
            var flightSeats = dbContext.Seats.Where(s => s.FlightId == customFlight.FlightId).ToList();
            /*Console.WriteLine(flightSeats.ToString());*/
            /*foreach(var flight in flightSeats)
            {
                Console.WriteLine(flight.Status);
            }*/
            var busySeats = flightSeats.Where(seat => seat.Status == Csharp_DatVeMayBay.Models.Enums.SeatStatus.Busy);
            foreach (var flight in flightSeats)
            {
                Console.WriteLine(flight.Status);
            }
            var viewModel = new CustomFlightViewModel
            {
                FlightSeats = flightSeats,
                CustomFlight = customFlight,
            };

            return View(viewModel);

        }
        [Route("/select-flight/flight-detail-booking")]
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

        }

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
