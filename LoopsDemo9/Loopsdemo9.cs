namespace LoopsDemo9
{

    using System;

    internal class LoopsDemo9
    {
        private static void Main()
        {
            // 2 ^ 3 = 2*2*2
            //3 ^ 4 = 3*3*3*3

            //Math.Pow is slower than a for loop

            var number = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = 1;

            for (var i = 0; i < power; i++)
            {
                result *= number;
            }

            Console.WriteLine(result);
        }
    }

}