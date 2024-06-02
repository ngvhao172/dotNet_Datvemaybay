using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Services.EmailService;
using Csharp_DatVeMayBay.Template_Method;

namespace Csharp_DatVeMayBay.BookingNoti_Template_Method
{
    public class DelayBookingNotification : EmailBookingNotification
    {
        public DelayBookingNotification(Booking Booking, IEmailService emailService) : base(Booking, emailService)
        {
        }
        protected override string PrepareBodyValue()
        {
            string body = @"
                <html>
                <body>
                    <div style='border:1px solid black; padding:10px; width:500px;'>
                        <p>Kính gửi Quý Khách hàng thân mến,</p><br>
                        <p>Chúng tôi xin gửi đến Quý Khách hàng lời chào nồng hậu từ Starline Airline. Chúng tôi rất trân trọng sự ủng hộ và lòng tin yêu mến mà Quý Khách dành cho dịch vụ của chúng tôi.</p><br>
                        <p>Chúng tôi xin thông báo về sự điều chỉnh nhỏ trong lịch trình chuyến bay của Quý Khách. Vì lí do thời tiết không được ổn định và những nguyên nhân khách quan khác, cũng như là để cải thiện dịch vụ và tối ưu hóa trải nghiệm của Quý Khách, chúng tôi đã quyết định điều chỉnh thời gian bay của chuyến bay số Airline A" + Booking.FlightId + @" như sau:</p><br>
                        <p><strong>Chuyến Bay thay đổi:</strong></p>
                        <p>Thời gian khởi hành mới: <strong>" + Booking.Flight.DepartureDatetime + @"</strong></p>
                        <p>Thời gian bay đến mới: <strong>" + Booking.Flight.ArrivalDatetime + @"</strong></p><br>
                        <p>Chúng tôi rất xin lỗi về bất kỳ sự bất tiện nào có thể gây ra do sự thay đổi này. Chúng tôi cam kết sẽ cung cấp mọi hỗ trợ cần thiết để đảm bảo chuyến bay của Quý Khách diễn ra một cách thuận lợi nhất có thể.</p><br>
                        <p>Để biết thêm thông tin chi tiết hoặc để thay đổi chuyến bay của mình, vui lòng liên hệ với chúng tôi qua tổng đài hoặc truy cập vào trang web của chúng tôi.</p><br>
                        <p>Rất mong nhận được sự hiểu thông của Quý Khách và mong rằng Quý Khách sẽ tiếp tục ủng hộ Starline Airline.</p><br>
                        <p>Chúng tôi xin chân thành cảm ơn!</p>
                    </div>
                </body>
                </html>";
            return body;
        }

        protected override string PrepareSubjectValue()
        {
            string subject = "[Starline] Booking Delay Notification";
            return subject;
        }
    }
}
