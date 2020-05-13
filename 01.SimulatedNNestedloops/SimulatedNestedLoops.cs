/*
 * 1. Write a recursive program that simulates the 
 * execution of n nested loops from 1 to n. 
 * 
 * Examples:
 *                            1 1 1
 *                            1 1 2
 *                            1 1 3
 *          1 1               1 2 1
 * n=2  ->  1 2      n=3  ->  ...
 *          2 1               3 2 3
 *          2 2               3 3 1
 *                            3 3 2
 *                            3 3 3 
 */


namespace _01.SimulatedNNestedloops
{

    using System;

    internal class SimulatedNestedLoops
    {
        private static void Loops(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (var element in arr)
                {
                    Console.Write("{0} ", element);
                }

                Console.WriteLine();
            }
            else
            {
                for (var i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Loops(arr, index + 1);
                }
            }
        }

        private static void Main()
        {
            Console.Write("Enter N: ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            Loops(arr, 0);
        }
    }

}