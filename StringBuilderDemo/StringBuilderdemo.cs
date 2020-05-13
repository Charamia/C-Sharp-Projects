namespace StringBuilderDemo
{

    using System;
    using System.Text;

    internal class StringBuilderdemo
    {
        public static string ReverseIt(string s)
        {
            var sb = new StringBuilder();
            for (var i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        public static string ExtractCapitals(string s)
        {
            var result = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        public static string DupChar(char ch, int count)
        {
            var result = new StringBuilder(count);
            for (var i = 0; i < count; i++)
            {
                result.Append(ch);
            }

            return result.ToString();
        }

        private static void Main()
        {
            var s = "Telerik Academy";

            var reversed = ReverseIt(s);
            Console.WriteLine(reversed);

            var capitals = ExtractCapitals(s);
            Console.WriteLine(capitals);

            var startTime = DateTime.Now;
            Console.WriteLine("Concatenation 200 000 char...");
            ;
            DupChar('a', 200000);
            var endTime = DateTime.Now;
            Console.WriteLine("...done in {0} seconds", endTime - startTime);
        }
    }

}