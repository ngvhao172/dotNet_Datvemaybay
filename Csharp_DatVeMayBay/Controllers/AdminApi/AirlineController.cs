using Azure.Core;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.DTO;
using Csharp_DatVeMayBay.Services.EmailService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers.Admin
{
    public class AirlineController : Controller
    {
        private readonly DBContext dbContext;
        public AirlineController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public JsonResult GetAllAirlines()
        {
            List<Airline> airlines = dbContext.Airlines.ToList();
            return Json(new { status = true, data = airlines });
        }
        public JsonResult GetAirlineById(string airline_id)
        {
            var airline = dbContext.Airlines.Where(a => a.AirlineId == Int16.Parse(airline_id)).FirstOrDefault();
            airline.AirlineLogo = "<img src='/" + airline.AirlineLogo + "' class='img-thumbnail mt-3'/> <input type='hidden' name='hidden_airline_logo' value='/" + airline.AirlineLogo + "'/>";
            return Json(new { status = true, data = airline });
        }
        public JsonResult UpdateAirline(string airline_id, string airline_name, string airline_code, IFormFile airline_logo)
        {
            var airline = dbContext.Airlines.Where(a => a.AirlineId == Int16.Parse(airline_id)).FirstOrDefault();
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
                return Json(new {  status = false, message = "Có lỗi khi sửa! " + ex.Message.ToString()  });
            }
            return Json(new { status = true, message = "Sửa thành công" });
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
        public JsonResult DeleteAirline (string airline_id)
        {
            var airline = dbContext.Airlines.Where(a => a.AirlineId == Int16.Parse(airline_id)).FirstOrDefault();
            try
            {
                dbContext.Airlines.Remove(airline);
                dbContext.SaveChanges();
                return Json(new { status = true, message = "Xóa thành công"  });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString() });
            }
           
        }
        public JsonResult AddAirline(string airline_name, string airline_code, IFormFile airline_logo)
        {
            var newAirline = new Airline { AirlineName = airline_name, AirlineCode = airline_code, AirlineLogo = UploadFile(airline_logo) };
            try
            {
                dbContext.Airlines.Add(newAirline);
                dbContext.SaveChanges();
                return Json(new { status = true, message = "Thêm thành công." });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "Có lỗi khi thêm! " + ex.Message.ToString() });
            }
        }
    }

}
