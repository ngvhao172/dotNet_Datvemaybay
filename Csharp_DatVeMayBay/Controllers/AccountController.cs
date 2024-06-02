using Csharp_DatVeMayBay.Services.EmailService;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Csharp_DatVeMayBay.Controllers
{
    public class AccountController : Controller
    {
        private readonly DBContext dbContext;
        public AccountController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public class UserProfile
        {
            public User User;
            public List<Booking> Bookings;
            public List<Ticket> Tickets;
            public List<Creditcard> creditCards;
        }
    /*    static Creditcard creditAdd;*/
        //Đổi mật khẩu
        [Route("me/changepassword")]
        [HttpGet]
        public IActionResult ChangePasswordUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("Error403", "Error");
        }
        [Route("me/changepassword")]
        [HttpPost]
        public IActionResult ChangePasswordUserAccount()
        {
            var currentPassword = Request.Form["currentPassword"];
            var newPassword = Request.Form["newPassword"];
            var cfPassword = Request.Form["cPassword"];
            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                ModelState.AddModelError("CurrentPassword", "Current Password is required.");
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                ModelState.AddModelError("NewPassword", "New Password is required.");
            }
            if (string.IsNullOrWhiteSpace(cfPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "Confirm Password is required.");
            }
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    var UserEmail = User.FindFirst(ClaimTypes.Email).Value;
                    if (UserEmail != null)
                    {
                        var Account = dbContext.Accounts.Where(a => a.UserEmail == UserEmail).FirstOrDefault();
                        if (Account != null)
                        {
                            if (BCrypt.Net.BCrypt.EnhancedVerify(currentPassword, Account.Password))
                            {
                                if (newPassword == cfPassword)
                                {
                                    try
                                    {
                                        var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, 13);
                                        Account.Password = hashedPassword;
                                        dbContext.Accounts.Update(Account);
                                        dbContext.SaveChanges();
                                        ViewData["status"] = "success";
                                        ViewData["message"] = "Password has been changed successfully";
                                    }
                                    catch (Exception ex)
                                    {
                                        ViewData["status"] = "danger";
                                        ViewData["message"] = "Fail to change password! " + ex.Message;
                                    }
                                }
                                else
                                {
                                    ViewData["status"] = "danger";
                                    ViewData["message"] = "Password confirm incorrect!";
                                }
                            }
                            else
                            {
                                ViewData["status"] = "danger";
                                ViewData["message"] = "Current Password incorrect!";
                            }
                        }
                        else
                        {
                            ViewData["status"] = "danger";
                            ViewData["message"] = "User Account not found!";
                        }
                    }
                    else
                    {
                        ViewData["status"] = "danger";
                        ViewData["message"] = "UserEmail not found!";
                    }
                }
                else
                {
                    ViewData["status"] = "danger";
                    ViewData["message"] = "Input invalid. Please filling all input!";
                }
            }
            else
            {
                ViewData["status"] = "danger";
                ViewData["message"] = "User is not logined.";
            }
            return View("ChangePasswordUser");
        }

        [Route("me")]
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userEmail = User.FindFirst(ClaimTypes.Email).Value;
                var user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserEmail == userEmail);
                if (user != null)
                {
                    var bookings = await dbContext.Bookings.Where(b => b.UserId == user.UserId).ToListAsync();


                    var userProfile = new UserProfile
                    {
                        User = user,
                        Tickets = new List<Ticket>(),
                        creditCards = new List<Creditcard>()
                    };
                    var creditCards = await dbContext.Creditcards.Where(c => c.UserId == user.UserId).ToListAsync();
                    userProfile.creditCards.AddRange(creditCards);

                    for(int i = bookings.Count - 1 ; i>0; i--)
                    {
                        var tickets = await dbContext.Tickets
                           .Where(t => t.BookingId == bookings[i].BookingId)
                           .Include(t => t.Flight)
                               .ThenInclude(f => f.Airline)
                           .Include(t => t.Flight)
                               .ThenInclude(f => f.DepartureAirport)
                           .Include(t => t.Flight)
                               .ThenInclude(f => f.ArrivalAirport)
                           .Include(t => t.Seat)
                           .Include(t => t.Booking)
                           .ToListAsync();

                        userProfile.Tickets.AddRange(tickets);
                    }
                    return View("Index", userProfile);
                }
                else
                {
                    return RedirectToAction("Error403", "Error");
                }
            }
            else
            {
                return RedirectToAction("Error403", "Error");
            }
        }
        [HttpPost]
        [Route("me")]
        public async Task<IActionResult> AddCreditCards()
        {
            var creditNum = Request.Form["cardnum"];
            var creditName = Request.Form["holdername"];
            var creditExp = Request.Form["expdate"];

            string userEmail = User.FindFirst(ClaimTypes.Email).Value;
            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserEmail == userEmail);

            if (user != null)
            {
                var creditcard = new Creditcard
                {
                    UserId = user.UserId,
                    CardNumber = creditNum,
                    CardHolderName = creditName,
                    ExpirationDate = DateTime.Parse(creditExp)
                };
                await dbContext.AddAsync(creditcard);
                await dbContext.SaveChangesAsync();
                ViewData["status"] = "success";
                ViewData["message"] = "Credit cards have been added successfully.";
                return RedirectToAction("Profile", "Account");
            }
            else
            {
                return RedirectToAction("Error403", "Error");

            }
        }

        [Route("me/tickets/{ticketId}")]
        [HttpGet]
        public async Task<IActionResult> GetHistoryTicket(string ticketId)
        {
            if (User.Identity.IsAuthenticated)
            {
                Ticket t = await dbContext.Tickets
                            .Where(t => t.TicketId == ticketId)
                            .Include(f => f.Flight)
                                .ThenInclude(a => a.Airline)
                            .Include(f => f.Flight)
                                .ThenInclude(a => a.DepartureAirport)
                            .Include(f => f.Flight)
                                .ThenInclude(a => a.ArrivalAirport)
                            .Include(f => f.Booking)
                                .ThenInclude(a => a.User)
                            .Include(s => s.Seat)
                            .FirstAsync();
                List<Ticket> tickets = new List<Ticket>();
                tickets.Add(t);
                if(t.Booking.User.UserId.ToString() == User.FindFirst(ClaimTypes.NameIdentifier).Value)
                {
                    return View("~/Views/Booking/BookingTicket.cshtml", tickets);
                }
            }
            return Redirect("/Error/404");
        }

    }
}