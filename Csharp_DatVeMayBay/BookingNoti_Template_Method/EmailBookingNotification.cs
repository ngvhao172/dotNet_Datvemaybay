using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Csharp_DatVeMayBay.Services.EmailService;

namespace Csharp_DatVeMayBay.Template_Method
{
    public abstract class EmailBookingNotification
    {
        protected Booking Booking;
        private readonly IEmailService _emailService;
        public EmailBookingNotification(Booking Booking, IEmailService emailService)
        {
            this.Booking = Booking;
            this._emailService = emailService;
        }
        public void Notify()
        {
            string ToValue = PrepareToValue();
            string SubjectValue = PrepareSubjectValue();
            string BodyValue = PrepareBodyValue();

            EmailDTO newEmail = new EmailDTO();
            newEmail.To = ToValue;
            newEmail.Subject = SubjectValue;
            newEmail.Body = BodyValue;
            SendNotification(newEmail);
        }
        protected string PrepareToValue()
        {
            return Booking.User.UserEmail;
        }
        protected abstract string PrepareSubjectValue();
        protected abstract string PrepareBodyValue();

        protected void SendNotification(EmailDTO newEmail)
        {
            _emailService.SendEmail(newEmail);
        }
    }
}
