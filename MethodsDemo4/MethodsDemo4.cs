namespace MethodsDemo4
{

    using System;

    internal class MethodsDemo4
    {
        private static void Print(int max)
        {
            for (var col = 1; col <= max; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }


        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var row = 1; row <= n; row++)
                //for (int col = 1; col <= row; col++)
                //{
                //    Console.Write(col + " ");
                //}

                //Console.WriteLine();
            {
                Print(row);
            }

            for (var row = 1; row < n; row++)
                //for (int col = 1; col <= n - row; col++)
                //{
                //    Console.Write(col + " ");
                //}
                //Console.WriteLine();
            {
                Print(n - row);
            }
        }
    }

}