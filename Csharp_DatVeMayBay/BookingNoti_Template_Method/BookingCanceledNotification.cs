using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Services.EmailService;
using Csharp_DatVeMayBay.Template_Method;

namespace Csharp_DatVeMayBay.BookingNoti_Template_Method
{
    public class BookingCanceledNotification : EmailBookingNotification
    {
        public BookingCanceledNotification(Booking Booking, IEmailService emailService) : base(Booking, emailService)
        {
        }
        protected override string PrepareSubjectValue()
        {
            string subject = "[Starline] Booking Canceled Notification";
            return subject;
        }
        protected override string PrepareBodyValue()
        {
            string bookingReference = Booking.BookingId;
            string bookingDate = Booking.BookingDatime.ToString("yyyy-MM-dd");
            string bookingTime = Booking.BookingDatime.ToString("HH:mm");

            string body = $"Dear {Booking.User.FirstName +" "+ Booking.User.FirstName},\n\n";
            body += $"We regret to inform you that your booking with reference number {bookingReference} has been canceled.\n\n";
            body += "Booking Details:\n";
            body += $"- Date: {bookingDate}\n";
            body += $"- Time: {bookingTime}\n";
            body += "Please accept our apologies for any inconvenience caused. If you have any questions or need further assistance, feel free to contact us.\n\n";

            return body;
        }
    }
}
