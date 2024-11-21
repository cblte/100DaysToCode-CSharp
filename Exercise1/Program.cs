using System.Net.WebSockets;

namespace Exercise1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            /*
             * Define a variable to hold your name
             * Define a variable to hold your phone number
             * Define a variable to hold your age
             * Print variables line-by-line to the screen
             * Extra: define variables using the var keyword
             */

            string name = "Carsten";
            string phoneNumber = "0049-123 456 7890";
            int age = 44;

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);


            /*
             * Create and initalise two ints
             * Make a variable to work out the remainder
             * Output remainder
             * Change first int variable to another number
             *   and recalculate the remainder
             *   output new remainder
             */

            int a = 21;
            int b = 4;
            int v = a % b;
            Console.WriteLine(v);
            a = 18;
            v = a % b;
            Console.WriteLine(v);

        }
    }
}
