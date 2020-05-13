namespace ReadinfTextFiles
{

    using System;
    using System.IO;

    internal class ReadingTextFiles
    {
        private static void Main()
        {
            var fileName = @"..\..\ReadingTextFiles.cs";
            Console.WriteLine("The contents of the file {0} is: ", fileName);

            var streamReader = new StreamReader(fileName);

            using (streamReader)
            {
                var fileContents = streamReader.ReadToEnd();
                Console.WriteLine(fileContents);
            }

            Console.WriteLine("\n\nNow line by line:");

            var reader = new StreamReader(fileName);
            using (reader)
            {
                var lineNumber = 0;
                var line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }

}