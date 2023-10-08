using Csharp_DatVeMayBay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Flight")]
        public int FlightId { get; set; }
        public DateTime BookingDatime { get; set; }
        public int PassengerCount { get; set; }
        public BookingStatus Status { get; set; }

        public User User { get; set; }
        public Flight Flight { get; set; }
    }
}
