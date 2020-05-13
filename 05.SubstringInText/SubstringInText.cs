namespace _05.SubstringInText
{

    using System;

    internal class SubstringInText
    {
        private static int FindString(string text)
        {
            var textTolower = text.ToLower();
            var searchedKeyword = "in";

            var index = textTolower.IndexOf(searchedKeyword);
            var numberOfTimesStringContainedInTheText = 0;

            while (index != -1)
            {
                numberOfTimesStringContainedInTheText++;
                index = textTolower.IndexOf(searchedKeyword, index + 1);
            }

            return numberOfTimesStringContainedInTheText;
        }

        private static void Main()
        {
            var text =
                "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
            var searchedKeyword = "in";

            Console.WriteLine($"The string {0} appears {FindString(text)} times in the text.", searchedKeyword);
        }
    }

}