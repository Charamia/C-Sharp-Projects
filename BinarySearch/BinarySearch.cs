namespace BinarySearch
{

    using System;

    internal class BinarySearch
    {
        private static void Main()
        {
            string[] beers = {"Zagorka", "Ariana", "Shumensko", "Astika", "Kamenitza", "Bolyarka", "Amstel"};

            Array.Sort(beers);
            var target = "Astika";
            var index = Array.BinarySearch(beers, target);
            Console.WriteLine("{0} is found at index {1}.", target, index);
            //Result: Astika is found at index 2.

            target = "Heineken";
            index = Array.BinarySearch(beers, target);
            Console.WriteLine("{0} is not found (index = {1}).", target, index);
            //Result: Heineken is not found (index = -5).

            //load test
            var line = Console.ReadLine();
            var n = int.Parse(line);
            var array = new byte[n];

            for (var i = 0; i < n; i++)
            {
                array[i] = (byte) (i % byte.MaxValue);
            }

            Array.Sort(array);
        }
    }

}