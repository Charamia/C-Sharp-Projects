namespace MaximalPlatform
{

    using System;

    internal class MaximalPlatform
    {
        private static void Main()
        {
            //Declare and initialize the matrix
            int[,] matrix =
            {
                {0, 2, 4, 0, 9, 5},
                {7, 1, 3, 3, 2, 1},
                {4, 6, 7, 9, 1, 0},
                {4, 6, 7, 9, 1, 0}
            };

            //Find the maximal sum platform of size 2 x 2

            var bestSum = int.MinValue;
            var bestRow = 0;
            var bestCol = 0;
            for (var row = 0; row < matrix.GetLength(0) - 1; row++)
            for (var col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                var sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }

            // Print the result 

            Console.WriteLine("The bets platform is: ");
            Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            Console.WriteLine(" {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
            Console.WriteLine("The maximal sum is {0}", bestSum);
        }
    }

}