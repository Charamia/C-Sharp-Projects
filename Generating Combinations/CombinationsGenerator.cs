namespace Generating_Combinations
{

    using System;

    internal class CombinationsGenerator
    {
        private static void Main()
        {
            var n = 3;
            var startNum = 4;
            var endNum = 8;

            var arr = new int[n];
            GenerateCombinations(arr, 0, startNum, endNum);
        }

        private static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
        {
            if (index >= arr.Length)
                // A combination was found --> print it
            {
                Console.WriteLine("(" + string.Join(", ", arr) + ")");
            }
            else
            {
                for (var i = startNum; i <= endNum; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, i + 1, endNum);
                }
            }
        }
    }

}