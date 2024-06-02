using Csharp_DatVeMayBay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Booking
    {
        [Key]
        public string BookingId { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }

        [ForeignKey("Flight")]
        [Required]
        public int FlightId { get; set; }

        [ForeignKey("FlightReturn")]
        public int? FlightReturnId { get; set; }

        [Required]
        public DateTime BookingDatime { get; set; }

        [Required]
        public int PassengerCount { get; set; }

        [Required]
        public BookingType BookingType { get; set; }

        [Required]
        public BookingStatus Status { get; set; }
        public User User { get; set; }
        
        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }

        [ForeignKey("FlightReturnId")]
        public Flight? FlightReturn { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
