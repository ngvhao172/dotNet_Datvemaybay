using Csharp_DatVeMayBay.BookingNoti_Template_Method;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Csharp_DatVeMayBay.Services.EmailService;
using Csharp_DatVeMayBay.Template_Method;
using Microsoft.EntityFrameworkCore;

namespace Csharp_DatVeMayBay.Observer_Pattern
{
    public class Customer : IObserver
    {

        IConfiguration _config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
        IEmailService _emailService;
        private string _email;
        public Customer(string email)
        {
            _email = email;
            _emailService = new EmailService(_config);
        }

        public void Update(Flight flight)
        {
            //Thuc hien gui mail o mot luong khac
            Task.Run(() =>
            {
                var connectionstring = _config.GetSection("ConnectionStrings:DatvemaybayConnection").Value.ToString();
                var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
                optionsBuilder.UseSqlServer(connectionstring);
                using (var newDbContext = new DBContext(optionsBuilder.Options))
                {
                    var bookings = newDbContext.Bookings.Where(b => b.FlightId == flight.FlightId && b.User.UserEmail == _email)
                        .Include(b => b.User)
                        .Include(b => b.Flight)
                        .ToList();

                    foreach (var booking in bookings)
                    {
                        //Send mail
                        EmailBookingNotification bookingNotification = new DelayBookingNotification(booking, _emailService);
                        bookingNotification.Notify();
                    }
                }
            });
        }
    }
}
