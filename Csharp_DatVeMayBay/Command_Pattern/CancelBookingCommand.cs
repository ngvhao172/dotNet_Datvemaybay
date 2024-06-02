using Csharp_DatVeMayBay.Models.Domain;

namespace Csharp_DatVeMayBay.Command_Pattern
{
    public class CancelBookingCommand : ICommand
    {
        private readonly FlightService _flightService;
        private readonly string _bookingId;
        private bool _result;

        public CancelBookingCommand(FlightService flightService, string bookingId)
        {
            _flightService = flightService;
            _bookingId = bookingId;
        }
        public async Task ExecuteAsync()
        {
            _result = await _flightService.CancelBookingAsync(_bookingId);
        }
        public bool GetResult()
        {
            return _result;
        }
    }
}
