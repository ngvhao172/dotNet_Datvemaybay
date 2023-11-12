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
        class StatisticModel {
            public int totalTickets { get; set; }
            public decimal totalRevenue { get; set; }

        }
        [HttpPost]
        [Route("GetStatistic")]
        public JsonResult GetStatistic(DateTime fromDate, DateTime toDate)
        {
            List<StatisticModel> dataArray = new List<StatisticModel>();
            //Co chon ngay
            if (fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
            {
                var rs_totalTickets = dbContext.Tickets
                .Where(t => t.Booking.BookingDatime >= fromDate && t.Booking.BookingDatime <= toDate)
                .Count();

                var rs_totalRevenue = dbContext.Tickets
                    .Where(t => t.Booking.BookingDatime >= fromDate && t.Booking.BookingDatime <= toDate && t.Status == Models.Enums.TicketStatus.Paid)
                    .Sum(t => t.TicketPrice);

                StatisticModel statisticData = new StatisticModel()
                {
                    totalTickets = rs_totalTickets,
                    totalRevenue = rs_totalRevenue
                };
                dataArray.Add(statisticData);
            }
            //Mac dinh khong chon ngay
            else
            {
                var rs_totalTickets = dbContext.Tickets
                .Count();

                var rs_totalRevenue = dbContext.Tickets.Where( t => t.Status == Models.Enums.TicketStatus.Paid)
                    .Sum(t => t.TicketPrice);

                StatisticModel statisticData = new StatisticModel()
                {
                    totalTickets = rs_totalTickets,
                    totalRevenue = rs_totalRevenue
                };
                dataArray.Add(statisticData);
            }
            return Json(new { data = dataArray });
        }
    }
}
