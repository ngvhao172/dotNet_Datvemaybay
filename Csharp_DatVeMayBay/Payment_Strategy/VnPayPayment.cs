using Azure;
using Csharp_DatVeMayBay.Payment_Strategy.VNPayLib;
using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X9;

namespace Csharp_DatVeMayBay.Strategy
{
    public class VNPayPayment : IPaymentStrategy
    {
        private readonly IConfiguration _config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();
        public Task<string> Pay(string BookingId, double Price)
        {
            //Get Config Info
            string vnp_Returnurl = _config.GetSection("Vnpay:ReturnUrl").Value.ToString(); //URL nhan ket qua tra ve 
            string vnp_Url = _config.GetSection("Vnpay:BaseUrl").Value.ToString();  //URL thanh toan cua VNPAY 
            string vnp_TmnCode = _config.GetSection("Vnpay:TmnCode").Value.ToString();  //Ma định danh merchant kết nối (Terminal Id)
            string vnp_HashSecret = _config.GetSection("Vnpay:HashSecret").Value.ToString(); //Secret Key
            string vnp_Local = _config.GetSection("Vnpay:Locale").Value.ToString();
            string vnp_CurrCode = _config.GetSection("Vnpay:CurrCode").Value.ToString();
            string vnp_Command = _config.GetSection("Vnpay:Command").Value.ToString();
            //Get payment input
            var order = new
            {
                OrderId = DateTime.Now.Ticks, // Giả lập mã giao dịch hệ thống merchant gửi sang VNPAY
                Amount = Price, // Giả lập số tiền thanh toán hệ thống merchant gửi sang VNPAY 100,000 VND
                Status = "0", //0: Trạng thái thanh toán "chờ thanh toán" hoặc "Pending" khởi tạo giao dịch chưa có IPN
                CreatedDate = DateTime.Now
            };

            //Save order to db

            //Build URL for VNPAY
            VnPayLib vnpay = new VnPayLib();

            vnpay.AddRequestData("vnp_Version", VnPayLib.VERSION);
            vnpay.AddRequestData("vnp_Command", vnp_Command);
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", (order.Amount * 100).ToString()); //Số tiền thanh toán. Số tiền không mang các ký tự phân tách thập phân, phần nghìn, ký tự tiền tệ. Để gửi số tiền thanh toán là 100,000 VND (một trăm nghìn VNĐ) thì merchant cần nhân thêm 100 lần (khử phần thập phân), sau đó gửi sang VNPAY là: 10000000

            vnpay.AddRequestData("vnp_CreateDate", order.CreatedDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", vnp_CurrCode);
            vnpay.AddRequestData("vnp_IpAddr", vnpay.GetIpAddress());

            vnpay.AddRequestData("vnp_Locale", vnp_Local);

            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + order.OrderId + "_bookingId:" + BookingId);
            vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other

            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", order.OrderId.ToString()); // Mã tham chiếu của giao dịch tại hệ thống của merchant. Mã này là duy nhất dùng để phân biệt các đơn hàng gửi sang VNPAY. Không được trùng lặp trong ngày


            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
            return Task.FromResult(paymentUrl);
        }
    }
}
