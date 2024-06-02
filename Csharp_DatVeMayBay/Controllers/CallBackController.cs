using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Strategy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Debugger.Contracts;

namespace Csharp_DatVeMayBay.Controllers
{
    public class CallBackController : Controller
    {
        private readonly DBContext dbContext;

        public CallBackController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> MomoPaymentCallBack(int errorCode, string extraData, string message)
        {
            if (errorCode == 0)
            {
                //Chuyển trạng thái Booking sang Paid
                string bookingID = extraData;
                Booking booking = await dbContext.Bookings.Where(t => t.BookingId == bookingID).Include(u => u.User).FirstOrDefaultAsync();
                booking.Status = Models.Enums.BookingStatus.Paid;
                await dbContext.SaveChangesAsync();

                Logger.GetInstance().Log($"User({booking.UserId}, {booking.User.FirstName + " " + booking.User.LastName}) paid successful");
                return Redirect($"/ticket-processing/{bookingID}");
            }
            else
            {
                TempData["cancelled"] = true;
                return Redirect("/payment-booking");
            }
        }

        [Route("/credit_callback/{bookingId}")]
        public async Task<IActionResult> CreditPaymentCallBack(string bookingId)
        {
            //Chuyển trạng thái Booking sang Paid
            /*string bookingID = extraData;*/
            Booking booking = await dbContext.Bookings.Where(t => t.BookingId == bookingId).Include(u => u.User).FirstOrDefaultAsync();
            booking.Status = Models.Enums.BookingStatus.Paid;
            await dbContext.SaveChangesAsync();

            Logger.GetInstance().Log($"User({booking.UserId}, {booking.User.FirstName + " " + booking.User.LastName}) paid successful");
            return Redirect($"/ticket-processing/{bookingId}");
        }
        public async Task<IActionResult> VNPayPaymentCallBack(string vnp_OrderInfo, int vnp_ResponseCode)
        {
            string bookingID = vnp_OrderInfo.Split(':').Last();

            //Chuyển trạng thái Booking sang Paid
            if (vnp_ResponseCode == 0)
            {
                //Chuyển trạng thái Booking sang Paid
                Booking booking = await dbContext.Bookings.Where(t => t.BookingId == bookingID).Include(u => u.User).FirstOrDefaultAsync();
                booking.Status = Models.Enums.BookingStatus.Paid;
                await dbContext.SaveChangesAsync();

                Logger.GetInstance().Log($"User({booking.UserId}, {booking.User.FirstName + " " + booking.User.LastName}) paid successful");
                return Redirect($"/ticket-processing/{bookingID}");
            }
            else
            {
                TempData["cancelled"] = true;
                return Redirect("/payment-booking");
            };
        }
    }
}
