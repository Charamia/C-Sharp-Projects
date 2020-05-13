namespace TheNumbersFrom1ToN
{

    using System;

    internal class TheNumbersFrom1ToN
    {
        private static void Main()
        {
            Console.WriteLine("Please enter a number N: ");
            var number = int.Parse(Console.ReadLine());

            for (var i = 1; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

}