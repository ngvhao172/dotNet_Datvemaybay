using Csharp_DatVeMayBay.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using static Csharp_DatVeMayBay.Controllers.FlightsController;

namespace Csharp_DatVeMayBay.Controllers
{
    public class PassengerController : Controller
    {
        public class BookingViewModel
        {
            public FormData FormData { get; set; }
            public Flight Flight { get; set; }
            public PassengerInfo PassengerInfo { get; set; }
        }
        public class PassengerInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public DateOnly Dob { get; set; }
            public PassengerInfo(string FirstName, string LastName, string PhoneNumber, string Address, DateOnly Dob)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.PhoneNumber = PhoneNumber;
                this.Address = Address;
                this.Dob = Dob;
            }
        }

        [Route("/passenger")]
        [HttpPost]
        public IActionResult PassengerInfoVerify()
        {
            var FirstName = Request.Form["FirstName"];
            var LastName = Request.Form["LastName"];
            var PhoneNumber = Request.Form["PhoneNumber"];
            var Address = Request.Form["Address"];
            var Dob = DateOnly.Parse(Request.Form["Dob"]);
            var PassengerInfo = new PassengerInfo(FirstName, LastName, PhoneNumber, Address, Dob);
            var FlightData = Request.Form["FlightData"];
            var Flight = JsonConvert.DeserializeObject<Flight>(FlightData);
            var Form = Request.Form["FormData"];
            var FormData = JsonConvert.DeserializeObject<FormData>(Form);
            var viewModel = new BookingViewModel
            {
                Flight = Flight,
                FormData = FormData,
                PassengerInfo = PassengerInfo
            };
            return View(viewModel);
        }
    }
}
