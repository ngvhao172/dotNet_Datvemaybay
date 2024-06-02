using Csharp_DatVeMayBay.Models.Domain;

namespace Csharp_DatVeMayBay.Command_Pattern
{
    public class GetTicketInfoCommand : ICommand
    {
        private readonly FlightService _flightService;
        private readonly string _ticketId;
        private Ticket _ticket;

        public GetTicketInfoCommand(FlightService flightService, string ticketId)
        {
            _flightService = flightService;
            _ticketId = ticketId;
        }
        public async Task ExecuteAsync()
        {
            _ticket = await _flightService.GetTicketInfoAsync(_ticketId);
        }
        public Ticket GetResult()
        {
            return _ticket;
        }
    }
}
