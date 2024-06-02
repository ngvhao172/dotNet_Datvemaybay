using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Creditcard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardId { get; set; }
        [MaxLength(100)]
        [Required]
        public string CardHolderName { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CardNumber { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
