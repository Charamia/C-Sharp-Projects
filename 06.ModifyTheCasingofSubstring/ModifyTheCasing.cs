namespace _06.ModifyTheCasingofSubstring
{

    using System;

    internal class ModifyTheCasing
    {
        private static void Main()
        {
            var text =
                "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            var firstString = "<upcase>";
            var lastString = "</upcase>";

            while (text.IndexOf(firstString) > -1)
            {
                var indexOfFirstStringPosition = text.IndexOf(firstString);
                var indexOfLastStringposition = text.IndexOf(lastString);

                var stringBetween2Strings1 = text.Substring(indexOfFirstStringPosition,
                    indexOfLastStringposition - indexOfFirstStringPosition + lastString.Length);
                var modifiedString = stringBetween2Strings1.Replace(firstString, "").Replace(lastString, "").ToUpper();

                text = text.Replace(stringBetween2Strings1, modifiedString);
            }

            Console.WriteLine(text);
        }
    }

}