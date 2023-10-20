using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Csharp_DatVeMayBay.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    [ApiController]
    [Route("api/Statistic")]
    public class StatisticController : Controller
    {
        private readonly DBContext dbContext;

        public StatisticController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetStatistic")]
        public JsonResult GetStatistic(DateTime fromDate, DateTime toDate)
        {
            var rs_totalTickets = dbContext.Tickets
                .Where(t => t.Booking.BookingDatime >= fromDate && t.Booking.BookingDatime <= toDate)
                .Count();

            var rs_totalRevenue = dbContext.Tickets
                .Where(t => t.Booking.BookingDatime >= fromDate && t.Booking.BookingDatime <= toDate)
                .Sum(t => t.TicketPrice);

            var statisticData = new
            {
                totalTickets = rs_totalTickets,
                totalRevenue = rs_totalRevenue
            };

            return Json(new { data = statisticData });
        }
    }
}
