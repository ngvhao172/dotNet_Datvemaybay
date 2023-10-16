using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    [ApiController]
    [Route("api/Flights")]
    public class FlightController : Controller
    {
        private readonly DBContext dbContext;
        public FlightController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Route("GetAllFlights")]
        public JsonResult GetAllFlights()
        {
            var flights = dbContext.Flights.Include(flight => flight.Airline).Include(flight => flight.DepartureAirport).Include(flight => flight.ArrivalAirport).ToList();
            return Json(new { data = flights });
        }
        [HttpPost]
        [Route("GetAllFlightsToday")]
        public JsonResult GetAllFlightsToday()
        {
            var currentDate = DateTime.Now.Date;
            var flights = dbContext.Flights
                .Where(f => f.DepartureDatetime.Year == currentDate.Year
                            && f.DepartureDatetime.Month == currentDate.Month
                            && f.DepartureDatetime.Day == currentDate.Day).Include(flight => flight.Airline).Include(flight => flight.DepartureAirport).Include(flight => flight.ArrivalAirport)
                .ToList();
            var airlines = new List<Airline>();

            return Json(new { data = flights });

        }

        [HttpPost]
        [Route("GetFlightById")]
        public JsonResult GetFlightById([FromForm] string flight_id)
        {
            var airline = dbContext.Flights.Where(a => a.FlightId == Int16.Parse(flight_id)).FirstOrDefault();
            return Json(new { data = airline });
        }
        [HttpPost]
        [Route("DeleteFlight")]
        public JsonResult DeleteFlight([FromForm] string flight_id)
        {
            var flight = dbContext.Flights.Where(f => f.FlightId == Int16.Parse(flight_id)).FirstOrDefault();
            try
            {
                dbContext.Flights.Remove(flight);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Xóa thành công." } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString() } });
            }
          
        }
        [HttpPost]
        [Route("UpdateFlight")]
        public JsonResult UpdateFlight([FromForm] string flight_id, [FromForm] string airline_id, [FromForm] string departure_airport_id, [FromForm] string arrival_airport_id, [FromForm] string departure_datetime,
            [FromForm] string arrival_datetime, [FromForm] string economy_price, [FromForm] string business_price)
        {
            var flight = dbContext.Flights.Where(f => f.FlightId == Int16.Parse(flight_id)).FirstOrDefault();
            flight.AirlineId = Int16.Parse(airline_id);
            flight.DepartureAirportId = Int16.Parse(departure_airport_id);
            flight.ArrivalAirportId = Int16.Parse(arrival_airport_id);
            flight.DepartureDatetime = DateTime.Parse(departure_datetime);
            flight.ArrivalDatetime = DateTime.Parse(arrival_datetime);
            flight.EconomyPrice = Int32.Parse(economy_price);
            flight.BussinessPrice = Int32.Parse(business_price);
            try
            {
                dbContext.Flights.Update(flight);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Sửa thành công." } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi sửa! " + ex.Message.ToString() } });
            }
        }
        [HttpPost]
        [Route("AddFlight")]
        public JsonResult AddFlight([FromForm] string airline_id, [FromForm] string departure_airport_id, [FromForm] string arrival_airport_id, [FromForm] string departure_datetime,
            [FromForm] string arrival_datetime, [FromForm] string economy_price, [FromForm] string business_price)
        {
            var flight = new Flight();
            flight.AirlineId = Int16.Parse(airline_id);
            flight.DepartureAirportId = Int16.Parse(departure_airport_id);
            flight.ArrivalAirportId = Int16.Parse(arrival_airport_id);
            flight.DepartureDatetime = DateTime.Parse(departure_datetime);
            flight.ArrivalDatetime = DateTime.Parse(arrival_datetime);
            flight.EconomyPrice = Int32.Parse(economy_price);
            flight.BussinessPrice = Int32.Parse(business_price);
            try
            {
                dbContext.Flights.Add(flight);
                dbContext.SaveChanges();

                /*Thêm ghế phụ thuộc*/
                for (char seatRow = 'A'; seatRow <= 'F'; seatRow++)
                {
                    for (int seatColumn = 1; seatColumn <= 6; seatColumn++)
                    {
                        var seat = new Seat
                        {
                            FlightId = flight.FlightId,
                            SeatColumn = seatColumn,
                            SeatRow = seatRow,
                            Status = Models.Enums.SeatStatus.Available
                        };
                        dbContext.Seats.Add(seat);
                    }
                }
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Thêm thành công." } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi thêm! " + ex.Message.ToString() } });
            }
        }
    }
}
