namespace _05.GreaterThanItsTwoNeighbours
{

    using System;

    internal class GreaterTHanNeighbours
    {
        private static bool GreaterThenTwoNeighours(int[] array, int index)
        {
            var greatherThanNeighours = true;

            if (index == 0)
            {
                greatherThanNeighours = array[0] > array[1];
            }
            else if (index == array.Length - 1)
            {
                greatherThanNeighours = array[index - 1] < array[index];
            }
            else
            {
                greatherThanNeighours = array[index] > array[index - 1] && array[index] > array[index + 1];
            }

            return greatherThanNeighours;
        }

        private static void Main()
        {
            int[] givenArray = {8, 9, 1, 50, 98, 7, 6, 87, 1, 9, 12, 4, 7};

            var index = int.Parse(Console.ReadLine());

            Console.WriteLine(GreaterThenTwoNeighours(givenArray, index));
        }
    }

}