using Microsoft.AspNetCore.Mvc;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Data;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    [ApiController]
    [Route("api/Customers")]
    public class CustomerController : Controller
    {
        private readonly DBContext dbContext;

        public CustomerController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetAllCustomer")]
        public JsonResult GetAllCustomer()
        {
            List<User> customers = dbContext.Users.ToList();
            return Json(new { data = customers });
        }
        [HttpPost]
        [Route("GetCustomerById")]
        public JsonResult GetAllCustomerById([FromForm] string user_id)
        {
            var user = dbContext.Users.Where(a => a.UserId == Int16.Parse(user_id)).FirstOrDefault();
            Console.WriteLine(user.UserId);
            Console.WriteLine(user);
            return Json(new { data = user });
        }
        [HttpPost]
        [Route("DeleteCustomer")]
        public JsonResult DeleteCustomer([FromForm] string user_id)
        {
            var user = dbContext.Users.Where(a => a.UserId == Int16.Parse(user_id)).FirstOrDefault();
            Console.WriteLine(user.UserId);

            Console.WriteLine(user);
            try
            {
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Xóa thành công" } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString() } });
            }

        }
    }

}
