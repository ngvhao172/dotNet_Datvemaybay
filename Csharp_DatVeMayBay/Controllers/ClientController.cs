using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Csharp_DatVeMayBay.Controllers
{
    public class ClientController : Controller
    {
        private readonly DBContext dbContext;
        public ClientController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var airports = await dbContext.Airports.ToListAsync();
            return View(airports);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}