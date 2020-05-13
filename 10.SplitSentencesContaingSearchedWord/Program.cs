namespace _10.SplitSentencesContaingSearchedWord
{

    using System;

    internal class Program
    {
        private static string[] SeparateSentances(string text)
        {
            var sentenceSeparator = '.';

            var sentences = text.Split(sentenceSeparator);

            return sentences;
        }


        private static void Main()
        {
            var text =
                @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            var sentences = SeparateSentances(text);
            var searchedWord = " in ";
            var results = new string[sentences.Length];


            foreach (var sentence in sentences)
            {
                if (sentence.Contains(searchedWord))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }

}