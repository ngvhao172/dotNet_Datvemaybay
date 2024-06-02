using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using static Csharp_DatVeMayBay.Controllers.FlightsController;

namespace Csharp_DatVeMayBay.Command_Pattern
{
    public class FlightService
    {
        private DBContext dbContext;
        public FlightService(DBContext context) {
            dbContext = context;
        }
        public async Task<List<Flight>> SearchFlightsAsync(FormData FormData)
        {
            var flights = await dbContext.Flights.Where(f =>
                        f.DepartureAirportId == FormData.DepartureAirport.AirportId &&
                        f.ArrivalAirportId == FormData.ArrivalAirport.AirportId &&
                        f.DepartureDatetime.Date == FormData.DepartureDate && f.DepartureDatetime > DateTime.Now).Include(a => a.DepartureAirport).Include(a => a.ArrivalAirport).Include(a => a.Airline)
                        .ToListAsync();
            return flights;
        }
        public async Task<Booking> GetBookingInfoAsync(string bookingId)
        {
            Booking? Booking = await
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
                .FirstOrDefaultAsync();
            return Booking;
        }
        public async Task<Ticket> GetTicketInfoAsync(string ticketId)
        {
            Ticket? Ticket = await dbContext.Tickets
                .Where(t => t.TicketId == ticketId)
                .Include(f => f.Flight)
                .ThenInclude(a => a.Airline)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.DepartureAirport)
                .Include(f => f.Flight)
                    .ThenInclude(a => a.ArrivalAirport)
                .Include(s => s.Seat)
                .Include(f => f.Booking)
                    .ThenInclude(a => a.User)
                .FirstOrDefaultAsync();
            return Ticket;
        }

        public async Task<bool> CancelBookingAsync(string bookingId)
        {
            Booking? booking = await dbContext.Bookings
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
                .FirstOrDefaultAsync(b => b.BookingId == bookingId);

            if (booking != null)
            {
                booking.Status = Models.Enums.BookingStatus.Cancelled;
                //Cập nhật lại trạng thái vé, ghế ngồi
                foreach(var ticket in booking.Tickets)
                {
                    ticket.Status = Models.Enums.TicketStatus.Cancelled;
                    ticket.Seat.Status = Models.Enums.SeatStatus.Available;
                }
                await dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

    }
}
