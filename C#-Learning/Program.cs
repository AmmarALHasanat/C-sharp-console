using System;
using System.Drawing;
//using System.Linq;
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

            // int and log => stores integers number link -1, 1
            // int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
            // long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            //int intNumber = 10;
            //Console.WriteLine(intNumber);

            // double => stores decimals number 1.99 or -1.99
            // float 4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            // double 8 bytes Stores fractional numbers. Sufficient for storing 15 decimal digits
            
            //double doubleNumber = 134.43;
            //Console.WriteLine(doubleNumber);

            // char => stores single characters, such as 'a' or 'A'. Char values are surrounded by single quotes
            // char	2 bytes	Stores a single character/letter, surrounded by single quotes
            //char charVar = 'A';
            //Console.WriteLine(charVar);

            // string => stores text, such as "Any Text". String values are surrounded by double quotes
            // string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
            //string stringVar = "test text";
            //Console.WriteLine(stringVar);

            // bool => stores values with two states: true or false
            // bool	1 bit	Stores true or false values
            //bool boolVar = false;
            //Console.WriteLine(boolVar);

            //const double py = 3.14;
            //py = 20; // error
            //Console.WriteLine(2 * py);

            // Multiple Variables

            //int x = 5, y = 10, z = 222;
            //Console.WriteLine(x + y + z);

            // variables must be identified with unique names.
            //int volume = 25;
            //Console.WriteLine(volume);

            /**
             * Type Casting
             * 1 - Implicit Casting (automatically) - converting a smaller type to a larger type size
             * char -> int -> long -> float -> double
             * 
             * 2 - Explicit Casting(manually) - converting a larger type to a smaller size type
             * double -> float -> long -> int -> char
             */

            //int myInt = 4;
            //double myDouble = myInt;
            //Console.WriteLine(myInt);      // Outputs 4
            //Console.WriteLine(myDouble);   // Outputs 4

            //double myDouble2 = 9.78;
            //int myInt2 = (int)myDouble2;    // Manual casting: double to int

            //Console.WriteLine(myDouble2);   // Outputs 9.78
            //Console.WriteLine(myInt2);      // Outputs 9

            //int myInt3 = 10;
            //double myDouble3 = 5.25;
            //bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            //Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


            // input 
            //Console.WriteLine("Enter name:");
            //string name = Console.ReadLine()??"";
            //Console.WriteLine("Hi, " + name);
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: " + age);

            /** 
             * Math library
             * Math.Max Math.Min Math.Sqrt Math.Abs Math.Round ..... 
             */

            /**
             * String Length
             * str.Length
             * 
             * Methods
             * sting str ="test"
             * str.ToUpper() str.ToLower() str.EndsWith str.Equals str.Substring .....
             * 
             * String Concatenation
             * firstName + lastName or string.Concat(firstName, lastName)
             * 
             * String Interpolation
             * string firstName = "Ammar" , lastName = "AlHasanat";
             * string name = $"full name is: {firstName} {lastName}";
             * Console.WriteLine(name);
             * 
             * Access Strings
             * using index like firstName[0]
             * 
             * Special Characters
             * \\ \" \' \n \t \b
             */


            /**
             * The if Statement
             * if (condition) 
             * {
             *   // block of code to be executed if the condition is True
             * }
             * 
             * The else Statement
             * if (condition) 
             * {
             *   // block of code to be executed if the condition is True
             * }
             * else
             * {
             *   // block of code to be executed if the condition is False
             * }
             * 
             * The else if Statement
             * if (condition1) 
             * {
             *   // block of code to be executed if condition1 is True
             * }
             * else if(condition2)
             * {
             *   // block of code to be executed if the condition1 is false and condition2 is True
             * }
             *              * else
             * {
             *   // block of code to be executed if the condition1 is false and condition2 is False
             * }
             * 
             * Short Hand If...Else
             * 
             * variable = (condition) ? expressionTrue :  expressionFalse;
             * 
             * Switch Statements
             * 
             * switch(expression)
             * {
             * case x:
             * // code block
             * break;
             * case y:
             * // code block
             * break;
             * default:
             * // code block
             * break;
             * }
             * 
             */

            /**
             * Loops
             * 
             * While Loop
             * while (condition) 
             * {
             *   // code block to be executed
             * }
             * 
             * Do/While Loop
             * do 
             * {
             *   // code block to be executed
             * }
             * while (condition);
             * 
             * For Loop
             * for (var ; condition; executedTime) 
             * {
             *   // code block to be executed
             * }
             * 
             * Foreach Loop
             * foreach (type variableName in arrayName) 
             * {
             * // code block to be executed
             * }
             * 
             * in loop if(condition) break or continue
             * 
             */
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            /**
             * Array
             * 
             * string[] cars;
             * string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
             * int[] intNumbers = {10, 20, 30, 40};
             * 
             * Access the Elements of an Array
             * Console.WriteLine(cars[0]);
             * 
             * Loop Through an Array
             * string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
             * for (int i = 0; i < cars.Length; i++)
             * {
             *   Console.WriteLine(cars[i]);
             * }
             * 
             * The foreach Loop
             * foreach (string i in cars) 
             * {
             *   Console.WriteLine(i);
             * }
             * 
             * Sort an Array
             * There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
             * Array.Sort(cars);
             * Array.Sort(myNumbers);
             */

            // System.Linq Namespace
            // int[] myNumbers = { 1, 2, 3, 4, 5, 6 };
            // Console.WriteLine(myNumbers.Max());
            // Console.WriteLine(myNumbers.Min());
            // Console.WriteLine(myNumbers.Sum());

            /**
             * Multidimensional Arrays
             * Two-Dimensional Arrays
             * int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
             * numbers[0,1] => 4
             * 
             * Loop Through a 2D Array
             *  foreach (int i in numbers)
             *  {
             *     Console.WriteLine(i);
             *  }
             *  
             * Or GetLength() using for loop
             * 
             * for (int i = 0; i < numbers.GetLength(0); i++)
             * {
             *      for (int j = 0; j < numbers.GetLength(1); j++)
             *      {
             *          Console.WriteLine(numbers[i, j]);
             *          }
             * }
             * 
             */

            /**
             * Methods 
             * types :
             * 1 - Instance Methods: Operate on class instances.
             * 2 - Static Methods: Belong to the class itself.
             * 3 - Abstract Methods: Have no implementation and must be overridden.
             * 4 - Virtual Methods: Can be overridden by derived classes.
             * 5 - Override Methods: Provide new implementations for virtual methods.
             * 6 - Extension Methods: Add functionality to existing types.
             * 7 - Asynchronous Methods: Perform asynchronous operations.
             * 8 - Generic Methods: Work with different data types.
             * 9 - Partial Methods: Optionally implemented in partial classes.
             *  
             * types of values or nothing at all
             * 1 - Void: No return value..
             * 2 - Value Types: Return built-in data types like int, double, etc..
             * 3 - Reference Types: Return objects or data structures..
             * 4 - Generic Types: Return types specified at runtime.
             * 5 - Nullable Types: Return value types that can be null.
             * 6 - Task and Task<T>: Return results of asynchronous operations.
             * 
             */

        }
    }
}