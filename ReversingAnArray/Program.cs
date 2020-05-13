namespace ReversingAnArray
{

    using System;

    internal class Program
    {
        private static void Main()

        {
            int[] array = {1, 2, 3, 4, 5};
            var length = array.Length;
            //Declare and create the reversed array
            var reversedArray = new int[length];

            //initialize the reversed array
            for (var index = 0; index < length; index++)
            {
                reversedArray[length - index - 1] = array[index];
            }

            //Print the reversed array
            for (var index = 0; index < length; index++)
            {
                Console.Write(reversedArray[index] + " ");
            }
        }
    }

}