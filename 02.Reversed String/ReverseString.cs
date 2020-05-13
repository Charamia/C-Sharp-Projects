namespace _02.Reversed_String
{

    using System;
    using System.Text;

    internal class ReverseString
    {
        private static string ReverseText(string text)
        {
            var sb = new StringBuilder();

            for (var i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        private static void Main()
        {
            var text = "introduction";
            Console.WriteLine(ReverseText(text));
        }
    }

}