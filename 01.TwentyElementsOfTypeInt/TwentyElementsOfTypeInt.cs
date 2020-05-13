namespace _01.TwentyElementsOfTypeInt
{

    using System;

    internal class TwentyElementsOfTypeInt
    {
        private static void Main()
        {
            var myArray = new int[20];

            for (var i = 0; i < 20; i++)
            {
                myArray[i] = i * 5;

                Console.Write(myArray[i] + " ");
            }
        }
    }

}