namespace SmallestAndLargest
{

    using System;

    internal class SmallestAndLargest
    {
        private static void Main()
        {
            Console.WriteLine("Please enter the count of of numbers: ");
            var countOfNumbers = int.Parse(Console.ReadLine());

            var numbers = new int[countOfNumbers];
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var maxNumber = numbers[0];
            var minNumber = numbers[0];

            for (var i = 1; i < numbers.Length - 1; i++)
            for (var j = 2; j < numbers.Length - 1; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    if (maxNumber < numbers[i])
                    {
                        maxNumber = numbers[i];
                    }
                }

                if (numbers[i] < numbers[j])
                {
                    if (minNumber > numbers[i])
                    {
                        minNumber = numbers[i];
                    }
                }
            }

            Console.WriteLine($"Smallest number is {minNumber} and largest number is {maxNumber}");
        }
    }

}