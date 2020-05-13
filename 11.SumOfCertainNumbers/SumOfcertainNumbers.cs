namespace _11.SumOfCertainNumbers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SumOfcertainNumbers
    {
        private static void Main()
        {
            int[] input = {4, 3, 1, 4, 2, 5, 8};
            var sumOfNumbers = int.Parse(Console.ReadLine());

            var isFound = false;
            var neighborElements = new List<int>();
            // List<int> temporaryList = new List<int>();

            for (var i = 0; i <= input.Length - 1; i++)
            {
                var temporaryList = new List<int>();

                for (var j = i; j < input.Length - 1; j++)
                {
                    temporaryList.Add(input[j]);

                    if (temporaryList.Sum() == sumOfNumbers)
                    {
                        isFound = true;
                        Console.WriteLine(string.Join(" ", temporaryList));
                    }
                }
            }

            Console.Write(!isFound ? "-There are no sewquences with sum" + sumOfNumbers + "\n" : " ");
        }
    }

}