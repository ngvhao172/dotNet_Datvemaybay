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
        public JsonResult GetAllCustomer()
        {
            List<User> customers = dbContext.Users.Where(c => c.UserEmail != "admin@gmail.com").ToList();
            return Json(new { status = true, data = customers });
        }
        public JsonResult GetAllCustomerById(string user_id)
        {
            var user = dbContext.Users.Where(a => a.UserId == Int16.Parse(user_id)).FirstOrDefault();
            return Json(new { status = true, data = user });
        }
        public JsonResult DeleteCustomer(string user_id)
        {
            var user = dbContext.Users.Where(a => a.UserId == Int16.Parse(user_id)).FirstOrDefault();
            try
            {
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
                return Json(new { status = true, message = "Xóa thành công"  });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString() });
            }

        }
    }

}
