using C__Learning.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Inheritance
{
    internal class Program : ProgramBase
    {
        public override void Run()
        {
            Console.WriteLine("Inheritance Program");

            Student student = new Student
            {
                Name = "Samer",
                Age = 20,
                StudentID = "S1953"
            };

            // Call methods from Student and Person class
            student.Introduce(); // Inherited from Person
            student.Study();     // Specific to Student

            Console.WriteLine();

            // Create a Teacher object
            Teacher teacher = new Teacher
            {
                Name = "Mr. Ammar",
                Age = 35,
                Subject = "Mathematics"
            };

            // Call methods from Teacher and Person class
            teacher.Introduce(); // Inherited from Person
            teacher.Teach();     // Specific to Teacher

            Console.WriteLine();
            Console.WriteLine("#######################");
            Console.WriteLine();
        }
    }
}
