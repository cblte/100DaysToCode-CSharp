namespace Numeric_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = -23;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = -900000000001L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negativ = -55.2D;
            Console.WriteLine(negativ);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            float precision = 5.0000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


        }
    }
}
