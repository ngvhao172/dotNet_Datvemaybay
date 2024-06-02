using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Csharp_DatVeMayBay.Data;
using Microsoft.EntityFrameworkCore;
using Csharp_DatVeMayBay.Models.DTO;

namespace Csharp_DatVeMayBay.Adapter_Pattern
{
    public class AccountAuthenticator : IAuthenticator
    {
        private HttpContext _context;
        private readonly DBContext _dbContext;
        public AccountAuthenticator(HttpContext context, DBContext dbContext)
        {
            _context = context;
            _dbContext = dbContext;
        }
        public async Task<AuthenticateResultDTO> Authenticate(Account UserAccount)
        {
            var Account = _dbContext.Accounts.Find(UserAccount.UserEmail);
            if (Account != null)
            {
                if (Account.Verified == true)
                {
                    if (BCrypt.Net.BCrypt.EnhancedVerify(UserAccount.Password, Account.Password))
                    {
                        var User = _dbContext.Users.FirstOrDefault(u => u.UserEmail == Account.UserEmail);
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

                                await _context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                    new ClaimsPrincipal(claimsIdentity), properties);


                                return new AuthenticateResultDTO
                                {
                                    User = User,
                                    Message = "Success",
                                    Role = Models.Enums.RoleSystem.Admin
                                };
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

                                await _context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                    new ClaimsPrincipal(claimsIdentity), properties);

                                return new AuthenticateResultDTO
                                {
                                    User = User,
                                    Message = "Success",
                                    Role = Models.Enums.RoleSystem.User,
                                };
                            };
                        }
                    }
                    else
                    {
                        return new AuthenticateResultDTO
                        {
                            User = null,
                            Message = "Password Incorrect.",
                            Role = Models.Enums.RoleSystem.NotAuthenticated
                        };
                    }
                }
                else
                {
                    return new AuthenticateResultDTO
                    {
                        User = null,
                        Message = "Please verifying your account before continuing.",
                        Role = Models.Enums.RoleSystem.NotAuthenticated
                    };
                }
            }
            return new AuthenticateResultDTO
            {
                User = null,
                Message = "No user found with that email.",
                Role = Models.Enums.RoleSystem.NotAuthenticated
            };
        }
    }
}
