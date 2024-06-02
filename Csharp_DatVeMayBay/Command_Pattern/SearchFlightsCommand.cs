using Csharp_DatVeMayBay.Models.Domain;
using static Csharp_DatVeMayBay.Controllers.FlightsController;

namespace Csharp_DatVeMayBay.Command_Pattern
{
    public class SearchFlightsCommand : ICommand
    {
        private readonly FlightService _flightService;
        private readonly FormData _formData;
        private List<Flight> _flights;

        public SearchFlightsCommand(FlightService flightService, FormData formData)
        {
            _flightService = flightService;
            _formData = formData;
        }

        public async Task ExecuteAsync()
        {
            _flights = await _flightService.SearchFlightsAsync(_formData);
        }
        public List<Flight> GetResult()
        {
            return _flights;
        }
    }
}
