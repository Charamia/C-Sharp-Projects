namespace LoopsDemo15
{

    using System;

    internal class LoopsDemo15
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var row = 0; row <= n; row++)
            {
                for (var col = 0; col <= row; col++)
                {
                    Console.Write('*' + " ");
                }

                Console.WriteLine();
            }
        }
    }

}