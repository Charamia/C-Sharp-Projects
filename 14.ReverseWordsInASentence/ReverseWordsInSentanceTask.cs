namespace _14.ReverseWordsInASentence
{

    using System;

    internal class ReverseWordsInSentanceTask
    {
        private static void Main()
        {
            var text = "C# is not C++, and PHP is not Delphi";

            var textInArray = text.Split(' ');

            Array.Reverse(textInArray);

            var result = string.Join(" ", textInArray);

            Console.WriteLine(result);
        }
    }

}