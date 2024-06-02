using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using static Csharp_DatVeMayBay.Controllers.BookingController;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace Csharp_DatVeMayBay.Strategy
{
    public class MomoPayment : IPaymentStrategy
    {
        private readonly IConfiguration _config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

        public async Task<string> Pay(string bookingId, double Price)
        {
            string endpoint = _config.GetSection("MoMoAPI:MomoApiUrl").Value.ToString();
            string partnerCodeValue = "MOMO";
            string accessKeyValue = _config.GetSection("MoMoAPI:AccessKey").Value.ToString();
            string serectkeyValue = _config.GetSection("MoMoAPI:SecretKey").Value.ToString();
            string orderInfoValue = "Thanh toán qua ví điện tử Momo";
            string returnUrlValue = _config.GetSection("MoMoAPI:ReturnUrl").Value.ToString();
            string notifyUrlValue = _config.GetSection("MoMoAPI:NotifyUrl").Value.ToString();
            string requestTypeValue = "captureMoMoWallet";

            string totalValue = Price.ToString();
            /*string orderIdValue = partnerCodeValue + DateTime.UtcNow.Ticks.ToString();*/
            string orderIdValue = Guid.NewGuid().ToString();

            var rawData =
            $"partnerCode={partnerCodeValue}&accessKey={accessKeyValue}&requestId={orderIdValue}&amount={totalValue}&orderId={orderIdValue}&orderInfo={orderInfoValue}&returnUrl={returnUrlValue}&notifyUrl={notifyUrlValue}&extraData={bookingId.ToString()}";

            var signatureValue = ComputeHmacSha256(rawData, serectkeyValue);

            var client = new RestClient(endpoint);
            var request = new RestRequest() { Method = Method.Post };
            request.AddHeader("Content-Type", "application/json; charset=UTF-8");

            // Create an object representing the request data
            var requestData = new
            {
                accessKey = accessKeyValue,
                partnerCode = partnerCodeValue,
                requestType = requestTypeValue,
                notifyUrl = notifyUrlValue,
                returnUrl = returnUrlValue,
                orderId = orderIdValue,
                amount = totalValue,
                orderInfo = orderInfoValue,
                requestId = orderIdValue,
                extraData = bookingId.ToString(),
                signature = signatureValue,
                lang = "en"
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(requestData), ParameterType.RequestBody);

            var response = await client.ExecuteAsync(request);

            var result = JsonConvert.DeserializeObject<MoMoResponseDTO>(response.Content);
            return result.PayUrl.ToString();

        }
        public static string ComputeHmacSha256(string message, string key)
        {
            byte[] keyByte = Encoding.UTF8.GetBytes(key);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                string hex = BitConverter.ToString(hashmessage);
                hex = hex.Replace("-", "").ToLower();
                return hex;
            }
        }
    }
}
