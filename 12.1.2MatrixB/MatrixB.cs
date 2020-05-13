namespace _12._1._2MatrixB
{

    using System;

    internal class MatrixB
    {
        private static void Main()
        {
            Console.Write("Enter a number: ");
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];
            var arr = new int[n * n];

            for (var i = 1; i <= n * n; i++)
            {
                arr[i - 1] = i;
            }


            var index = 0;

            for (var col = 0; col < n; col++)
            {
                var down = col % 2 == 0;
                if (down)
                {
                    for (var i = 0; i < n; i++)
                    {
                        matrix[i, col] = arr[index];
                        index++;
                    }
                }
                else
                {
                    for (var i = n - 1; i >= 0; i--)
                    {
                        matrix[i, col] = arr[index];
                        index++;
                    }
                }
            }

            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }

}