/*using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using static Csharp_DatVeMayBay.Controllers.FlightsController;

namespace Csharp_DatVeMayBay.Controllers
{
    public class PassengerController : Controller
    {
        public class CustomFlightandPassengerViewModel
        {
            public CustomFlight CustomFlight { get; set; }
            public PassengerInfo PassengerInfo { get; set; }

        }

        public class PassengerInfo
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string phoneNumber { get; set; }
            public string address { get; set; }
            public DateOnly Dob { get; set; }

            public string seat { get; set; }
            public PassengerInfo(string firstName, string lastName, string phoneNumber, string address, DateOnly Dob, string seat)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.phoneNumber = phoneNumber;
                this.address = address;
                this.Dob = Dob;
                this.seat = seat;
             }
        }

        [Route("/passenger")]
        [HttpPost]
        public IActionResult PassengerInfoVerify()
        {
            var firstName = Request.Form["firstName"];
            var lastName = Request.Form["lastName"];
            var phoneNumber = Request.Form["phoneNumber"];
            var address = Request.Form["address"];
            var Dob = DateOnly.Parse(Request.Form["Dob"]);
            var seatNo = Request.Form["seatNo"];
            Console.WriteLine(seatNo);
            var passengerInfo = new PassengerInfo( firstName, lastName, phoneNumber, address, Dob, seatNo);     
            var flightData = Request.Form["flightData"];
            var customFlight = JsonConvert.DeserializeObject<CustomFlight>(flightData);
            Console.WriteLine(Dob);
            var viewModel = new CustomFlightandPassengerViewModel
            {
                CustomFlight = customFlight,
                PassengerInfo = passengerInfo
            };

            return View(viewModel);
        }
    }
}
*/