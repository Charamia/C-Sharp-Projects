namespace _06.MaxSequenceOfIncreasingElements
{

    using System;

    internal class MaxSequenceOfIncreasingElements
    {
        private static void Main()
        {
            int[] arr = {9, 6, 2, 7, 4, 7, 6, 5, 8, 4};

            var len = new int[arr.Length];

            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    for (var j = i; j < arr.Length - 1; j++)
                    {
                        if (arr[j] < arr[j + 1] && arr[j - 1] < arr[j])
                        {
                            len[j] = arr[j];
                            continue;
                        }

                        break;
                    }
                }

                Console.WriteLine("\nThe maximum sequence if Increasing elemnts are: ");
                for (var k = 0; k < len.Length; k++)
                {
                    Console.WriteLine("{0} ", len[k]);
                }

                Console.WriteLine("\n");
            }
        }
    }

}