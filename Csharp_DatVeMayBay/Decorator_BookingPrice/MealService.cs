using Csharp_DatVeMayBay.Models.Enums;

namespace Csharp_DatVeMayBay.Decorator_BookingPrice
{
    public class MealService : ServiceDecorator
    {
        public MealService(BookingBase wrapObj) : base(wrapObj)
        {
        }

        public override decimal CalculatePrice()
        {
            //Tra ve tien mot suat an tieu chuan (chi la gia tham khao)
            return (GetTicketClass() == TicketClass.Economy) ? wrapObj.CalculatePrice() + 150000 : wrapObj.CalculatePrice() + 250000;
        }
    }
}
