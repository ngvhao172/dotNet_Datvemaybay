using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error500()
        {
            return View("500");
        }
        public IActionResult Error403()
        {
            return View("403");
        }
        public IActionResult Error404()
        {
            return View("404");
        }

        /* public IActionResult NotFound()
         {
             return View("404");
         }*/
        [Route("/Error/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("404");
            }
            else if(statusCode == 403)
            {
                return View("403");
            }
            else
            {
                return View("500");
            }
          
        }
    }
}
