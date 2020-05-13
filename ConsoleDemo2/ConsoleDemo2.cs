namespace ConsoleDemo2
{

    using System;

    internal class ConsoleDemo2
    {
        private static void Main()
        {
            Console.Write("Please enter first number: ");
            var firstNumber = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            var secondNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Result is {0}!", firstNumber + secondNumber);
        }
    }

}