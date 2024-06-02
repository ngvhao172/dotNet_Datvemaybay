using Csharp_DatVeMayBay.Models.Domain;
using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Decorator_BookingPrice
{
    public abstract class BookingBase
    {
        private TicketClass TicketClass;
        public BookingBase(TicketClass ticketClass) {
            TicketClass = ticketClass;
        }
        public TicketClass GetTicketClass() { return TicketClass; }
        public abstract decimal CalculatePrice();
    }
}
