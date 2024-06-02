using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Decorator_BookingPrice
{
    public class OnewayBooking : BookingBase
    {
        private Flight Flight { get; set; }
        public OnewayBooking(TicketClass ticketClass, Flight flight) : base(ticketClass)
        {
            Flight = flight;
        }
        public override decimal CalculatePrice()
        {
            return (GetTicketClass() == TicketClass.Economy) ? Flight.EconomyPrice : Flight.BussinessPrice;
        }
    }
}
