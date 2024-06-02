using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace Csharp_DatVeMayBay.Strategy
{
    public interface IPaymentStrategy
    {
        public Task<string> Pay(string BookingId, double Price);
    }
}
