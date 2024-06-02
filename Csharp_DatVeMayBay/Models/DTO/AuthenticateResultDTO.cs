using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Models.DTO
{
    public class AuthenticateResultDTO
    {
        public User User { get; set; }
        public string Message { get; set; }

        public RoleSystem Role { get; set; }

        public string ReturnUrl { get; set; }
    }
}
