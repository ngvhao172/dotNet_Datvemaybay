using Csharp_DatVeMayBay.Controllers.Admin;
using Csharp_DatVeMayBay.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;

namespace Csharp_DatVeMayBay.Controllers.AdminApi
{
    [ApiController]
    [Route("api/Management")]
    public class AdminManagementFacade : Controller
    {
        private readonly DBContext dbContext;
        private readonly AirlineController airlineController;
        private readonly AirportController airportController;
        private readonly CustomerController customerController;
        private readonly FlightController flightController;
        private readonly HistoryTicketController historyTicketController;
        private readonly StatisticController statisticController;

        public AdminManagementFacade(DBContext dbContext)
        {
            this.dbContext = dbContext;
            this.airlineController = new AirlineController(dbContext);
            this.airportController = new AirportController(dbContext);
            this.customerController = new CustomerController(dbContext);
            this.flightController = new FlightController(dbContext);
            this.historyTicketController = new HistoryTicketController(dbContext);
            this.statisticController = new StatisticController(dbContext);
        }

        [HttpPost]
        [Route("ManageData")]
        public JsonResult ManageData()
        {
            var formData = Request.Form;
            string dataType = formData["dataType"].ToString();
            string action = (string)formData["action"];
            switch (dataType)
            {
                case "Airline":
                    return ManageAirlines(action, formData);
                case "Airport":
                    return ManageAirports(action, formData);
                case "Customer":
                    return ManageCustomers(action, formData);
                case "Flight":
                    return ManageFlights(action, formData);
                case "HistoryTicket":
                    return ManageHistoryTickets(action, formData);
                case "Statistic":
                    return ManageStatistics(action, formData);
                default:
                    return Json(new { status = false, message = "Invalid data type" });
            }
        }

        private JsonResult ManageAirlines(string action, IFormCollection formData)
        {
            IFormFile AirlineLogo = null;
            if(formData.Files.Count > 0)
            {
                AirlineLogo = formData.Files[0];
            }
            switch (action)
            {
                case "GetAll":
                    return airlineController.GetAllAirlines();
                case "GetById":
                    return airlineController.GetAirlineById(formData["airline_id"]);
                case "Update":
                    return airlineController.UpdateAirline(formData["airline_id"], formData["airline_name"], formData["airline_code"], AirlineLogo);
                case "Delete":
                    return airlineController.DeleteAirline(formData["airline_id"]);
                case "Add":
                    return airlineController.AddAirline(formData["airline_name"], formData["airline_code"], AirlineLogo);
                default:
                    return Json(new { status = false, message = "Invalid action" });
            }
        }

        private JsonResult ManageAirports(string action, IFormCollection formData)
        {
            switch (action)
            {
                case "GetAll":
                    return airportController.GetAllAirports();
                case "GetById":
                    return airportController.GetAirportById(formData["airport_id"]);
                case "Update":
                    return airportController.UpdateAirport(formData["airport_id"], formData["airport_name"], formData["airport_location"], formData["airport_code"]);
                case "Delete":
                    return airportController.DeleteAirport(formData["airport_id"]);
                case "Add":
                    return airportController.AddAirport(formData["airport_name"], formData["airport_location"], formData["airport_code"]);
                default:
                    return Json(new { status = false, message = "Invalid action" });
            }
        }
        private JsonResult ManageCustomers(string action, IFormCollection formData)
        {
           

            switch (action)
            {
                case "GetAll":
                    return customerController.GetAllCustomer();
                case "GetById":
                    return customerController.GetAllCustomerById(formData["user_id"]);
                case "Delete":
                    return customerController.DeleteCustomer(formData["user_id"]);
                default:
                    return Json(new { status = false, message = "Invalid action" });
            }
        }
        private JsonResult ManageFlights(string action, IFormCollection formData)
        {
            switch (action)
            {
                case "GetAll":
                    DateTime fromDate = DateTime.MinValue;
                    DateTime toDate = DateTime.MinValue;

                    if (!StringValues.IsNullOrEmpty(formData["fromDate"]) && DateTime.TryParse(formData["fromDate"], out DateTime fromParsedDate))
                    {
                        fromDate = fromParsedDate;
                    }

                    if (!StringValues.IsNullOrEmpty(formData["toDate"]) && DateTime.TryParse(formData["toDate"], out DateTime toParsedDate))
                    {
                        toDate = toParsedDate;
                    }
                    return flightController.GetAllFlights(fromDate, toDate);
                case "GetToday":
                    return flightController.GetAllFlightsToday();
                case "GetById":
                    return flightController.GetFlightById(formData["flight_id"]);
                case "Delete":
                    return flightController.DeleteFlight(formData["flight_id"]);
                case "Update":
                    return flightController.UpdateFlight(formData["flight_id"], formData["airline_id"], formData["departure_airport_id"], formData["arrival_airport_id"], formData["departure_datetime"], formData["arrival_datetime"], formData["economy_price"], formData["business_price"]);
                case "Add":
                    return flightController.AddFlight(formData["airline_id"], formData["departure_airport_id"], formData["arrival_airport_id"], formData["departure_datetime"], formData["arrival_datetime"], formData["economy_price"], formData["business_price"]);
                default:
                    return Json(new { status = false, message = "Invalid action" });
            }
        }
        private JsonResult ManageHistoryTickets(string action, IFormCollection formData)
        {
           
            switch (action)
            {
                case "GetAll":
                    DateTime fromDate = DateTime.MinValue;
                    DateTime toDate = DateTime.MinValue;

                    if (!StringValues.IsNullOrEmpty(formData["fromDate"]) && DateTime.TryParse(formData["fromDate"], out DateTime fromParsedDate))
                    {
                        fromDate = fromParsedDate;
                    }

                    if (!StringValues.IsNullOrEmpty(formData["toDate"]) && DateTime.TryParse(formData["toDate"], out DateTime toParsedDate))
                    {
                        toDate = toParsedDate;
                    }
                    return historyTicketController.GetAllTicket(fromDate, toDate);
                default:
                    return Json(new { status = false, message = "Invalid action" });
            }
        }

        private JsonResult ManageStatistics(string action, IFormCollection formData)
        {

            switch (action)
            {
                case "GetAll":
                    DateTime fromDate = DateTime.MinValue;
                    DateTime toDate = DateTime.MinValue;

                    if (!StringValues.IsNullOrEmpty(formData["fromDate"]) && DateTime.TryParse(formData["fromDate"], out DateTime fromParsedDate))
                    {
                        fromDate = fromParsedDate;
                    }

                    if (!StringValues.IsNullOrEmpty(formData["toDate"]) && DateTime.TryParse(formData["toDate"], out DateTime toParsedDate))
                    {
                        toDate = toParsedDate;
                    }
                    return statisticController.GetStatistic(fromDate, toDate);
                default:
                    return Json(new { status = false, message = "Invalid action" });
            }
        }
    }
}
