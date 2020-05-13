namespace _12._1._3MatrixC
{

    using System;

    internal class MatrixC
    {
        private static void Main()
        {
            var n = 4;
            var matrix = new int[n, n];

            var count = 1;

            for (var row = n - 1; count <= n * n; row--)
            {
                var _row = row >= 0 ? row : 0;

                var _col = row >= 0 ? 0 : Math.Abs(row);

                var countTo = n - (row >= 0 ? row : 0);

                for (var col = _col; col < countTo; col++)
                {
                    matrix[_row++, col] = count++;
                }
            }


            //    Console.Write("Enter a number: ");
            //    int n = int.Parse(Console.ReadLine());

            //    int[,] matrix = new int[n, n];
            //    int[] arr = new int[n * n];

            //    for (int i = 1; i <= n * n; i++)
            //    {
            //        arr[i - 1] = i;
            //    }

            //    int index = 0;

            //    for (int row = n - 1; row < n; row--)
            //    {
            //        if (row >= 0)
            //        {
            //            for (int col = 0; col < n; col++)
            //            {
            //                if (col == n - row - 1)
            //                {
            //                    matrix[row, col] = arr[index];


            //                    index++;
            //                }
            //                else
            //                {
            //                    row--;
            //                    matrix[row, col -1] = arr[index];
            //                    index++;

            //                    row++;
            //                }
            //            }
            //        }
            //    }
            //    for (int row = 0; row < n; row++)
            //    {
            //        for (int col = 0; col < n; col++)
            //        {
            //            Console.Write(matrix[row, col] + " ");
            //        }
            //        Console.WriteLine();
            //    }
        }
    }

}