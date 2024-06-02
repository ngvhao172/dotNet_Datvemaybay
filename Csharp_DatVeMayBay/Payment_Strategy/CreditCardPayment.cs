using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Strategy
{
    public class CreditCartPayment : IPaymentStrategy
    {
        public Task<string> Pay(string BookingId, double price)
        {
            string paymentCallbackUrl = $"/credit_callback/{BookingId}";
            return Task.FromResult(paymentCallbackUrl);
        }
    }
}
