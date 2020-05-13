using System;



namespace _12._1._1MatrixA
{
    class MatrixA
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0, count = 1; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = count++;
                    Console.WriteLine();

                    Console.Write("{0,4} ", matrix[row, col]);
                   // Console.WriteLine("\n"); ;

                }
            }
        }
    }
}
