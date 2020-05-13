namespace CountingWordOccurences
{

    using System;
    using System.IO;

    internal class CountingWordOccurences
    {
        private static void Main()
        {
            var fileName = @"..\..\somefile.txt";
            var reader = new StreamReader(fileName);

            string text;
            using (reader)
            {
                text = reader.ReadToEnd();
            }

            var count = 0;
            var index = text.IndexOf("foundme", 0);
            while (index != -1)
            {
                count++;
                index = text.IndexOf("foundme", index + 1);
            }

            Console.WriteLine(count);
        }
    }

}