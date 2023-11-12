using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers
{
    /*[Authorize(Policy = "AdminOnly")]*/
    [Authorize(Policy = "Admin")]
    public class AdminController : Controller
    {
        private readonly DBContext dbContext;
        public AdminController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Airline()
        {
            return View();
        }
        public IActionResult Flight()
        {
            return View();
        }
        public IActionResult Airport()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult HistoryTicket()
        {
            return View();
        }
        public IActionResult Statistic()
        {
            return View();
        }
    }
}
