namespace _03.ParanthesesPlacedCorrectly
{

    using System;

    internal class ParanthesesCheck
    {
        private static string CheckBrackets(string text)
        {
            var openingParantheses = '(';
            var closingParantheses = ')';
            var counter = 0;
            var result = string.Empty;

            for (var i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                if (ch == openingParantheses)
                {
                    counter++;
                }
                else if (ch == closingParantheses)
                {
                    counter--;
                }

                if (counter < 0)
                {
                    return "Parantheses are placed incorrectly";
                }
            }

            if (counter == 0)
            {
                result = "Parantheses are placed correctly!";
            }

            return "Parantheses are placed incorrectly";
        }

        private static void Main()
        {
            var text = "((a+b)/5-d))(.";
            Console.WriteLine(CheckBrackets(text));
        }
    }

}