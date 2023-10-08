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
        public int FlightId { get; set; }

        public char SeatRow { get; set; }

        public int SeatColumn { get; set; }  
        public SeatStatus Status { get; set; }
        public Flight Flight { get; set; }
    }
}
