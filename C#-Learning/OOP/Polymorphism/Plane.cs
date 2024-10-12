using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Polymorphism
{
    internal class Plane : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Plane is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane is stopping.");
        }
    }
}
