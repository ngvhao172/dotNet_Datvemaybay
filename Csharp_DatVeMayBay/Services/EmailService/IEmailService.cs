using Csharp_DatVeMayBay.Models.DTO;
namespace Csharp_DatVeMayBay.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
