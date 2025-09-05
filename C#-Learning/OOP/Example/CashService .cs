using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal class CashService : IPaymentService
    {
        public bool Pay(Order order)
        {
            Console.WriteLine($"Processing cash payment for order {order.Id} with amount {order.Amount}");
            return true;
        }
    }
}
