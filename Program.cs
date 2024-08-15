namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ############################################################################################ */

            /* Variable definition */

            var hello = "hello";
            string str = "banana";
            int age;
            age = 5;
            bool isOk = true;
            char letter = 'a';
            double fraction = 1.25;
            decimal precision = 23.445m;

            /* ############################################################################################ */

            /* Read and Write on Console */

            Console.WriteLine("Write something: ");
            var input = Console.ReadLine();

            Console.Write(input);
            Console.WriteLine($" {hello} {str} {age} {isOk} {letter} {fraction} {precision}");

            /* ############################################################################################ */

            /* Operators */

            // -------------- Arithmetic --------------
            age = 10;
            age += 3;
            age--;
            fraction = 10 % 3;

            // -------------- Logical --------------
            isOk = (age < fraction) || ((letter == 'b') && (age != 0));

            /* ############################################################################################ */

            /* Control Flow */

            // -------------- If-Else --------------
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

            // -------------- Switch-Case --------------
            switch (age)
            {
                case 15:
                    Console.WriteLine("12");
                    break;
                case var myAge when myAge < 18:             // If you need condition in swith case
                    Console.WriteLine("Less than 18");
                    break;
                case var myAge when myAge == 12:
                    Console.WriteLine("Age is 12");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // -------------- While Loop --------------
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

            /* ############################################################################################ */

            /* String Operations */

            hello = "he" + "alo" + 3;               // Concatination
            hello = $"{hello} , {str}";             // Interpolation

            /* ############################################################################################ */

            /* Built- In Methods */

            // -------------- Arithmetic --------------
            precision = Math.Floor(precision);
            fraction = Math.Pow(2, 3);

            // -------------- String --------------
            age = Convert.ToInt32("25");

            Console.WriteLine($"{precision} {fraction} {age}");

            /* ############################################################################################ */

            /* Functions */

            NewFunction();
            Console.WriteLine($"{NewFunction2()} {NewFunction3(fraction)} {NewFunction4(5.2)}");

            /* ############################################################################################ */

            /* Objects */

            // Static functions doesn't need to create an object
            Program.SecretFunction();                                       // A way to call a non static method in same class


            // -------------- Object Instantiation --------------
            Vehicle vehicleObj = new();                                     // Creating an object of the class
            Vehicle vehicleObj2 = new("Bus", "4-Vehicle");
            string carName = Car.GetCarName();                              // No need to create object for accesing methods for static classes


            // -------------- Get Object Methods and Attributes --------------
            string foo = vehicleObj.Foo();
            vehicleObj.SetName("Train");
            bool hasWheels = vehicleObj.hasWheels;                          // Can only access public values

            Console.WriteLine($"{carName} {foo} {hasWheels} {vehicleObj.GetName()} {vehicleObj2.GetName()}");


            // Inherited Class Objects
            Van vanObj = new();
            vanObj.SetName("Boro");                                         // Get attribute of class Vehicle through inheritance

            // Set attribute using set keyword
            vanObj.NoOfWheels = 4;
            vanObj.NoOfSeats = 10;

            Console.WriteLine($"{vanObj.GetName()} {vanObj.NoOfWheels} {vanObj.NoOfSeats}");

            /* ############################################################################################ */

            /* Struct Data Type */

            // -------------- Struct Definition --------------
            Player player = new();
            player.Name = "Aron";
            Console.WriteLine($"{player.Name}");


            // -------------- Difference b/w STRUCT and CLASS --------------

            // Struct is Value type
            // Class is Reference type

            // -------------- Value type example --------------
            ManStruct manStruct1 = new();
            ManStruct manStruct2 = new();
            manStruct1.Age = 10;
            Console.WriteLine(manStruct1.Age);

            manStruct2 = manStruct1;                                    // Here the value of manStruct1 is copied to manStruct2. 
            manStruct2.Age = 20;                                        // This only changes valu of manStruct2
            Console.WriteLine($"{manStruct1.Age} {manStruct2.Age}");



            // -------------- Reference type example --------------
            ManClass manClass1 = new();
            ManClass manClass2 = new();
            manClass1.Age = 10;
            Console.WriteLine(manClass1.Age);

            manClass2 = manClass1;                  // Here the reference of manStruct1 is copied to manStruct2.
            manClass2.Age = 20;                     // Changing value of manStruct2 also affects value in manStruct1, 
                                                    // Since both are referencing the same memory.

            Console.WriteLine($"{manClass1.Age} {manClass2.Age}");

            /* ############################################################################################ */

            /* Abstract Class Operations */

            // Cannot create an instance of an abstract class
            // Character character = new(); 

            // Instead, Create instance of class that inherits the abstract class
            PlayerCharacter playerCharacter = new();
            EnemyCharacter enemyCharacter = new();

            playerCharacter.ShowName("lion");
            enemyCharacter.ShowName("Bunny");
            playerCharacter.Shoot();

            /* ############################################################################################ */

            /* File I/O Operations */

            // -------------- File Writing through stream --------------
            string path = @"./test.txt";                        // Use @ notation to write path in correct format as a string

            if (!File.Exists(path))                             // Create a file if it doesn't exist in the path
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine("Hello World");              // Write content to the file
                    streamWriter.WriteLine("File created using C#");
                }
            }

            // -------------- Opening the file --------------
            using (StreamReader streamReader = File.OpenText(path))

            // -------------- File Reading through stream --------------
            {
                string? textLine;

                // Store content in each line of the file until it reaches EOF, i.e. null
                while ((textLine = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(textLine);
                }
            }

            /* ############################################################################################ */

            /* Collections */

            // -------------- Arrays --------------
            int[] myNumbers = [10, 5, 21];                  // a collection of integer values

            Console.WriteLine(myNumbers[2]);                // Accessing value in the array using index

            for (int i = 0; i < myNumbers.Length; i++)
                Console.WriteLine(myNumbers[i]);

            foreach (int number in myNumbers)               // foreach is used to iterate through a collection
                Console.WriteLine(number);


            // -------------- Lists --------------
            List<string> myContacts = new();                // Defining a list

            myContacts.Add("Edwin");
            myContacts.Add("Anu");
            myContacts.Add("Afreen");
            foreach (var name in myContacts) Console.WriteLine(name);

            myContacts.Remove("Anu");
            myContacts.Insert(2, "Anu");        // There are many methods other than this provided by List, try them out!

            foreach (var name in myContacts) Console.WriteLine(name);

            /* ############################################################################################ */

            /* Multi Dimensionl Arrays */

            // -------------- Cubic Array --------------
            int[,] cube = { { 1, 2 }, { 3, 4 } };                       // 2D Array definition

            // Iterate through rows in the cube. 
            for (int list = 0; list < cube.Rank; list++)                // Rank gives no. of dimensions in the collection
            {
                // Iterate through columns in the cube. 
                for (int i = 0; i < cube.GetLength(list); i++)          // Get length of the array in each dimension
                {
                    Console.WriteLine(cube[list, i]);
                }
            }

            // -------------- Jagged Array --------------
            int[][] myTable = new int[3][];                             // Define jagged Array
            myTable[0] = new int[] { 1, 2, 3 };                         // Set values to array
            myTable[1] = new int[] { 4, 5 };
            myTable[2] = new int[] { 6, 7, 8, 9, 0 };

            // Iterate through the array
            for (int i = 0; i < myTable.Length; i++)
            {
                for (int j = 0; j < myTable[i].Length; j++)
                {
                    Console.WriteLine(myTable[i][j]);
                }
            }




            /* ############################################################################################ */
        }

        /* ############################################################################################ */

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

        /* ############################################################################################ */

        /* Struct in C# */

        struct Player
        {
            public string Name { get; set; }
            public int Health { get; set; }
        }

        struct ManStruct { public int Age { get; set; } }

        /* ############################################################################################ */
    }


    /* ############################################################################################ */

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

    /* ############################################################################################ */

    /* Inheritance */

    // Single Inheritance
    class Van : Vehicle
    {
        private int noOfWheels;

        // Getter and Setter for the attributes noOfWheels using get & set keywords
        // No need to add getNoOfWheels and setNoOfWheels functions
        public int NoOfWheels
        {
            get
            {
                return noOfWheels;
            }
            set
            {
                noOfWheels = value;
            }
        }

        // Another Method to perform get set
        public int NoOfSeats { get; set; }

        public void PrintValues()
        {
            Console.WriteLine($"{this.type} {this.hasWheels}");     // Can only access public & protected values
        }
    }

    class ManClass { public int Age { get; set; } }

    /* ############################################################################################ */

    /* Abstract Class */
    abstract class Character                        // The class should be abstract to contain an abstract method
    {
        public string bullet = "red bullet";        // Abstract class can include attributes

        // Abstract method only need method defenition
        public abstract void ShowName(string name);

        public void Shoot()
        {
            Console.WriteLine($"shooting {bullet}");
        }
    }

    class PlayerCharacter : Character               // Inheriting an abstract class
    {
        // Use override keyword for overriding the method content in abstract class
        public override void ShowName(string name)      // Must include all the abstract methods present in the abstract class that is inherited
        {
            Console.WriteLine($"The Player name is: {name}");
        }
    }

    class EnemyCharacter : Character                // Similar to above
    {
        public override void ShowName(string name)
        {
            Console.WriteLine($"The Enemy name is: {name}");    // Each inherited class can have different content inside abstract method
        }
    }

    /* ############################################################################################ */

    /* Interfaces */

    interface IAnimal
    {
        // int age;                         // Cannot include attributes in Interface, Only abstract methods
        void ShowName(string name);         // All the methods in interface are abstract methods
        public string MakeSound();
    }

    class Cat : IAnimal
    {
        public void ShowName(string name)   // Must include all methods from inherited Interface. No need for override keyword
        {
            Console.WriteLine($"The Cat name is: {name}");
        }

        public string MakeSound()
        {
            return "Meeoowwww";
        }
    }

    /* ############################################################################################ */
}