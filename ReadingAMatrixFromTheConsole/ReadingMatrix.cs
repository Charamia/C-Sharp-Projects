namespace ReadingAMatrixFromTheConsole
{

    using System;

    internal class ReadingMatrix
    {
        private static void Main()
        {
            //Reading a matrix from the console
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var matrix = new int[rows, cols];

            for (var row = 0; row < rows; row++)
            for (var col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }

            //printing matrix

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }

}