namespace ForbiddenWords
{

    using System;
    using System.Text.RegularExpressions;

    internal class ForbiddenWordsTask
    {
        private static string[] SeparateWordsInArray(string text)
        {
            var separator = ',';
            var forbiddenWordsInArray = text.Split(separator);

            return forbiddenWordsInArray;
        }

        private static void Main()
        {
            var text =
                @"Microsoft announced its next generation C2 compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            var forbiddenWords = "C2,CLR,Microsoft";

            var forbiddenWordsInArray = SeparateWordsInArray(forbiddenWords);

            var regex = string.Format(@"\b({0})\b", string.Join("|", forbiddenWordsInArray));

            Console.WriteLine("Result: \n\n{0}\n", Regex.Replace(text, regex, word => new string('*', word.Length)));

            //foreach (string word in forbiddenWordsInArray)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }

}