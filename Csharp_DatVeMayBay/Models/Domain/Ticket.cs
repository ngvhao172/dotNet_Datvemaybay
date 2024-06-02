using Csharp_DatVeMayBay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Ticket
    {
        [Key]
        [MaxLength(100)]
        public string TicketId { get; set; }

        [Required]
        public decimal TicketPrice { get; set; }
        [Required]
        public TicketStatus Status { get; set; }
        [MaxLength(100)]
        [Required]
        public TicketClass TicketClass { get; set; }

        [ForeignKey("Booking")]
        [Required]
        public string BookingId { get; set; }

        [ForeignKey("Flight")]
        [Required]
        public int FlightId { get; set; }
        
        [ForeignKey("Seat")]
        [Required]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public Flight Flight { get; set; }
        public Booking Booking { get; set; }
    }
}
