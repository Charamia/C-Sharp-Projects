namespace _10.MatrixAndPositivInteger
{

    using System;

    internal class MatrixAndPositiveInteger
    {
        private static void Main()
        {
            Console.WriteLine("Please enter a number N: ");
            var numberN = int.Parse(Console.ReadLine());

            for (var row = 1; row <= numberN; row++)
            {
                for (var col = row; col <= row + numberN - 1; col++)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }
        }
    }

}