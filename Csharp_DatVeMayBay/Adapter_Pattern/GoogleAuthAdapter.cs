using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using System.Security.Policy;

namespace Csharp_DatVeMayBay.Adapter_Pattern
{
    public class GoogleAuthAdapter : IAuthenticator
    {
        private GoogleAuthenticator _googleAuthenticator;
        private HttpContext _context;

        public GoogleAuthAdapter(GoogleAuthenticator googleAuthenticator, HttpContext context)
        {
            _googleAuthenticator = googleAuthenticator;
            _context = context;
        }
        public async Task<AuthenticateResultDTO> Authenticate(Account UserAccount)
        {
            return await _googleAuthenticator.Authenticate(_context);
        }
    }
}
