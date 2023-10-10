using Azure.Core;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers.Admin
{
    [ApiController]
    [Route("api/Airlines")]
    public class AirlineController : Controller
    {
        private readonly DBContext dbContext;
        public AirlineController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        [Route("GetAllAirlines")]
        public JsonResult GetAllAirlines()
        {
            List<Airline> airlines = dbContext.Airlines.ToList();
            return Json(new { data = airlines });
        }
        [HttpPost]
        [Route("GetAirlineById")]
        public JsonResult GetAirlineById([FromForm] string airline_id)
        {
            var airline = dbContext.Airlines.Where(a => a.AirlineId == Int64.Parse(airline_id)).FirstOrDefault();
            airline.AirlineLogo = "<img src='/" + airline.AirlineLogo + "' class='img-thumbnail mt-3'/> <input type='hidden' name='hidden_airline_logo' value='/" + airline.AirlineLogo + "'/>";
            return Json(new { data = airline });
        }
        [HttpPost]
        [Route("UpdateAirline")]
        public JsonResult UpdateAirline([FromForm] string airline_id, [FromForm] string airline_name, [FromForm] string airline_code, [FromForm] IFormFile airline_logo)
        {
            var airline = dbContext.Airlines.Where(a => a.AirlineId == Int64.Parse(airline_id)).FirstOrDefault();
            airline.AirlineName = airline_name;
            airline.AirlineCode = airline_code;
            airline.AirlineLogo = UploadFile(airline_logo);
           
            try
            {
                dbContext.Airlines.Update(airline);
                dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi sửa! " + ex.Message.ToString() } });
            }
            return Json(new { data = new { status = true, message = "Sửa thành công" } });
        }
        public string UploadFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null && uploadedFile.Length > 0)
            {
                string ImageName = uploadedFile.FileName;

                //Get url To Save
                string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/airlines", ImageName);
                using (var stream = new FileStream(SavePath, FileMode.Create))
                {
                    uploadedFile.CopyTo(stream);
                }
                return "./img/airlines/" + ImageName;
            }
            return "";
        }

        [HttpPost]
        [Route("DeleteAirline")]
        public JsonResult DeleteAirline ([FromForm] string airline_id)
        {
            var airline = dbContext.Airlines.Where(a => a.AirlineId == Int64.Parse(airline_id)).FirstOrDefault();
            try
            {
                dbContext.Airlines.Remove(airline);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Xóa thành công" } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString() } });
            }
           
        }
        [HttpPost]
        [Route("AddAirline")]
        public JsonResult AddAirline([FromForm] string airline_name, [FromForm] string airline_code, [FromForm] IFormFile airline_logo)
        {
            var newAirline = new Airline { AirlineName = airline_name, AirlineCode = airline_code, AirlineLogo = UploadFile(airline_logo) };
            try
            {
                dbContext.Airlines.Add(newAirline);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Thêm thành công." } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi thêm! " + ex.Message.ToString() } });
            }
        }
    }

}
