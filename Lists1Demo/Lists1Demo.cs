namespace Lists1Demo
{

    using System;
    using System.Collections.Generic;

    internal class Lists1Demo
    {
        private static void Main()
        {
            var listOfIntegers = new List<int>();
            var consoleLine = Console.ReadLine();
            var n = int.Parse(consoleLine);

            var lineBreak = new string('-', 20);

            for (var i = 0; i < n + 1; i++)
            {
                var capacity = listOfIntegers.Capacity;
                var count = listOfIntegers.Count;
                Console.WriteLine("Total Capacity of the List: {0}\nused:{1}\n{2})", capacity, count, lineBreak);
                listOfIntegers.Add(i);
            }
        }
    }

}