using C__Learning.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal class Program : ProgramBase
    {
        public override void Run()
        {
            Order order = new Order(PaymentServiceFactory.Create("Cash")) { Id = 1, Amount = 100.0m };
            bool result = order.ProcessOrder();
            Console.WriteLine($"Order processed: {result}");

            // how to use list
            //List<Car> cars = new List<Car>
            //{
            //    new Car("Volvo"),
            //    new Car("BMW"),
            //    new Car("Ford"),
            //    new Car("Mazda"),
            //    new Car("Nova")
            //};

            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car.getName());
            //}
            //foreach (var car in cars.Where(c => c.getName().StartsWith("B")))
            //{
            //    Console.WriteLine(car.getName());
            //}
            //Console.WriteLine(cars.First().getName());
            //Console.WriteLine(cars.First(c => c.getName().EndsWith("a")).getName());
            //Console.WriteLine(cars.Count());
            //Console.WriteLine(cars.Count(c => c.getName().Contains("o")));

        }
    }
}
