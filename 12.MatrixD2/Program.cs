namespace _12.MatrixD2
{

    using System;

    internal class Program
    {
        private static int[,] matrix;

        private static void Main()
        {
            Console.Write("Enter a number: ");
            var n = int.Parse(Console.ReadLine());

            matrix = new int[n, n];
            var direction = "down";
            int row = -1, col = 0;

            for (var count = 1; count <= n * n; count++)
            {
                if (direction == "down")
                {
                    if (matrix[++row, col] == 0)
                    {
                        matrix[row, col] = count;
                    }

                    if (!IsTraversable(row + 1, col))
                    {
                        direction = "right";
                    }
                }
                else if (direction == "right")
                {
                    if (matrix[row, ++col] == 0)
                    {
                        matrix[row, col] = count;
                    }

                    if (!IsTraversable(row, col + 1))
                    {
                        direction = "up";
                    }
                }
                else if (direction == "up")
                {
                    if (matrix[--row, col] == 0)
                    {
                        matrix[row, col] = count;
                    }

                    if (!IsTraversable(row - 1, col))
                    {
                        direction = "left";
                    }
                }
                else if (direction == "left")
                {
                    if (matrix[row, --col] == 0)
                    {
                        matrix[row, col] = count;
                    }

                    if (!IsTraversable(row, col - 1))
                    {
                        direction = "down";
                    }
                }
            }

            // Prints matrix
            Console.WriteLine();
            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }

                Console.WriteLine("\n");
            }
        }

        private static bool IsTraversable(int row, int col)
        {
            return row >= 0 && row < matrix.GetLongLength(0) &&
                   col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
        }
    }

}