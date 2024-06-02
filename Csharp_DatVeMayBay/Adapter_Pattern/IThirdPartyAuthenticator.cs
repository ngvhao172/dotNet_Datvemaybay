using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Microsoft.Identity.Client;

namespace Csharp_DatVeMayBay.Adapter_Pattern
{
    public interface IThirdPartyAuthenticator
    {
        Task<AuthenticateResultDTO> Authenticate(HttpContext context);
    }
}
