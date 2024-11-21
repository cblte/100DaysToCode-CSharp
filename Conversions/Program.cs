﻿namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000001";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegativ = "-55.2";
            double negativ = Convert.ToDouble(textNegativ);
            Console.WriteLine(negativ);

            string textPrecision = "5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

        }
    }
}
