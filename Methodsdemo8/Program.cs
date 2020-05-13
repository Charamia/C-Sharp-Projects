namespace Methodsdemo8
{

    using System;

    internal class Program
    {
        private static void Print()
        {
            Console.WriteLine();
        }

        private static void Print(int number)
        {
            Console.WriteLine(number);
        }

        private static void Print(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Print(string text)
        {
            Console.WriteLine(text);
        }

        private static void Main()
        {
            //Print(7, 9);

            Console.WriteLine(Sum(1, 2, 3, 5, 7, 8, 7));
            Console.WriteLine(Sum(0));
            Console.WriteLine(Sum(1, 2, 5, 7, 9));
        }

        private static int Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }

}