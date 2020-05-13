namespace LoopDemo6
{

    using System;

    internal class LoopsDemo6
    {
        private static void Main()
        {
            Console.WriteLine("Please enter min: ");
            var min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter max: ");
            var max = int.Parse(Console.ReadLine());

            var product = 1;
            var counter = min;

            do
            {
                product *= counter;
                counter++;
            } while (counter <= max);

            Console.WriteLine("Product is {0}", product);
        }
    }

}