using C__Learning.OOP.Abstraction;

namespace C__Learning.Ref
{
    internal class Program : ProgramBase
    {
        public override void Run()
        {
            // variable types in C#
            // Task 1 : create new variables and assign values to them  name as `myVariable1` , age as 0 to 100, salary as 0.0 to 100000.0 , isMarried as true or false , discount as 0.0 to 1.0
            // print data type of each variable like this:

            // note : use operator ?: to print married status as Yes or No  use % to print discount as percentage
            /** 
            Name: Ammar
            Age: 30
            Married: Yes
            Net Salary: 925.50
            */

            // note : use operator ?: to print married status as Yes or No  use % to print discount as percentage
            Console.WriteLine("Task 1: ");

            string name = "Ammar";
            int age = 28;
            double salary = 925.50;
            bool isMarried = false;

            double discount = 0.15;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Married: {(isMarried ? "Yes" : "No")}");
            Console.WriteLine($"Net Salary: {salary}");
            Console.WriteLine($"Discount: {discount * 100}%");


            // Task 2 : create a variable score and assign it a value nullbel, then print value if set or print "No score provided" if not set

            Console.WriteLine("\nTask 2: ");
            void PrintScore(int? score)
            {
                if (score.HasValue)
                {
                    Console.WriteLine($"Score: {score.Value}");
                }
                else
                {
                    Console.WriteLine("No score provided");
                }
            }

            int? score = null;
            PrintScore(score);
            score = 85;
            PrintScore(score);
            score = null;
            PrintScore(score);


            // Task 3 : create a variable a equl 10 and b and assign a to b then change value of b to 50 and print both values
            // then create arr1 and arr2 and assign arr1 to arr2 then change value of arr2[0] to 100 and print both arrays
            Console.WriteLine("\nTask 3: ");

            int a = 10;
            int b = a;
            b = 50; // here changing b will not change a because they are value types
            Console.WriteLine($"a: {a}, b: {b}");

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 100; //here changing arr2 will also change arr1 because they reference the same array
            Console.WriteLine($"arr1: {string.Join(", ", arr1)}");
            Console.WriteLine($"arr2: {string.Join(", ", arr2)}");

            // clone array arr1 to arr3 and change value of arr3[0] to 200 and print both arrays

            int[] arr3 = (int[])arr1.Clone(); // Cloning the array to create a new instance
            arr3[0] = 200; // Changing arr3 will not affect arr1
            Console.WriteLine($"arr1 after cloning: {string.Join(", ", arr1)}");
            Console.WriteLine($"arr3: {string.Join(", ", arr3)}");

            // use copy 
            int[] arr4 = new int[arr1.Length];
            Array.Copy(arr1, arr4, arr1.Length);
            arr4[0] = 300;
            Console.WriteLine($"arr1 after copying: {string.Join(", ", arr1)}");
            Console.WriteLine($"arr4: {string.Join(", ", arr4)}");

            // use linq
            int[] arr5 = arr1.Select(x => x).ToArray();
            arr5[0] = 400;
            Console.WriteLine($"arr1 after linq: {string.Join(", ", arr1)}");
            Console.WriteLine($"arr5: {string.Join(", ", arr5)}");



            // Note - string, array, and class are reference types
            // Note - Number types are value types like int, double, float, decimal, etc.

            // Casting & Conversion

            int number = 10;
            long longNumber = number; // 10 Implicit


            double pi = 3.14;

            int intPi = (int)pi; // 3 Explicit

            string s = "123";
            int parsed = int.Parse(s); // 123 Explicit

            string wrong = "abc";
            int parsedWrong = int.TryParse(wrong, out int result) ? result : 0;

            Console.WriteLine($"Parsed wrong: {parsedWrong}");

            double d = Convert.ToDouble("99.5");

            // Constants

            const double Pi = 3.14159; // Constant value that cannot be changed

            User user = new User(4, "Samer");
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");

            user.Name = "Ammar";

            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");



            // Methods
            // struct person >> [access_modifier] [return_type] MethodName([parameters]){ // body  return value; // if not void }

            void sayHello()
            {
                Console.WriteLine("Hello, World!");
            }

            sayHello();


            void sayHelloTo(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            sayHelloTo("Ammar");

            void printMessage(string msg = "Mo message")
            {
                Console.WriteLine(msg);
            }

            printMessage();

            // ref in out parameters

            void refExample(ref int a, int b)
            {
                a += b;
                b += 10;
            }

            int x = 5;
            int y = 10;
            refExample(ref x, y);
            Console.WriteLine($"x: {x}, y: {y}");

            void outExample(out int a, int b)
            {
                a = b + 5;
            }

            int z;
            int w = 20;
            outExample(out z, w);
            Console.WriteLine($"z: {z}, w: {w}");

            int avg(params int[] numbers)
            {
                return numbers.Sum() / numbers.Length;

            }

            Console.WriteLine($"Average: {avg(1, 2, 3, 4, 5)}");

            Console.WriteLine("\n Msg Test");
            Methods.Run();



            int Square(int x) => x * x;

            Console.WriteLine($"Square of 5: {Square(5)}");





            // Conditions: IF statement and Switch statement


            if(age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age >= 13)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are a child.");
            }


            // Switch statement

            char grade = 'B';
            switch (char.ToUpper(grade))

            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("You passed.");
                    break;
                case 'D':
                    Console.WriteLine("You need to work harder.");
                    break;
                case 'F':
                    Console.WriteLine("You failed.");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }

            bool isWeekend = true;
            Console.WriteLine(isWeekend ? "Happy weekend" : "Go to work!");

            // loops: for, while, do-while, foreach

            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////");
            int count = 1;
            while (count<5)
            {
                int j = 0;
                while (j<count)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                count++;
            }

            Console.WriteLine("/////////////////////");
            int k = 1;
            // do mean at least one iteration
            do
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                k++;
            }
            while (k < 5);

            Console.WriteLine("/////////////////////");
            string[] names = { "Ammar", "Samer", "Ali" };
            foreach (string n in names)
            {
                Console.WriteLine($"Hello, {n}!");
            }

            Console.WriteLine("/////////////////////");

            Point point2D = new Point(10, 20);
            point2D.Print();

        }
    }

    internal class Point
    {
        private int _x;
        private int _y; 
        private int _z;
        public bool Is3D { get; private set; }
        public Point()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }
        public Point(int x, int y, int z = 0)
        {
            _x = x;
            _y = y;
            _z = z;
            Is3D = z != 0; 
        }
        
        public int X
        {
            get => _x;
            set => _x = value;
        }
        public int Y
        {
            get => _y;
            set => _y = value;
        }
        public int Z
        {
            get => _z;

            // get { return _z; }
            set
            {
                Is3D = value != 0;
                _z = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Point Coordinates: ({_x}, {_y}, {_z})");
        }

    }
}
