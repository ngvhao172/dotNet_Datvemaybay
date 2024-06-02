namespace Csharp_DatVeMayBay.Strategy
{
    public class SimplePaymentFactory
    {
        public IPaymentStrategy CreatePayment(string type)
        {
            if(type == "Momo")
            {
                return new MomoPayment();
            }
            else if(type == "VNPay")
            {
                return new VNPayPayment();
            }
            else if(type == "Creditcard")
            {
                return new CreditCartPayment();
            }
            return new CreditCartPayment();
        }
    }
}
