namespace _09.SubsequenceOfNumbersWithMaximalSum
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SubsequenceOfNumbersWithMaximalSum
    {
        private static void Main()
        {
            int[] inputArray = {122, -3, -6, -1, -2, -1, -8, -6, -4, -8};
            var elementsMaxSum = new List<int>();
            var temporarySum = new List<int>();
            var maxSum = 0;

            for (var i = 0; i <= inputArray.Length - 1; i++)
            {
                temporarySum.Add(inputArray[i]);

                if (maxSum < temporarySum.Sum())
                {
                    maxSum = temporarySum.Sum();
                }

                for (var k = i + 1; k <= inputArray.Length - 1; k++)
                {
                    temporarySum.Add(inputArray[k]);

                    if (maxSum < temporarySum.Sum())
                    {
                        maxSum = temporarySum.Sum();
                    }
                }

                temporarySum.Clear();
            }

            Console.WriteLine(maxSum);
        }
    }

}