using Csharp_DatVeMayBay.BookingNoti_Template_Method;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Observer_Pattern;
using Csharp_DatVeMayBay.Services.EmailService;
using Csharp_DatVeMayBay.Template_Method;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Helpers;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    [ApiController]
    [Route("api/Flights")]
    public class FlightController : Controller
    {
        private readonly DBContext dbContext;
        private readonly FlightTimeSubject flightTimeSubject = new FlightTimeSubject();
        public FlightController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public JsonResult GetAllFlights(DateTime fromDate, DateTime toDate)
        {
            List<Flight> flights;
            if (fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
            {
                flights = dbContext.Flights.Include(flight => flight.Airline).Include(flight => flight.DepartureAirport).Include(flight => flight.ArrivalAirport).Where(f => f.DepartureDatetime >= fromDate && f.DepartureDatetime <= toDate).ToList();
            }
            else
            {
                flights = dbContext.Flights.Include(flight => flight.Airline).Include(flight => flight.DepartureAirport).Include(flight => flight.ArrivalAirport).ToList();
            }
            return Json(new { status = true, data = flights });
        }
        public JsonResult GetAllFlightsToday()
        {
            var currentDate = DateTime.Now.Date;
            var flights = dbContext.Flights
                .Where(f => f.DepartureDatetime.Year == currentDate.Year
                            && f.DepartureDatetime.Month == currentDate.Month
                            && f.DepartureDatetime.Day == currentDate.Day).Include(flight => flight.Airline).Include(flight => flight.DepartureAirport).Include(flight => flight.ArrivalAirport)
                .ToList();
            var airlines = new List<Airline>();

            return Json(new { status = true, data = flights });

        }

        public JsonResult GetFlightById(string flight_id)
        {
            var airline = dbContext.Flights.Where(a => a.FlightId == Int16.Parse(flight_id)).FirstOrDefault();
            return Json(new { status = true, data = airline });
        }

        public JsonResult DeleteFlight(string flight_id)
        {
            var flight = dbContext.Flights.Where(f => f.FlightId == Int16.Parse(flight_id)).FirstOrDefault();
            try
            {
                dbContext.Flights.Remove(flight);
                dbContext.SaveChanges();
                return Json(new { status = true, message = "Xóa thành công." });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString()  });
            }
          
        }

        public JsonResult UpdateFlight(string flight_id, string airline_id, string departure_airport_id, string arrival_airport_id, string departure_datetime,
            string arrival_datetime,  string economy_price, string business_price)
        {
            var flight = dbContext.Flights.Where(f => f.FlightId == Int16.Parse(flight_id)).FirstOrDefault();

            var oldDepartureTime = flight.DepartureDatetime;
            var oldArrivalTime = flight.ArrivalDatetime;

            flight.AirlineId = Int16.Parse(airline_id);
            flight.DepartureAirportId = Int16.Parse(departure_airport_id);
            flight.ArrivalAirportId = Int16.Parse(arrival_airport_id);
            flight.DepartureDatetime = DateTime.Parse(departure_datetime);
            flight.ArrivalDatetime = DateTime.Parse(arrival_datetime);
            flight.EconomyPrice = Int32.Parse(economy_price);
            flight.BussinessPrice = Int32.Parse(business_price);

            if (oldDepartureTime != DateTime.Parse(departure_datetime) || oldArrivalTime != DateTime.Parse(arrival_datetime))
            {
                var bookings = dbContext.Bookings.Where(b => b.FlightId == flight.FlightId)
                        .Include(b => b.User)
                        .Include(b => b.Flight)
                        .ToList();

                foreach (var booking in bookings)
                {
                    if (booking.User.UserEmail != null)
                    {
                        Customer customer = new Customer(booking.User.UserEmail);
                        flightTimeSubject.Register(customer);
                    } 
                }
                flightTimeSubject.Notify(flight);
            }
            try
            {
                dbContext.Flights.Update(flight);
                dbContext.SaveChanges();
                return Json(new { status = true, message = "Sửa thành công."  });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "Có lỗi khi sửa! " + ex.Message.ToString() });
            }
        }
        public JsonResult AddFlight(string airline_id,string departure_airport_id, string arrival_airport_id,string departure_datetime,
            string arrival_datetime, string economy_price, string business_price)
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
                return Json(new { status = true, message = "Thêm thành công." });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "Có lỗi khi thêm! " + ex.Message.ToString() });
            }
        }
    }
}
