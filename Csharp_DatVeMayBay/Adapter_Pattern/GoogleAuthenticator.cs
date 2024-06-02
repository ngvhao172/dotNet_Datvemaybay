using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Csharp_DatVeMayBay.Adapter_Pattern
{
    public class GoogleAuthenticator : IThirdPartyAuthenticator
    {
        private readonly DBContext _dbContext;

        public GoogleAuthenticator(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AuthenticateResultDTO> Authenticate(HttpContext _context)
        {
            var authenticateResult = await _context.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
            if (!authenticateResult.Succeeded)
            {
                return null;
            }

            // Lấy thông tin từ authenticateResult
            var userId = authenticateResult.Principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var email = authenticateResult.Principal.FindFirst(ClaimTypes.Email)?.Value;
            var fullName = authenticateResult.Principal.FindFirst(ClaimTypes.Name)?.Value;
            var surname = authenticateResult.Principal.FindFirst(ClaimTypes.Surname)?.Value; //Tên
            var familyname = authenticateResult.Principal.FindFirst(ClaimTypes.GivenName)?.Value; //Họ
            var phonenumber = authenticateResult.Principal.FindFirst(ClaimTypes.MobilePhone)?.Value;
            var dob = authenticateResult.Principal.FindFirst(ClaimTypes.DateOfBirth)?.Value;
            var address = authenticateResult.Principal.FindFirst(ClaimTypes.StreetAddress)?.Value;


            var UserExisted = await _dbContext.Accounts.Where(a => a.UserEmail == email).FirstOrDefaultAsync();
            var claims = new List<Claim>();
            int UserIDLogger;

            var UserResult = new User();

            if (UserExisted == null)
            {
                //Tạo user
                UserResult = new User
                {
                    FirstName = familyname,
                    LastName = surname,
                    PhoneNumber = (!string.IsNullOrEmpty(phonenumber) ? phonenumber : ""),
                    UserEmail = email,
                    Address = (!string.IsNullOrEmpty(address) ? address : ""),
                    Dob = (!string.IsNullOrEmpty(dob) ? DateTime.Parse(dob) : DateTime.Now),
                };
                await _dbContext.Users.AddAsync(UserResult);
                await _dbContext.SaveChangesAsync();


                UserIDLogger = UserResult.UserId;

                var password = email.Split("@");
                var Account = new Account
                {
                    UserEmail = email,
                    UserId = UserResult.UserId,
                    Password = BCrypt.Net.BCrypt.EnhancedHashPassword(password[0], 13), //password mặc định là tên email
                    Enable = true,
                    Verified = true
                };
                await _dbContext.Accounts.AddAsync(Account);
                await _dbContext.SaveChangesAsync();

                // Thêm claim roles cho người dùng
                claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, UserResult.UserId.ToString()),
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Name, fullName),
                    new Claim(ClaimTypes.Role, "User")
                };
            }
            else
            {
                claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, UserExisted.UserId.ToString()),
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Name, fullName),
                    new Claim(ClaimTypes.Role, "User")
                };
                UserResult = await _dbContext.Users.Where(u => u.UserId == UserExisted.UserId).FirstOrDefaultAsync();
            }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties { IsPersistent = true };
            await _context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

            var returnUrl = authenticateResult.Properties.Items["returnUrl"];
            return new AuthenticateResultDTO
            {
                User = UserResult,
                Message = "Sucess",
                Role = Models.Enums.RoleSystem.User,
                ReturnUrl = returnUrl,
            };
        }

    }
}
