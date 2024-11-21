namespace Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100.0;

            // This will not work as it is a constant
            // vat = 10;

            int balance = 1000;

            Console.WriteLine(balance * percentVAT);

        }
    }
}
