using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal interface IPaymentService
    {
        bool Pay(Order order);
    }
}
