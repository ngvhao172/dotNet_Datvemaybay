using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers
{
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
    }
}
