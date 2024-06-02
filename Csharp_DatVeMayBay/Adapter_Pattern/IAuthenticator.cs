using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;

namespace Csharp_DatVeMayBay.Adapter_Pattern
{
    public interface IAuthenticator
    {
        Task<AuthenticateResultDTO> Authenticate(Account UserAccount);
    }
}
