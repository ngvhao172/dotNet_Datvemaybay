using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers.Admin
{
    public class AirlineController : Controller
    {
        [Route("Admin/Airline")]
        public IActionResult Index()
        {
            return View("../Admin/Airline");
        }
    }
}
