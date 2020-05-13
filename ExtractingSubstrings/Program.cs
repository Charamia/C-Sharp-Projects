namespace ExtractingSubstrings
{

    using System;
    using System.IO;

    internal class Program
    {
        private static string ExtractExtension(string fileName)
        {
            var extension = string.Empty;
            var dotIndex = fileName.LastIndexOf('.');
            if (dotIndex != -1)
            {
                extension = fileName.Substring(dotIndex + 1);
            }

            return extension;
        }

        private static string ExtractFileName(string path)
        {
            var dirSlash = Path.DirectorySeparatorChar;
            var slashIndex = path.LastIndexOf(dirSlash);
            var fileName = path.Substring(slashIndex + 1);
            return fileName;
        }

        private static string stringExtractPath(string fullFileName)
        {
            var dirSlash = Path.DirectorySeparatorChar;
            var slashIndex = fullFileName.LastIndexOf(dirSlash);
            var path = "";
            if (slashIndex != -1)
            {
                path = fullFileName.Substring(0, slashIndex);
            }

            return path;
        }

        private static void Main()
        {
            var fileName = @"C:\Pics\Rila2005.jpg";
            Console.WriteLine("Full file name: {0}", fileName);

            var pathOnly = stringExtractPath(fileName);
            Console.WriteLine("Path: {0}", pathOnly);

            var fileNameOnly = ExtractFileName(fileName);
            Console.WriteLine("File name only: {0}", fileNameOnly);

            var extension = ExtractExtension(fileName);
            Console.WriteLine("File extension: {0}", extension);
        }
    }

}