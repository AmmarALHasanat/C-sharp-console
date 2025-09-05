using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Learning.OOP.Inheritance
{
    // Derived class
    internal class Teacher:Person
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}.");
        }

        public override void Introduce()
        {
            base.Introduce();
            // Additional introduction for Teacher
            Console.WriteLine($"I teach {Subject}.");
        }
    }
}
