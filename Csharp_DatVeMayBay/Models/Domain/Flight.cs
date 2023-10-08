using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightId { get; set; }
        [Required]
        public int AirlineId { get; set; }
        [Required]
        public int DepartureAiportId { get; set; }
        [Required]
        public int ArrivalAiportId { get; set; }

        [Required]
        public DateTime DepartureDatetime { get; set; }

        [Required]
        public DateTime ArrivalDatetime { get; set; }

        [Required]
        public decimal EconomyPrice { get; set; }

        [Required]
        public decimal BussinessPrice { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}
