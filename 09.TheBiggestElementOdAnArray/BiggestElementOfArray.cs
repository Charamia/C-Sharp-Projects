namespace _09.TheBiggestElementOdAnArray
{

    using System;

    internal class BiggestElementOfArray
    {
        private static int FindBiggestElement(int[] array)
        {
            var temporary = array[0];
            var biggestElement = array[0];

            for (var i = 0; i < array.Length - 1; i++)
            for (var j = i + 1; j < array.Length - 1; j++)
            {
                if (array[i] > array[j])
                {
                    if (biggestElement < array[i])
                        //int temp = array[i];
                        //array[i] = array[j];
                        //array[j] = temp;
                    {
                        biggestElement = array[i];
                    }
                }
            }

            return biggestElement;
        }

        private static int[] Sort(int[] array)
        {
            var result = new int[array.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = FindBiggestElement(array);

                for (var a = Array.IndexOf(array, result[i]); a < array.Length - 1; a++)
                    // moving elements downwards, to fill the gap at [index]
                {
                    array[a] = array[a + 1];
                }

                // finally, let's decrement Array's size by one
                Array.Resize(ref array, array.Length - 1);
            }

            return result;
        }

        private static void Main()
        {
            int[] arr = {5, 12, 59, 45, 64, 78, 32, 64, 12, 13, 8};
            var sorteDescendingOrder = new int[arr.Length];

            Console.Write("The biggest element of this given array is: ");
            Console.WriteLine(FindBiggestElement(arr));

            var result = Sort(arr);

            for (var i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }

}