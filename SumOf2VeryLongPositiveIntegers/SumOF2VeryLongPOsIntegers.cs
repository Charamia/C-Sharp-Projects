namespace SumOf2VeryLongPositiveIntegers
{

    using System;
    using System.Linq;

    internal class SumOF2VeryLongPOsIntegers
    {
        private static long SumOfTwoVeryBigIntegers(long[] firstArray, long[] secondArray)
        {
            //long[] reversedFirstArray = firstArray.Reverse().ToArray();
            //long[] reversedSecondArray = secondArray.Reverse().ToArray();

            var shortestArray = Math.Min(firstArray.Length, secondArray.Length);
            var longestArray = Math.Max(firstArray.Length, secondArray.Length);

            var result = new long[longestArray];

            for (var i = 0; i < longestArray - 1; i++)
            {
                if (i == 0)
                {
                    result[i] = (firstArray[i] + secondArray[i]) % 10;
                }
                else if (i == shortestArray - 1)
                {
                    result[i] = (firstArray[i] + secondArray[i]) % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10;


                    result[i + 1] = (firstArray[i] + secondArray[i]) / 10;
                }
                else
                {
                    result[i] = ((firstArray.Length > i ? firstArray[i] : 0) +
                                 (secondArray.Length > i ? secondArray[i] : 0)) % 10 +
                                ((firstArray.Length > i ? firstArray[i - 1] : 0) +
                                 (secondArray.Length > i ? secondArray[i - 1] : 0)) / 10;
                }
            }

            result = result.Reverse().ToArray();
            var longLastResult = string.Empty;
            foreach (var item in result)
            {
                longLastResult += item;
            }

            return long.Parse(longLastResult);
        }

        private static void Main()
        {
            long[] firstNumberArray = {1, 6, 7, 3, 6};
            long[] secondNumberArray = {5, 3, 6, 8, 9, 0};

            Console.WriteLine(SumOfTwoVeryBigIntegers(firstNumberArray, secondNumberArray));
        }
    }

}