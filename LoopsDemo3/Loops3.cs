namespace Лоопс3
{

    using System;

    internal class Loops3
    {
        private static void Main()
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = min;

            while (counter <= max)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }

}