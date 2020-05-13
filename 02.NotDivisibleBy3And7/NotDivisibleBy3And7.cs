namespace _02.NotDivisibleBy3And7
{

    using System;

    internal class NotDivisibleBy3And7
    {
        private static void Main()
        {
            Console.WriteLine("Please enter a number N: ");
            var numberN = int.Parse(Console.ReadLine());

            for (var i = 1; i < numberN; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}