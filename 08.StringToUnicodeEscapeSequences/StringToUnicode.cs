namespace _08.StringToUnicodeEscapeSequences
{

    using System;
    using System.Text;

    internal class StringToUnicode
    {
        private static string ToUnicodeString(string text)
        {
            var sb = new StringBuilder();

            foreach (var item in text)
            {
                sb.Append("\\u" + ((int) item).ToString("x4"));
            }

            return sb.ToString();
        }

        private static void Main()
        {
            Console.WriteLine("Please enter a string: ");
            var text = Console.ReadLine();
            Console.WriteLine(ToUnicodeString(text));
        }
    }

}