using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    [ApiController]
    [Route("api/Airports")]
    public class AirportController : Controller
    {
        private readonly DBContext dbContext;
        public AirportController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        [Route("GetAllAirports")]
        public JsonResult GetAllAirports()
        {
            List<Airport> airports = dbContext.Airports.ToList();
            return Json(new { data = airports });
        }
        [HttpPost]
        [Route("GetAirportById")]
        public JsonResult GetAirportById([FromForm] string airport_id)
        {
            var airport = dbContext.Airports.Where(a => a.AirportId == Int16.Parse(airport_id)).FirstOrDefault();
            return Json(new { data = airport });
        }
        [HttpPost]
        [Route("UpdateAirport")]
        public JsonResult UpdateAirport([FromForm] string airport_id, [FromForm] string airport_name, [FromForm] string airport_location, [FromForm] string airport_code)
        {
            var airport = dbContext.Airports.Where(a => a.AirportId == Int16.Parse(airport_id)).FirstOrDefault();
            airport.AirportName = airport_name;
            airport.AirportLocation = airport_location;
            airport.AirportCode = airport_code;

            try
            {
                dbContext.Airports.Update(airport);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Sửa thành công." } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi sửa! " + ex.Message.ToString() } });
            }
        }
        [HttpPost]
        [Route("DeleteAirport")]
        public JsonResult DeleteAirport([FromForm] string airport_id)
        {
            var airport = dbContext.Airports.Where(a => a.AirportId == Int16.Parse(airport_id)).FirstOrDefault();
            try
            {
                dbContext.Airports.Remove(airport);
                dbContext.SaveChanges();
                return Json(new { data = new { status = true, message = "Xóa thành công." } });
            }
            catch (Exception ex)
            {
                return Json(new { data = new { status = false, message = "Có lỗi khi xóa! " + ex.Message.ToString() } });
            }

        }
        [HttpPost]
        [Route("AddAirport")]
        public JsonResult AddAirport([FromForm] string airport_name, [FromForm] string airport_location, [FromForm] string airport_code)
        {
            var newAirport = new Airport { AirportName = airport_name, AirportLocation = airport_location, AirportCode = airport_code };
            try
            {
                dbContext.Airports.Add(newAirport);
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
