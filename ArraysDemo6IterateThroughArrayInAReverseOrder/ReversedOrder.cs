namespace ArraysDemo6IterateThroughArrayInAReverseOrder
{

    using System;

    internal class ReversedOrder
    {
        private static void Main()
        {
            int[] array = {1, 2, 3, 4, 5};

            Console.Write("Reversed: ");
            for (var index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }
    }

}