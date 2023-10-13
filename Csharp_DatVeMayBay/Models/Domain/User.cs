using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [MaxLength(100)]
        public string? UserEmail { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set;}

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set;}

        [Required]
        [MaxLength(100)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public DateTime Dob { get; set; }

        public ICollection<Creditcard> Creditcards { get; set; }

    }
}
