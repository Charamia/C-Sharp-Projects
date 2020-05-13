namespace ArraysDemo3
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            int[] normalArray = {1, 2, 3, 4, 5};

            Console.WriteLine("Reversed: ");
            ;
            for (var i = normalArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(normalArray[i] + " ");
            }
        }
    }

}