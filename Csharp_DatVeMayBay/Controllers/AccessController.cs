﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.DTO;
using Csharp_DatVeMayBay.Services.EmailService;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.EntityFrameworkCore;
using Csharp_DatVeMayBay.Models;
using Csharp_DatVeMayBay.Adapter_Pattern;

namespace Csharp_DatVeMayBay.Controllers
{
    public class AccessController : Controller
    {
        private readonly DBContext dbContext;

        private readonly IEmailService _emailService;

        private readonly IConfiguration _config;
        public AccessController(DBContext dbContext, IEmailService emailService, IConfiguration config)
        {
            this.dbContext = dbContext;
            _emailService = emailService;
            _config = config;
        }

        [Route("/login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/login/{*returnUrl}")]
        [HttpPost]
        public async Task<IActionResult> LoginPOST(string returnUrl)
        {
            Console.WriteLine(returnUrl);
            if (String.IsNullOrEmpty(returnUrl))
            {
                returnUrl = "/";
            }
            var email = Request.Form["email"];
            var password = Request.Form["password"];

            Account UserAccount = new Account
            {
                UserEmail = email,
                Password = password
            };
            IAuthenticator accountAuthenticator = new AccountAuthenticator(HttpContext, dbContext);
            AuthenticateResultDTO resultDTO =  await accountAuthenticator.Authenticate(UserAccount);
            if(resultDTO.User == null)
            {
                TempData["error"] = resultDTO.Message;
                return Redirect("/login");
            }
            else if(resultDTO.Role == Models.Enums.RoleSystem.Admin)
            {
                Logger.GetInstance().Log("Admin login successfully");
                return RedirectToAction("Flight", "Admin");
            }
            else
            {
                //New code_logger
                Logger.GetInstance().Log($"User login by account successfully: User({resultDTO.User.UserId}, {resultDTO.User.FirstName + ' ' + resultDTO.User.LastName})");

                if(returnUrl == "/" || string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "Client");
                }
                return Redirect("/" + returnUrl);
            }

        }

        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            Logger.GetInstance().CloseLog();

