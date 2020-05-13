namespace FactorialOfNandK
{

    using System;
    using System.Numerics;

    internal class FactorialOfNandK
    {
        private static void Main()
        {
            Console.WriteLine("Please enter your N number: ");
            var numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your K number :");
            var numberK = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;


            if (numberN < numberK || numberN < 1 || numberK < 1)
            {
                Console.WriteLine("\nWrong input! The condition is not satisfied (N > K > 1) ...\n");
                return;
            }


            for (var i = numberK + 1; i <= numberN; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("\nResult: {0}!/{1}! = {2}\n", numberK, numberN, factorial);
        }
    }

}