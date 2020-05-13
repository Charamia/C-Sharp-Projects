namespace _04.SplitByBackslash
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var text = @"Whether\ the\ date\ will be parsed\ successfully and in what format " +
                       @"exactly it will be printed on the console\ depends strongly/ on the current culture of Windows. ";

            char[] separator = {'\\'};

            var results = text.Split(separator);


            foreach (var result in results)
            {
                if (result != "")
                {
                    Console.WriteLine(result);
                }
            }
        }
    }

}