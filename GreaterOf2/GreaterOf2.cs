namespace GreaterOf2
{

    using System;

    internal class GreaterOf2
    {
        private static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var result = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater numbter of {0} and {1} is {2}.", firstNumber, secondNumber, result);
        }
    }

}