namespace _08._1.DecreasingSortedArray
{

    using System;

    internal class DecreasingSortedArray
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (var i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temporary;
            int biggestElement;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                biggestElement = i;
                for (var j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[biggestElement])
                    {
                        biggestElement = j;
                    }
                }

                temporary = arr[biggestElement];
                arr[biggestElement] = arr[i];
                arr[i] = temporary;
            }

            Console.WriteLine("Here is the sorted array:");
            for (var i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

}