using C__Learning.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Polymorphism
{
    internal class Program : ProgramBase
    {
        // Polymorphism

        // Poly = many
        // Morph = forms

        // Polymorphism is ability of an object to take many forms. 

        public override void Run()
        {
            Console.WriteLine("Polymorphism Program");

            // car and plane
            Car car = new Car();
            car.Start();
            car.Stop();

            Plane plane = new Plane();
            plane.Start();
            plane.Stop();

            // vehicle
            Vehicle vehicle = new Vehicle();
            vehicle.Start();
            vehicle.Stop();

            //List<Vehicle> list = new List<Vehicle>();
            //list.Add(car);
            //list.Add(plane);
            //list.Add(vehicle);
            //foreach (object obj in list)
            //{
            // obj.Start();
            // obj.Stop()
            //}


            Console.WriteLine();
            
            Shape shape1 = new Circle(4);
            Shape shape2 = new Rectangle(2,5);

            Console.WriteLine($"The area of the shape is: {shape1.Area()}");
            Console.WriteLine($"The area of the shape is: {shape2.Area()}");


            Console.WriteLine();
            Console.WriteLine("#######################");
            Console.WriteLine();

        }
    }
}
