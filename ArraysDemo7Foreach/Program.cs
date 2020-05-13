namespace ArraysDemo7Foreach
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            string[] capitals = {"Sofia", "Washington", "London", "Paris"};

            foreach (var capital in capitals)
            {
                Console.WriteLine(capital);
            }
        }
    }

}