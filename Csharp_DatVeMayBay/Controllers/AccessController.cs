using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.DTO;
using Csharp_DatVeMayBay.Services.EmailService;

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

        [Route("/login")]
        [HttpPost]
        public async Task<IActionResult> Login(Account UserAccount)
        {
            var Account = dbContext.Accounts.Find(UserAccount.UserEmail);
            if (Account != null )
            {
                if(Account.Verified == true)
                {
                    //var hasedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(UserAccount.Password, 13);
                    /*                Console.WriteLine(UserAccount.Password);
                                    Console.WriteLine(hasedPassword);
                                    Console.WriteLine(Account.Password);*/
                    if (BCrypt.Net.BCrypt.EnhancedVerify(UserAccount.Password, Account.Password))
                    {
                        var User = dbContext.Users.FirstOrDefault(u => u.UserEmail == Account.UserEmail);
                        if (User != null)
                        {
                            List<Claim> claims = new List<Claim>();
                            if (User.UserEmail == "admin@gmail.com")
                            {
                                claims = new List<Claim>() {
                            new Claim(ClaimTypes.NameIdentifier, User.UserId.ToString()),
                            new Claim(ClaimTypes.Name,User.FirstName + ' '+  User.LastName),
                            new Claim(ClaimTypes.Email, Account.UserEmail),
                            new Claim(ClaimTypes.Role, "Admin")
                            };
                                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                                    CookieAuthenticationDefaults.AuthenticationScheme);

                                AuthenticationProperties properties = new AuthenticationProperties()
                                {

                                    AllowRefresh = true,
                                    IsPersistent = false
                                };

                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                    new ClaimsPrincipal(claimsIdentity), properties);

                                return RedirectToAction("Airline", "Admin");

                                /*  return Redirect("Admin/Airline");*/
                            }
                            else
                            {
                                claims = new List<Claim>() {
                            new Claim(ClaimTypes.NameIdentifier, User.UserId.ToString()),
                            new Claim(ClaimTypes.Name,User.FirstName + ' '+  User.LastName),
                            new Claim(ClaimTypes.Email, Account.UserEmail),
                            new Claim(ClaimTypes.Role, "User")
                            };
                                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                                    CookieAuthenticationDefaults.AuthenticationScheme);

                                AuthenticationProperties properties = new AuthenticationProperties()
                                {

                                    AllowRefresh = true,
                                    IsPersistent = false
                                };

                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                    new ClaimsPrincipal(claimsIdentity), properties);

                                return RedirectToAction("Index", "Client");
                            };
                        }
                    }
                    else
                    {
                        ViewData["error"] = "Password Incorrect.";
                        return View();
                    } 
                }
                else
                {
                    ViewData["error"] = "Please verifying your account before continuing.";
                    return View();
                }
            }
            ViewData["error"] = "No user found with that email.";
            return View();
        }

        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

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
            Console.WriteLine(User.UserEmail);
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
                    var currentUrl = _config.GetSection("UrlService").Value;
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
                            ExpiredAt = DateTime.Now.AddMinutes(60) // link hết hạn sau 60m
                        };
                        try
                        {
                            dbContext.UserVerifications.Add(newUserVerification);
                            dbContext.SaveChanges();
                            _emailService.SendEmail(emailDTO);
                            TempData["success"] = "Registration successful. An email has been sent to your account!";
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
            else
            {
                var UserVerificationExist = dbContext.UserVerifications.Where(u => u.UserId == UserExist.UserId).Any();
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
                        var currentUrl = _config.GetSection("UrlService").Value;
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
                                ExpiredAt = DateTime.Now.AddMinutes(60) // link hết hạn sau 60m
                            };
                            try
                            {
                                dbContext.UserVerifications.Add(newUserVerification);
                                dbContext.SaveChanges();
                                _emailService.SendEmail(emailDTO);
                                TempData["success"] = "Registration successful. An email has been sent to your account!";
                                return Redirect("/login");
                            }
                            catch (Exception ex)
                            {
                                TempData["error"] = "Registration failed." + ex.Message;
                                return Redirect("/login");
                            }

                        }
                    }
                }
                
                ViewData["error"] = "User exists.";
                return View();
            }
        }
        public IActionResult Verify(int id, string token)
        {
            var User = dbContext.Users.Where(u => u.UserId == id).FirstOrDefault();
            if (User != null)
            {
                var UserVerification = dbContext.UserVerifications.Where(u => u.UserId == id).FirstOrDefault();
                if(UserVerification!= null)
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
                                    dbContext.SaveChanges();
                                    return RedirectToAction("SucessVerify", "Access");
                                }
                                catch(Exception ex)
                                {
                                    TempData["error"] = "Failed to verification." + ex.Message;
                                }  
                            }
                            else
                            {
                                Console.WriteLine(token);
                                Console.WriteLine(BCrypt.Net.BCrypt.EnhancedHashPassword(token,13));
                                Console.WriteLine(BCrypt.Net.BCrypt.EnhancedVerify(token, Token));

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
                    dbContext.SaveChanges();
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
    }

}
