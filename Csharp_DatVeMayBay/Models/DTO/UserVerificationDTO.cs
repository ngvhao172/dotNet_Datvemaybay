using System.ComponentModel.DataAnnotations;

namespace Csharp_DatVeMayBay.Models.DTO
{
    public class UserVerification
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UniqueString { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
