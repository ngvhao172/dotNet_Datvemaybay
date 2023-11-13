using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.X9;
using RestSharp;
using System.Security.Cryptography;
using System.Text;

namespace Csharp_DatVeMayBay.Controllers
{
    public class MoMoController : Controller
    {
        private readonly IConfiguration _config;
        private readonly DBContext dbContext;

        public MoMoController(IConfiguration config, DBContext dbContext)
        {
            _config = config;
            this.dbContext = dbContext;
        }
        [Route("paymentWithMomo/{bookingId}/{total}")]
        public async Task<IActionResult> momoPayment(string bookingId, string total)
        {
            string endpoint = _config.GetSection("MoMoAPI:MomoApiUrl").Value.ToString();
            string partnerCodeValue = "MOMO";
            string accessKeyValue = _config.GetSection("MoMoAPI:AccessKey").Value.ToString();
            string serectkeyValue = _config.GetSection("MoMoAPI:SecretKey").Value.ToString();
            string orderInfoValue = "Thanh toán qua ví điện tử Momo";
            string returnUrlValue = _config.GetSection("MoMoAPI:ReturnUrl").Value.ToString();
            string notifyUrlValue = _config.GetSection("MoMoAPI:NotifyUrl").Value.ToString();
            string requestTypeValue = "captureMoMoWallet";

            string totalValue = total.Substring(0, total.Length - 3); ;
            /*string orderIdValue = partnerCodeValue + DateTime.UtcNow.Ticks.ToString();*/
            string orderIdValue = Guid.NewGuid().ToString();

            var rawData =
            $"partnerCode={partnerCodeValue}&accessKey={accessKeyValue}&requestId={orderIdValue}&amount={totalValue}&orderId={orderIdValue}&orderInfo={orderInfoValue}&returnUrl={returnUrlValue}&notifyUrl={notifyUrlValue}&extraData={bookingId}";

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
                extraData = bookingId,
                signature = signatureValue,
                lang =  "en"
            };

            request.AddParameter("application/json", JsonConvert.SerializeObject(requestData), ParameterType.RequestBody);

            var response = await client.ExecuteAsync(request);

            var result =  JsonConvert.DeserializeObject<MoMoResponseDTO>(response.Content);
            return Redirect(result.PayUrl.ToString());
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

        public async Task<IActionResult> PaymentCallBack(int errorCode, string extraData, string message)
        {
            if(errorCode == 0)
            {
                //Sucess
                string ticketId = extraData;
                Ticket ticket = await dbContext.Tickets.Where(t => t.TicketId == ticketId).FirstOrDefaultAsync();
                if (ticket != null)
                {
                    //Cập nhật trạng thái vé
                    ticket.Status = Models.Enums.TicketStatus.Paid;
                    dbContext.Tickets.Update(ticket);

                    //Cập nhật trạng thái ghế ngồi
                    Seat seatBooked = await dbContext.Seats.Where(s => s.SeatId == ticket.SeatId).FirstOrDefaultAsync();
                    seatBooked.Status = Models.Enums.SeatStatus.Busy;

                    await dbContext.SaveChangesAsync();

                    Console.WriteLine(ticket.Status);
                    Console.WriteLine(message);

                    return Redirect("/ticket-momo-processing/" + ticket.TicketId);
                }
                TempData["error"] = "Error. Ticket not found!";
                return Redirect("/");
            }
            else
            {
                //Fail
            /*    string ticketId = extraData;
                Ticket ticket = await dbContext.Tickets.Where(t => t.TicketId == ticketId).FirstOrDefaultAsync();
                if(ticket != null) {
                    Booking booking = await dbContext.Bookings.Where(b => b.BookingId == ticket.BookingId).FirstOrDefaultAsync();

                    dbContext.Bookings.Remove(booking);
                    dbContext.Tickets.Remove(ticket);
                }*/
                TempData["error"] = "Error. " + message;
                return Redirect("/");
            }
        }

    }
}
