using Csharp_DatVeMayBay.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Seat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeatId { get; set; }

        [ForeignKey("Flight")]
        [Required]
        public int FlightId { get; set; }
        [Required]
        public char SeatRow { get; set; }
        [Required]
        public int SeatColumn { get; set; }  
        public SeatStatus Status { get; set; }
        public Flight Flight { get; set; }
    }
}
