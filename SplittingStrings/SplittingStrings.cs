namespace SplittingStrings
{

    using System;

    internal class SplittingStrings
    {
        private static void Main()
        {
            var listofBeers = "Amstel, Zagorka, Tuborg, Becks.";
            var beers = listofBeers.Split(' ', ',', '.');

            //  char[] separators = new char[3] { ' ', ',', '.' }; or can be done as below

            beers = listofBeers.Split(new[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

            // string[] beers = listOfBeers.Split(
            //      new char[] {' ', ',', '.'},
            //StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Available beers are: ");
            foreach (var beer in beers)
                //Two sequential separators in the input cause
                //presence of empty element in the result
            {
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }
        }
    }

}