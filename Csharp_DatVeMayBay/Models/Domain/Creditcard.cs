using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Creditcard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardId { get; set; }
        public string CardHolderName { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }

        public User User { get; set; }
    }
}
