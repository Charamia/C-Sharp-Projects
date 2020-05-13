namespace SlowBuildingStrings
{

    using System;

    internal class SlowBuildingStrings
    {
        public static string DupChar(char ch, int count)
        {
            var result = "";
            for (var i = 0; i < count; i++)
            {
                result += ch;
            }

            return result;
        }

        private static void Main()
        {
            var startTime = DateTime.Now;
            Console.WriteLine("Conacatenation 50 000 chars...");
            DupChar('a', 50000);
            var endTime = DateTime.Now;
            Console.WriteLine("... done in {0} seconds", endTime - startTime);

            startTime = DateTime.Now;
            Console.WriteLine("Concatenation 200 000 chars...");
            DupChar('a', 200000);
        }
    }

}