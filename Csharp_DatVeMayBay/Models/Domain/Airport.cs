using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int AirportId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AirportName { get; set; }
        [Required]
        [MaxLength(100)]
        public string AirportLocation { get; set; }
        [Required]
        [MaxLength(100)]
        public string AirportCode { get; set; }

    }
}
