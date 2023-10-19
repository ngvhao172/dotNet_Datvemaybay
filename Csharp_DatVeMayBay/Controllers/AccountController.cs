using Csharp_DatVeMayBay.Services.EmailService;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Csharp_DatVeMayBay.Data;

namespace Csharp_DatVeMayBay.Controllers
{
    public class AccountController : Controller
    {
        private readonly DBContext dbContext;
        public AccountController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Route("/me")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Error403", "Error");
            }
            
        }
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
    }
}
