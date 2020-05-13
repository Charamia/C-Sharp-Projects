namespace ArraysDemo5Iteraton
{

    using System;

    internal class IterationOfAnArray
    {
        private static void Main()
        {
            int[] array = {1, 2, 3, 4, 5};

            Console.Write("Output: ");
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = 2 * array[index];
                Console.Write(array[index] + " ");
            }
        }
    }

}