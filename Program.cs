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
        }
    }
}