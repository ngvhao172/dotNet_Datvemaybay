using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Csharp_DatVeMayBay.Controllers.ClientApi
{
    [ApiController]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly DBContext dbContext;
        public UserController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Route("AddingNewCreditCard")]
        public async Task<JsonResult> AddingNewCreditCard([FromForm] string cardHolderName, [FromForm] DateTime cardDate, [FromForm] string cardNumber)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = await dbContext.Users.Where(u => u.UserEmail == User.FindFirst(ClaimTypes.Email).Value).FirstAsync();
                /* var userCreditCards = await dbContext.Creditcards
                 .Where(c => c.UserId == userExist.UserId)
                 .ToListAsync();*/
                Creditcard newCreditCard = new Creditcard
                {
                    CardHolderName = cardHolderName,
                    CardNumber = cardNumber,
                    ExpirationDate = cardDate
                };
                /*var newCreditCards = cardList.Where(c => !userCreditCards.Any(uc => uc.CardId == c.CardId));*/
                //Lưu lại creditcard
                newCreditCard.UserId = user.UserId;
                await dbContext.AddAsync(newCreditCard);
                await dbContext.SaveChangesAsync();

                return Json(new { data = new { status = true, message = "Thêm thành công." } });
            }
            return Json(new { data = new { status = false, message = "User not authenticated." } });
        }

        [HttpPost]
        [Route("LoginInBookingProgess")]
        public async Task<JsonResult> Login([FromForm] string email, [FromForm] string password)
        {
            var Account = await dbContext.Accounts.Where(a => a.UserEmail == email).FirstOrDefaultAsync();
            if (Account != null)
            {
                if (Account.Verified == true)
                {
                    if (BCrypt.Net.BCrypt.EnhancedVerify(password, Account.Password))
                    {
                        var User = dbContext.Users.FirstOrDefault(u => u.UserEmail == Account.UserEmail);
                        if (User != null)
                        {
                            return Json(new { data = new { status = true, message = "Thêm thành công." } });
                        }
                    }
                    else
                    {
                        return Json(new { data = new { status = false, message = "Password Incorrect." } });
                    }
                }
                else
                {
                     return Json(new { data = new { status = false, message = "Please verifying your account before continuing." } });
                }
            }
            return Json(new { data = new { status = false, message = "No user found with that email." } });
        }
    }
}
