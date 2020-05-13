namespace DevidedBy5
{

    using System;

    internal class DevidedBy5
    {
        private static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            var secondNumber = int.Parse(Console.ReadLine());

            var counter = 0;

            for (var i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("{0} numbers between {1} and {2} are devided by 5.", counter, firstNumber, secondNumber);
        }
    }

}