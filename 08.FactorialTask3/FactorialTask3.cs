namespace _08.FactorialTask3
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter N: ");
            var n = uint.Parse(Console.ReadLine());

            Console.Write("Enter X: ");
            var x = uint.Parse(Console.ReadLine());

            var sum = 1m;
            for (var i = 1; i <= n; i++)
            {
                // Calculate factorial i!
                decimal factorial = i;
                factorial = CalculateFactorial(factorial);

                sum = sum + factorial / (decimal) Math.Pow(x, i);
            }

            Console.WriteLine("\nSum = {0}\n", sum);
        }

        private static decimal CalculateFactorial(decimal number)
        {
            if (number < 1)
            {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }
    }

}