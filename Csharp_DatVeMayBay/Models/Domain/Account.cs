
using Microsoft.Extensions.Primitives;
using NuGet.ContentModel;
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

        [Key, MaxLength(100)]
        [Required(ErrorMessage = "Please input email")]
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string UserEmail { get; set; }
        [MaxLength(100), Required(ErrorMessage = "Please input password")]
        public string Password { get; set; }

        [Required]
        public bool Enable { get; set; }

        [Required, ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public bool Verified { get; set; } = false;
    }
}

