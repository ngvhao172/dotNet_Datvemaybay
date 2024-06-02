using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Decorator_BookingPrice
{
    public class RoundTripBooking : BookingBase
    {
        private Flight InboundFlight { get; set; }
        private Flight OutboundFlight { get; set; }
        public RoundTripBooking(TicketClass ticketClass, Flight inboundFlight, Flight outboundFlight) : base(ticketClass)
        {
            InboundFlight = inboundFlight;
            OutboundFlight = outboundFlight;
        }

        public override decimal CalculatePrice()
        {
            return (GetTicketClass() == TicketClass.Economy) ? (InboundFlight.EconomyPrice + OutboundFlight.EconomyPrice) : (InboundFlight.BussinessPrice + OutboundFlight.BussinessPrice);
        }
    }
}
