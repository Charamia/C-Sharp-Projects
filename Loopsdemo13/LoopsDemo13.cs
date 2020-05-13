namespace Loopsdemo13
{

    using System;

    internal class LoopsDemo13
    {
        private static void Main()
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thirsday",
                "Friday"
            };

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }

}