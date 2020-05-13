namespace _12.FromDecimalToBinary
{

    using System;

    internal class FromDecimalToBinary
    {
        private static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            int reminder;
            var result = string.Empty;

            while (decimalNumber > 0)
            {
                reminder = decimalNumber % 2;
                decimalNumber /= 2;
                result = reminder + result;
            }

            Console.WriteLine("Decimal number of the above number is {1} in binary notation", decimalNumber, result);
        }
    }

}