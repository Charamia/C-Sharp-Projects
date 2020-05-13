namespace ArrayDemo1
{

    using System;

    internal class ArrayDemo1
    {
        private static void Main()
        {
            int[] array = {1, 2, 3, 4, 5};

            var length = array.Length;

            var reversed = new int[length];

            for (var index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }

            for (var index = 0; index < length; index++)
            {
                Console.WriteLine(reversed[index]);
            }
        }
    }

}