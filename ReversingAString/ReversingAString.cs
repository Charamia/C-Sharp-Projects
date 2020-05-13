namespace ReversingAString
{

    using System;

    internal class ReversingAString
    {
        private static void Main()
        {
            var result = Console.ReadLine();
            var officialResult = string.Empty;


            for (var i = result.Length - 1; i >= 0; i--)
            {
                officialResult += result[i];
            }


            Console.WriteLine(officialResult);
        }
    }

}