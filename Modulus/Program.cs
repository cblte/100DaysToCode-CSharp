namespace Modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 2;

            // 10 / 3 = 3r1
            // 3 x 3 = 9, 1 left over to get to 10

            // 10 % 2 = 0
            // 11 % 2 = 1
            // 12 % 2 = 0
            // 13 % 2 = 1

            Console.WriteLine(a / 3.0); // 3.66666
            Console.WriteLine(a % b);

            Console.WriteLine(1000 % 90); // 10
            Console.WriteLine(100 % 90); // 10
            Console.WriteLine(71 % 10); // 1
        }
    }
}