            return RedirectToAction("Index", "Client");

        }

        [Route("/register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }

        [Route("/register")]
        [HttpPost]
        public async Task<IActionResult> Register(User User)
        {
            var UserExist = dbContext.Accounts.Find(User.UserEmail);
            //Chưa tồn tại User
            if (UserExist == null)
            {
                var cPassword = Request.Form["cpassword"];
                var Password = Request.Form["password"];
                var hashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(Password,13);
                if (cPassword == Password)
                {
                    var newUser = new User { UserEmail = User.UserEmail, LastName = User.LastName, FirstName = User.FirstName, PhoneNumber = User.PhoneNumber, Address = "" };
                    dbContext.Add(newUser);
                    await dbContext.SaveChangesAsync();
                    dbContext.Accounts.Add(new Account { UserEmail = User.UserEmail, Password = hashPassword, Enable = true , UserId=newUser.UserId});
                    await dbContext.SaveChangesAsync();
                    /*    Sending mail*/
                    var currentUrl = _config.GetSection("UrlVerificationService").Value;
                    var uniqueString = Guid.NewGuid();
                    var emailDTO = new EmailDTO()
                    {
                        To = User.UserEmail,
                        Subject = "[StarLine] Verify Your Email",
                        Body = "<p> Verify your email address to complete the signup and login into your account.</p> " +
                                "<p> Press <a href='" + currentUrl.ToString() + "/"+ newUser.UserId.ToString() + "/" + uniqueString.ToString() + "'> here </a> to proceed. </p>"
                    };
                    var hashUniqueString = BCrypt.Net.BCrypt.EnhancedHashPassword(uniqueString.ToString(), 13);
                    if (hashUniqueString!=null)
                    {
                        var newUserVerification = new UserVerification()
                        {
                            UserId = newUser.UserId,
                            UniqueString = hashUniqueString.ToString(),
                            CreateAt = DateTime.Now,
                            ExpiredAt = DateTime.Now.AddMinutes(60), // link hết hạn sau 60m
                            MailType = Models.Enums.MailType.Verification
                        };
                        try
                        {
                            dbContext.UserVerifications.Add(newUserVerification);
                            dbContext.SaveChanges();
                            _emailService.SendEmail(emailDTO);
                            Console.WriteLine("Verification mail has been sent to " + User.UserEmail);
                            TempData["success"] = "Registration successful. An email has been sent to your account!";

                            //New code_logger
                            Logger.GetInstance().Log($"New User registered : User({newUser.UserId}, {User.FirstName + ' ' + User.LastName})");

                            Logger.GetInstance().CloseLog();


                            return Redirect("/login");
                        }
                        catch(Exception ex)
                        {
                            TempData["error"] = "Registration failed." + ex.Message;
                            return Redirect("/login");
                        }
                    }
                    else
                    {
                        TempData["error"] = "Registration failed. There are an error when hashing Unique String!";
                        return Redirect("/login");
                    }
                    /*    Sending mail*/
                }
                else
                {
                    ViewData["error"] = "Password confirm doesn't match";
                    return View();
                }
            }
            //User chưa verify email
            else
            {
                var UserVerificationExist = dbContext.UserVerifications.Where(u => u.UserId == UserExist.UserId && u.MailType == Models.Enums.MailType.Verification).Any();
                if (UserVerificationExist)
                {
                    TempData["error"] = "You had sent a request before. Please check your email address.";
                    return Redirect("/login");
                }
                else
                {
                    if (UserExist.Verified == false)
                    {
                        var getUserExist = dbContext.Users.Where(u => u.UserEmail == UserExist.UserEmail).FirstOrDefault();
                        var currentUrl = _config.GetSection("UrlVerificationService").Value;
                        var uniqueString = Guid.NewGuid();
                        var emailDTO = new EmailDTO()
                        {
                            To = User.UserEmail,
                            Subject = "[StarLine] Verify Your Email",
                            Body = "<p> Verify your email address to complete the signup and login into your account.</p> " +
                            "<p> Press <a href=" + currentUrl.ToString() + "/" + getUserExist.UserId.ToString() + "/" + uniqueString.ToString() + "> here </a> to proceed. </p>"
                        };
                        var hashUniqueString = BCrypt.Net.BCrypt.EnhancedHashPassword(uniqueString.ToString(), 13);
                        if (hashUniqueString != null)
                        {
                            var newUserVerification = new UserVerification()
                            {
                                UserId = getUserExist.UserId,
                                UniqueString = hashUniqueString.ToString(),
                                CreateAt = DateTime.Now,
                                ExpiredAt = DateTime.Now.AddMinutes(60), // link hết hạn sau 60m
                                MailType = Models.Enums.MailType.Verification
                            };
                            try
                            {
                                dbContext.UserVerifications.Add(newUserVerification);
                                dbContext.SaveChanges();
                                _emailService.SendEmail(emailDTO);
                                Console.WriteLine("Verification mail has been sent to " + User.UserEmail);
                                TempData["success"] = "Registration successful. An email has been sent to your account!";

                                //New code_logger
                                Logger.GetInstance().Log($"User register successfully: User({User.UserId}, {User.FirstName + ' ' + User.LastName})");

                                return Redirect("/login");
                            }
                            catch (Exception ex)
                            {
                                TempData["error"] = "Error. " + ex.Message;
                                return Redirect("/login");
                            }

                        }
                        else
                        {
                            TempData["error"] = "Registration failed. There are an error when hashing Unique String!";
                            return Redirect("/login");
                        }
                    }
                    else
                    {
                        ViewData["error"] = "User exists.";
                    }
                }
               
                return View();
            }
        }
        //Verifying account route
        [Route("Account/Verify/{id}/{token}")]
        public async Task<IActionResult> Verify(int id, string token)
        {
            var User = dbContext.Users.Where(u => u.UserId == id).FirstOrDefault();
            if (User != null)
            {
                var UserVerification = await dbContext.UserVerifications.Where(u => u.UserId == id && u.MailType == Models.Enums.MailType.Verification).FirstOrDefaultAsync();
                if (UserVerification!= null)
                {
                    if(UserVerification.ExpiredAt > DateTime.Now)
                    {
                        var Token = UserVerification.UniqueString;
                        if (Token != null)
                        {
                            //Đúng token
                            if(BCrypt.Net.BCrypt.EnhancedVerify(token, Token))
                            {
                                //Chuyển verified account thành true
                                try
                                {
                                    var Account = dbContext.Accounts.Where(a => a.UserId == id).FirstOrDefault();
                                    Account.Verified = true;
                                    //Xóa UserVerification
                                    dbContext.UserVerifications.Remove(UserVerification);
                                    await dbContext.SaveChangesAsync();

                                    //New code_logger
                                    Logger.GetInstance().Log($"User verify successfully: User({User.UserId}, {User.FirstName + ' ' + User.LastName})");

                                    return RedirectToAction("SucessVerify", "Access");
                                }
                                catch(Exception ex)
                                {
                                    TempData["error"] = "Failed to verification." + ex.Message;
                                }  
                            }
                            else
                            {
                                TempData["error"] = "Failed to verification. Token is modified!";
                            }
                        }
                        else
                        {
                            TempData["error"] = "Failed to verification. Token not found!";
                        }
                    }
                    else
                    {
                        TempData["error"] = "Failed to verification. Token expired! Please registering again.";
                    }
                    //xóa UserVerification
                    dbContext.UserVerifications.Remove(UserVerification);
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    TempData["error"] = "Failed to verification. UserVerification not found!";
                }
            }
            else
            {
                TempData["error"] = "Failed to verification. User not found!";
            }
            return RedirectToAction("FailureVerify", "Access");
        }
        public IActionResult SucessVerify()
        {
            return View("VerifiedSucess");
        }

        public IActionResult FailureVerify()
        {
            return View("VerifiedFail");
        }
        [Route("/forgotpassword"), HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [Route("/forgotpassword"), HttpPost]
        public IActionResult ForgotPassword(Account account)
        {
            var UserAccount = dbContext.Accounts.Where(a => a.UserEmail == account.UserEmail).FirstOrDefault();
            if (UserAccount != null)
            {
                var UserVerificationExist = dbContext.UserVerifications.Where(u => u.UserId == UserAccount.UserId && u.MailType == Models.Enums.MailType.ResetPassword).Any();
                if (UserVerificationExist)
                {
                    ViewData["status"] = "danger";
                    ViewData["message"] = "You had sent a reset password request before. Please check your email address.";
                }
                else
                {
                    /* Sending mail reset*/
                    var resetUrl = _config.GetSection("UrlResetPasswordService").Value;
                    var uniqueString = Guid.NewGuid();
                    var emailDTO = new EmailDTO()
                    {
                        To = UserAccount.UserEmail,
                        Subject = "[StarLine] Reset Your Password",
                        Body = "<p> We've processed your password change request. If it is you who sent this request, click on the link below to change your password.</p> " +
                                "<p> Press <a href='" + resetUrl.ToString() + "/" + UserAccount.UserId.ToString() + "/" + uniqueString.ToString() + "'> here </a> to proceed. </p>"
                    };
                    var hashUniqueString = BCrypt.Net.BCrypt.EnhancedHashPassword(uniqueString.ToString(), 13);
                    if (hashUniqueString != null)
                    {
                        var newUserVerification = new UserVerification()
                        {
                            UserId = UserAccount.UserId,
                            UniqueString = hashUniqueString.ToString(),
                            CreateAt = DateTime.Now,
                            ExpiredAt = DateTime.Now.AddMinutes(60),// link hết hạn sau 60m
                            MailType = Models.Enums.MailType.ResetPassword
                        };
                        try
                        {
                            dbContext.UserVerifications.Add(newUserVerification);
                            dbContext.SaveChanges();
                            _emailService.SendEmail(emailDTO);
                            Console.WriteLine("Reset password mail has been sent to " + UserAccount.UserEmail);
                            ViewData["status"] = "success";
                            ViewData["message"] = "Password request mail has been sent to " + UserAccount.UserEmail;
                        }
                        catch (Exception ex)
                        {
                            ViewData["status"] = "danger";
                            ViewData["message"] = "Sending mail reset password failed!. " + ex.Message;
                        }
                    }
                    else
                    {
                        ViewData["status"] = "danger";
                        ViewData["message"] = "Sending mail reset password failed. There are an error when hashing Unique String!";
                    }
                }
            }
            else
            {
                ViewData["status"] = "danger";
                ViewData["message"] = "Account not found.";
            }
            return View();
        }
        //Quên mật khẩu
        [HttpGet]
        [Route("Account/ChangePassword/{id}/{token}")]
        public IActionResult ChangePassword()
        {    
            return View();
        }
        [HttpPost]
        [Route("Account/ChangePassword/{id}/{token}")]
        public IActionResult ChangePassword(int id, string token)
        {
            var newPassword = Request.Form["newPassword"];
            var cfPassword = Request.Form["cPassword"]; 
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                ModelState.AddModelError("Password", "Password is required.");
            }

            if (string.IsNullOrWhiteSpace(cfPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "Confirm Password is required.");
            }
            if (ModelState.IsValid)
            {

                if (newPassword == cfPassword)
                {
                    var User = dbContext.Users.Where(u => u.UserId == id).FirstOrDefault();
                    if (User != null)
                    {
                        var UserVerification = dbContext.UserVerifications.Where(u => u.UserId == id && u.MailType == Models.Enums.MailType.ResetPassword).FirstOrDefault();
                        if (UserVerification != null)
                        {
                            if (UserVerification.ExpiredAt > DateTime.Now)
                            {
                                var Token = UserVerification.UniqueString;
                                if (Token != null)
                                {
                                    //Đúng token => thực hiện đổi mật khẩu
                                    if (BCrypt.Net.BCrypt.EnhancedVerify(token, Token))
                                    {
                                        try
                                        {
                                            var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, 13);
                                            var Account = dbContext.Accounts.Where(a => a.UserId == id).FirstOrDefault();
                                            Account.Password = hashedPassword;
                                            dbContext.Accounts.Update(Account);
                                            //Xóa UserVerification
                                            dbContext.UserVerifications.Remove(UserVerification);
                                            dbContext.SaveChanges();
                                            ViewData["status"] = "success";
                                            ViewData["message"] = "Reset your password succesfully. Please login here <a href=https://localhost:7196/login> here </a>";   
                                        }
                                        catch (Exception ex)
                                        {
                                            ViewData["status"] = "danger";
                                            ViewData["message"] = "Failed to reset password." + ex.Message;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(token);
                                        Console.WriteLine(BCrypt.Net.BCrypt.EnhancedHashPassword(token, 13));
                                        Console.WriteLine(BCrypt.Net.BCrypt.EnhancedVerify(token, Token));

                                        ViewData["status"] = "danger";
                                        ViewData["message"] = "Failed to reset password. Token is modified!";
                                    }
                                }
                                else
                                {
                                    ViewData["status"] = "danger";
                                    ViewData["message"] = "Failed to reset password. Token not found!";
                                }
                            }
                            else
                            {
                                ViewData["status"] = "danger";
                                ViewData["message"] = "Failed to reset password. Token expired! Please sending request again.";
                            }
                        }
                        else
                        {
                            ViewData["status"] = "danger";
                            ViewData["message"] = "Failed to reset password. UserVerification not found!";
                        }
                    }
                    else
                    {
                        ViewData["status"] = "danger";
                        ViewData["message"] = "Failed to reset password. User not found!";
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
                ViewData["message"] = "Input invalid. Please filling all input!";
            }
            return View();
        }
        [Route("ggLogin/{*returnUrl}")]
        [HttpGet]
        public IActionResult GoogleLogin(string returnUrl, string provider = "Google")
        {
            Console.WriteLine(returnUrl);
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleLoginCallback"),
                Items =
                {
                    { "returnUrl", returnUrl },
                },
            };
            return Challenge(properties, provider);
        }
        [HttpGet]
        public async Task<IActionResult> GoogleLoginCallback()
        {
            GoogleAuthenticator googleAuthenticator = new GoogleAuthenticator(dbContext);

            GoogleAuthAdapter googleAuthAdapter = new GoogleAuthAdapter(googleAuthenticator, HttpContext);
            AuthenticateResultDTO resultDTO = await googleAuthAdapter.Authenticate(null);
            if (resultDTO.User == null)
            {
                return Redirect("/Error/404");
            }
            Logger.GetInstance().Log($"User login by Google successfully: User({resultDTO.User.UserId}, {resultDTO.User.FirstName + ' ' + resultDTO.User.LastName})");
            return Redirect("/" + resultDTO.ReturnUrl);
            /*return RedirectToAction("Index", "Client");*/
        }

    }

}
