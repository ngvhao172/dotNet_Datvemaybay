using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Csharp_DatVeMayBay.Data;
using Microsoft.EntityFrameworkCore;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    public class HistoryTicketController : Controller
    {
        private readonly DBContext dbContext;

        public HistoryTicketController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public JsonResult GetAllTicket(DateTime fromDate, DateTime toDate)
        {
            if (fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
            {
                var tickets = dbContext.Tickets.Where(ticket => ticket.Booking.BookingDatime >= fromDate && ticket.Booking.BookingDatime <= toDate)
                 .Include(ticket => ticket.Booking)
                     .ThenInclude(booking => booking.User)
                 .Include(ticket => ticket.Flight)
                 .Include(ticket => ticket.Seat)
                 .Select(t => new
                 {
                     userId = t.Booking.UserId,
                     userEmail = t.Booking.User.UserEmail,
                     ticketId = t.TicketId,
                     bookingId = t.Booking.BookingId,
                     bookingDatime = t.Booking.BookingDatime,
                     flightId = t.FlightId,
                     ticketPrice = t.TicketPrice,
                     status = t.Status
                 }).ToList();
                return Json(new { status = true, data = tickets });
            }
            else
            {
                var tickets = dbContext.Tickets
                .Include(ticket => ticket.Booking)
                    .ThenInclude(booking => booking.User)
                .Include(ticket => ticket.Flight)
                .Include(ticket => ticket.Seat)
                .Select(t => new
                {
                    userId = t.Booking.UserId,
                    userEmail = t.Booking.User.UserEmail,
                    ticketId = t.TicketId,
                    bookingId = t.Booking.BookingId,
                    bookingDatime = t.Booking.BookingDatime,
                    flightId = t.FlightId,
                    ticketPrice = t.TicketPrice,
                    status = t.Status
                });
                return Json(new { status = true, data = tickets });
            }
        }

    }
}