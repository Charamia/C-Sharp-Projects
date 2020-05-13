namespace _08.SortingArray
{

    using System;

    internal class SortingArray
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
            int smallestElement;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                smallestElement = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallestElement])
                    {
                        smallestElement = j;
                    }
                }

                temporary = arr[smallestElement];
                arr[smallestElement] = arr[i];
                arr[i] = temporary;
            }

            Console.WriteLine("Here is the sorted array is:");
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

}