namespace ExtenssionMethods2
{

    using System;

    internal class EM2program
    {
        private static void Main()
        {
            var sentence = "Welcome to dotnet Tutorials";

            var wordCount = sentence.GetWordCount();

            Console.WriteLine($"Count: {wordCount}");
        }
    }

}