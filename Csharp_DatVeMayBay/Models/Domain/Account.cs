
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_DatVeMayBay.Models.Domain
{
    public class Account
    {
       /* public Account(string userEmail, String password)
        {
            UserEmail = userEmail;
            Password = password;
        }*/

        [Key]
        [Required(ErrorMessage = "Please input email")]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Please input password")]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        public bool Enable { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
