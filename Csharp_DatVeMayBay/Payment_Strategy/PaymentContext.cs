using Microsoft.AspNetCore.Mvc;

namespace Csharp_DatVeMayBay.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;


        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void setPayment(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
        public Task<string> Pay(string BookingId, double Price)
        {
            return paymentStrategy.Pay(BookingId, Price);
        }
    }
}
