using System;
using Car;
// name space for using in other file like
namespace HelloWorld
{
    /**
     * This is a comment
     */
    class Program
    {
        static void Main(string[] args)
        {
            // This is a Car Object
            Car.Car car = new Car.Car();
            car.setName("BMW");
            Console.WriteLine(car.getName());
        }
    }
}