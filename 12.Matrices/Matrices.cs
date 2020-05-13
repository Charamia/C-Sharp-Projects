namespace _12.Matrices
{

    using System;

    internal class Matrices
    {
        private static void Main()
        {
            Console.Write("N =  ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n * n];

            for (var i = 1; i <= n * n; i++)
            {
                arr[i - 1] = i;
            }

            var matrix = new int[n, n];


            //This for will go through the rows of our matrix
            for (var rows = 0; rows < n; rows++)
            {
                matrix[rows, 0] = arr[rows];

                Console.Write(matrix[rows, 0] + " ");

                var colsCounter = 1; // colCount is 1 because I have to fill 

                for (var cols = rows; cols <= n * n; cols = cols + n)
                {
                    matrix[rows, colsCounter] = arr[cols + n];

                    Console.Write(matrix[rows, colsCounter] + " ");

                    colsCounter++;

                    if (n == colsCounter)
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }
        }
    }

}