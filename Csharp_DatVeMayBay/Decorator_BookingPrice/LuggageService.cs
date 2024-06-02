using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Decorator_BookingPrice
{
    public class LuggageService : ServiceDecorator
    {
        public LuggageService(BookingBase wrapObj) : base(wrapObj)
        {
        }

        public override decimal CalculatePrice()
        {
            //Gia tham khao co dinh 15kg ki gui
            return wrapObj.CalculatePrice() + 150000;
        }
    }
}
