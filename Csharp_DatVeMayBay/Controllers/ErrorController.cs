using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error505()
        {
            return View("505");
        }
        public IActionResult Error403()
        {
            return View("403");
        }
        public IActionResult Error404()
        {
            return View("404");
        }
    }
}
