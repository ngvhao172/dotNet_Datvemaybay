using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Data;

namespace Csharp_DatVeMayBay.Controllers
{
    public class AccessController : Controller
    {
        private readonly DBContext dbContext;
        public AccessController(DBContext dbContext)
        {
            this.dbContext = dbContext;
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
            if (Account != null)
            {
                var hasedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(UserAccount.Password,13);
/*                Console.WriteLine(UserAccount.Password);
                Console.WriteLine(hasedPassword);
                Console.WriteLine(Account.Password);*/
                Console.WriteLine();
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
                    else
                    {
                        ViewData["error"] = "No user found with that account.";
                        return View();
                    }
                    
                }
                ViewData["error"] = "Password Incorrect.";
                return View();
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
                Console.WriteLine($"Password: {cPassword}");
                var hashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(Password,13);
                Console.WriteLine($"HashedPassword: {hashPassword}");
                if (cPassword == Password)
                {

                    var newUser = new User { UserEmail = User.UserEmail, LastName = User.LastName, FirstName = User.FirstName, PhoneNumber = User.PhoneNumber, Address = "" };
                    dbContext.Add(newUser);
                    await dbContext.SaveChangesAsync();
                    dbContext.Accounts.Add(new Account { UserEmail = User.UserEmail, Password = hashPassword, Enable = true , UserId=newUser.UserId});
                    await dbContext.SaveChangesAsync();
                    TempData["success"] = "Registration successful.";
                    return Redirect("/login");
                }
                else
                {
                    ViewData["error"] = "Password confirm doesn't match";
                    return View();
                }
            }
            else
            {
                ViewData["error"] = "User exists.";
                return View();
            }
        }
    }
}
