namespace FactorialTask2
{

    using System;
    using System.Numerics;

    internal class FactorialTask2
    {
        private static void Main()
        {
            Console.WriteLine("You should to enter two numbers (1 < K < N)");

            Console.Write("-> N: ");
            var n = int.Parse(Console.ReadLine());

            Console.Write("-> K: ");
            var k = int.Parse(Console.ReadLine());

            if (k > n || n < 1 || k < 1)
            {
                Console.WriteLine("\nWrong input! Тhe condition is not satisfied (1 < K < N)...\n");
                return;
            }

            BigInteger factorial = 1;
            for (var i = n - k + 1; i <= n; i++)
            {
                factorial *= i;

                if (i == k)
                {
                    i = 2;

                    while (i <= n)
                    {
                        factorial *= i;
                        i++;
                    }

                    break;
                }
            }

            Console.WriteLine("\nResult: {0}!*{1}!/({0}-{1})! = {2}\n", n, k, factorial);
        }
    }

}