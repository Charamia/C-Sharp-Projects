namespace PlatformWithMaximalSum
{

    using System;

    internal class PlatformWithMaximalSum
    {
        private static void Main()
        {
            Console.Write("Enter the number of the rows ");
            var rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the cols ");
            var cols = int.Parse(Console.ReadLine());

            var matrix = new int[rows, cols];
            //int[,] matrix =
            //{
            //    {0, 2, 4, 0, 9, 5},
            //    {7, 1, 3, 3, 2, 1},
            //    {4, 6, 7, 9, 1, 0},
            //    {4, 6, 7, 9, 1, 0},
            //};

            var bestSum = long.MinValue;
            var bestRow = 0;
            var bestCol = 0;

            Console.WriteLine("Enter the cells of the matrix: ");


            for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
            {
                Console.Write("matrix[{0},{1}] =  ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }

                // Console.Write("{0,4)", matrix[row, col]);
                Console.WriteLine();
            }

            for (var row = 0; row < matrix.GetLength(0) - 2; row++)
            for (var col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                           matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                           matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
            //Print the result

            Console.WriteLine("The best platform with size of (3, 3) with a maximal sum is: ");
            Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1],
                matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1],
                matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1],
                matrix[bestRow + 2, bestCol + 2]);

            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }

}