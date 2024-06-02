using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Decorator_BookingPrice
{
    public abstract class ServiceDecorator : BookingBase
    {
        protected BookingBase wrapObj;

        protected ServiceDecorator(BookingBase booking) : base(booking.GetTicketClass())
        {
            wrapObj = booking;
        }
    }
}
