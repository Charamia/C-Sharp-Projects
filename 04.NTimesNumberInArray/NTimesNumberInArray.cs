namespace _04.NTimesNumberInArray
{

    using System;

    internal class NTimesNumberInArray
    {
        private static void FindNumberNTimesInArray(int[] array, int number)
        {
            var counter = 0;
            for (var i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }


        private static void Main()
        {
            int[] givenArray = {3, 5, 3, 7, 23, 9, 0, 4, 7, 8, 2, 5, 6, 3, 5};
            var number = int.Parse(Console.ReadLine());


            FindNumberNTimesInArray(givenArray, number);
        }
    }

}