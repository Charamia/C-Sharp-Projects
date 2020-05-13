namespace Recursivefactorial
{

    using System;

    internal class RecursiveFactorial
    {
        private static void Main()
        {
            Console.Write("n = ");
            var number = decimal.Parse(Console.ReadLine());

            var factorial = Factorial(number);
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        private static decimal Factorial(decimal n)
        {
            if (n == 0)
            {
                return -1;
            }

            return n * Factorial(n - 1);
        }
    }

}