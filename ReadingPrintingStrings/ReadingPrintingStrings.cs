namespace ReadingPrintingStrings
{

    using System;

    internal class ReadingPrintingStrings
    {
        private static void Main()
        {
            string[] towns =
            {
                "Sofia", "Varna", "Plovdiv", "Pleven", "Bourgas", "Rousse", "Stara Zagora", "Veliko Tarnovo", "Yambol",
                "sliven"
            };

            var firstTown = towns[0];
            for (var i = 0; i < towns.Length; i++)
            {
                var currentTown = towns[i];
                if (string.Compare(currentTown, firstTown) < 0)
                {
                    firstTown = currentTown;
                }
            }

            Console.WriteLine("First town: {0}", firstTown);
        }
    }

}