using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Airline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AirlineId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AirlineName { get; set; }
        [Required]
        [MaxLength(100)]
        public string AirlineLogo { get; set; }

        [Required]
        [MaxLength(100)]
        public string AirlineCode { get; set; }
    }
}
