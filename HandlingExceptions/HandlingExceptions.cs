namespace HandlingExceptions
{

    using System;
    using System.IO;

    internal class HandlingExceptions
    {
        private static void Main()
        {
            var fileName = "someFile.txt";
            //string fileName = @"somedir\somefile.txt";

            try
            {
                var reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully open.", fileName);
                Console.WriteLine("File contents");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not open the file {0} due to I/O error.", fileName);
            }
        }
    }

}