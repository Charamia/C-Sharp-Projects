namespace _11.FibonacciSequence
{

    using System;

    internal class FibonacciSequence
    {
        private static void Main()
        {
            long num1 = 0;
            long num2 = 1;
            long sum = 1;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (var i = 0; i <= 100; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
            }
        }
    }

}