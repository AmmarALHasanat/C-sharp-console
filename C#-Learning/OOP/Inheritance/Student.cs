using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Inheritance
{
    // Derived class
    internal class Student:Person
    {
        public string StudentID { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }
}
