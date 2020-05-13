namespace DemoLoops8
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var result = 1;

            for (var i = 1; i <= 5; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }

}