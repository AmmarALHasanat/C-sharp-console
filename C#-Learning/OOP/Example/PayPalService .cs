using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal class PayPalService : IPaymentService
    {
        public bool Pay(Order order)
        {
            Console.WriteLine("Paid with PayPal.");
            return true;
        }
    }
}
