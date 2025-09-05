using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal class PaymentServiceFactory
    {
        public static IPaymentService Create(string method)
        {
            return method switch
            {
                "Cash" => new CashService(),
                "CreditCard" => new CreditCardService(),
                "PayPal" => new PayPalService(),
                _ => throw new ArgumentException("Unknown payment method")
            };
        }
    }
}
