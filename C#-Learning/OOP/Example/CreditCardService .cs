using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal class CreditCardService : IPaymentService
    {
        public bool Pay(Order order)
        {
            Console.WriteLine("Paid with Credit Card.");
            return true;
        }
    }
}
