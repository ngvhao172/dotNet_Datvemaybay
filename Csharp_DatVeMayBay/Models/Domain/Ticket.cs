using Csharp_DatVeMayBay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Ticket
    {
        [Key]
        public string TicketId { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        [ForeignKey("Flight")]
        public int FlightId { get; set; }
        
        [ForeignKey("Seat")]
        public int SeatId { get; set; }

        public decimal TicketPrice { get; set; }
        public TicketStatus Status { get; set; }

        public Seat Seat { get; set; }
        public Flight Flight { get; set; }
        public Booking Booking { get; set; }
    }
}
