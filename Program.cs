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

        }
    }
}