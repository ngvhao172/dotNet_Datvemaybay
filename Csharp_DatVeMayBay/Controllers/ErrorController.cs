using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error505()
        {
            return View("505");
        }
    }
}
