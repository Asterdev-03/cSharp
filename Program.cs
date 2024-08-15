namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variable definition */

            var hello = "hello";
            string str = "banana";
            int age;
            age = 5;
            bool isOk = true;
            char letter = 'a';
            double fraction = 1.25;
            decimal precision = 23.445m;


            /* -------------------------------------------------------------------------------------------- */

            /* Read and Write on Console */

            Console.WriteLine("Write something: ");
            // var input = Console.ReadLine();
            var input = "hi";
            Console.Write(input);
            Console.WriteLine($" {hello} {str} {age} {isOk} {letter} {fraction} {precision}");

            /* -------------------------------------------------------------------------------------------- */

            /* Operators */

            age = 10;
            age += 3;
            age--;
            fraction = 10 % 3;

            isOk = (age < fraction) || ((letter == 'b') && (age != 0));

            /* -------------------------------------------------------------------------------------------- */

            /* Control Flow */

            // If-Else
            if (isOk)
            {
                Console.WriteLine("Do something");
            }
            else if (age > 5)
            {
                Console.WriteLine("Dont do something");
            }
            else
            {
                Console.WriteLine("Dont do ");
            }

            // Switch-Case
            switch (age)
            {
                case 15:
                    Console.WriteLine("12");
                    break;
                case var myAge when myAge < 18:
                    Console.WriteLine("Less than 18");
                    break;
                case var myAge when myAge == 12:
                    Console.WriteLine("Age is 12");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // While Loop
            while (age > 0)
            {
                Console.WriteLine(age);
                age -= 3;
            }

            // For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.Write(isOk);
            }

            /* -------------------------------------------------------------------------------------------- */

            /* String Operations */

            hello = "he" + "alo" + 3;               // Concatination
            hello = $"{hello} , {str}";             // Interpolation

            /* -------------------------------------------------------------------------------------------- */

            /* Built- In Methods */

            // Arithmetic
            precision = Math.Floor(precision);
            fraction = Math.Pow(2, 3);

            // String
            age = Convert.ToInt32("25");

            Console.WriteLine($"{precision} {fraction} {age}");

            /* -------------------------------------------------------------------------------------------- */

            /* Functions */

            NewFunction();
            Console.WriteLine($"{NewFunction2()} {NewFunction3(fraction)} {NewFunction4(5.2)}");

            /* -------------------------------------------------------------------------------------------- */

            /* Objects */

            // Static functions doesn't need to create an object
            Program.SecretFunction();                       // A way to call a non static method in same class

            // Object Instantiation
            Vehicle vehicleObj = new();                     // Creating an object of the class
            Vehicle vehicleObj2 = new("Bus", "4-Vehicle");
            string carName = Car.GetCarName();              // No need to create object for accesing methods for static classes

            // Get Object Methods and Attributes
            string foo = vehicleObj.Foo();
            vehicleObj.SetName("Train");
            bool hasWheels = vehicleObj.hasWheels;          // Can only access public values

            Console.WriteLine($"{carName} {foo} {hasWheels} {vehicleObj.GetName()} {vehicleObj2.GetName()}");

            /* -------------------------------------------------------------------------------------------- */
        }

        /* -------------------------------------------------------------------------------------------- */

        /* Custom Functions */

        // Default
        static void NewFunction()
        {
            Console.WriteLine("new fucntion");
        }

        // Default with return
        static double NewFunction2()
        {
            double newval = 123.456;
            return newval;
        }

        // Parameterized
        static double NewFunction3(double val)
        {
            NewFunction();                                  // Call another function inside fucntion
            double newval = val + 1;
            return newval;
        }

        // Reccursion
        static double NewFunction4(double val)
        {
            if (val <= 0)
            {
                return 1;
            }
            double newval = NewFunction4(val - 1);          // Call same function inside fucntion

            return newval;
        }

        // Non Static Function
        static void SecretFunction()
        {
            Console.WriteLine("Found secret function");
        }

    }


    /* -------------------------------------------------------------------------------------------- */

    /* Custom Classes */

    // Static Class
    public static class Car
    {
        public static string GetCarName()
        {
            return "carrr";
        }
    }

    // Default class
    public class Vehicle
    {
        public bool hasWheels = true;           // public attribute
        private string name;                    // private attribute
        protected string type;                  // protected attribute

        // Constructor
        public Vehicle()
        {
            name = "";
            type = "";
            Console.WriteLine("Vehicle Class");
        }

        // Constructor with Paramters
        public Vehicle(string name, string Type)
        {
            this.name = name;
            type = Type;
        }

        public string Foo()
        {
            return "vehicle";
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }

    /* -------------------------------------------------------------------------------------------- */
}