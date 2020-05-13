namespace LoopsDemo10
{

    using System;

    internal class LoopsDemo10
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = 1;

            for (var i = 0; i < power; i++)
            {
                // continue shte propusne tekushtata stypka
                if (i == 5)
                {
                    continue;
                }

                result *= number;
            }

            Console.WriteLine(result);
        }
    }

}