using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    // VIẾT API RỒI  GỌI BÊN JS, THAM KHẢO NHỮNG CÁI HÀO LÀM TRƯỚC ĐÓ
    // QUỲNH : CODE CHỖ NÀY
    [ApiController]
    [Route("api/HistoryTickets")]
    public class HistoryTicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
