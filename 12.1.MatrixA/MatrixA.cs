namespace _12._1.MatrixA
{

    using System;

    internal class MatrixA
    {
        private static void Main()
        {
            /*
* 1. Write a program that fills and prints a matrix of size (n, n) as shown below:
* (examples for n = 4)
* 
* 1  5   9  13
* 2  6  10  14
* 3  7  11  15
* 4  8  12  16
* 
*/

            Console.Write("Enter a number: ");
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0, count = 1; row < n; row++)
            for (var col = 0; col < n; col++)
            {
                matrix[col, row] = count++;
            }

            // Prints matrix
            Console.WriteLine();
            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }

                Console.WriteLine("\n");
            }
        }
    }

}