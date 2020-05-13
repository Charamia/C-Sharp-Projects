namespace LoopsDemo2
{

    using System;

    internal class LoopsDemo2
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 1;

            while (counter <= n)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }

}