namespace WritingTextFiles
{

    using System;
    using System.IO;

    internal class WritingTextFiles
    {
        private static void Main()
        {
            var fileName = "numbers.txt";
            var streamWriter = new StreamWriter(fileName);
            Console.WriteLine("Loading...");

            using (streamWriter)
            {
                for (var number = 1; number <= 20; number++)
                {
                    streamWriter.WriteLine(number);
                }
            }

            Console.WriteLine("File is written!");
        }
    }

}