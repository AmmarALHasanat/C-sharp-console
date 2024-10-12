using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Abstraction
{
    internal class Program : ProgramBase
    {

        public override void Run()
        {

            // Abstraction
            // Reduce complexity by hiding unncessary details
            Console.WriteLine("Abstraction Program");
            Console.WriteLine();

            PaymentService paymentService = new PaymentService();
            paymentService.ProcessPayment(20);

            Console.WriteLine();
            Console.WriteLine("#######################");
            Console.WriteLine();

        }
    }
}
