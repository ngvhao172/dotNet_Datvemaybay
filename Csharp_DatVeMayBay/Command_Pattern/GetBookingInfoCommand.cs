using Csharp_DatVeMayBay.Models.Domain;
using static Csharp_DatVeMayBay.Controllers.FlightsController;

namespace Csharp_DatVeMayBay.Command_Pattern
{
    public class GetBookingInfoCommand : ICommand
    {
        private readonly FlightService _flightService;
        private readonly string _bookingId;
        private Booking _booking;

        public GetBookingInfoCommand(FlightService flightService, string bookingId)
        {
            _flightService = flightService;
            _bookingId = bookingId;
        }
        public async Task ExecuteAsync()
        {
            _booking = await _flightService.GetBookingInfoAsync(_bookingId);
        }
        public Booking GetResult()
        {
            return _booking;
        }
    }
}
