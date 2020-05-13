namespace SearchingInString
{

    using System;

    internal class SearchingInString
    {
        private static void Main()
        {
            var str = "C# Programming Course";

            var index = str.IndexOf("C#"); // index = 0
            Console.WriteLine(index);

            index = str.IndexOf("Course"); // index = 15
            Console.WriteLine(index);

            //IndexOf is case-sensitive. -1 means not found
            index = str.IndexOf("COURSE"); // index = -1
            Console.WriteLine(index);

            //Case-insensitive IndexOf
            index = str.ToLower().IndexOf("COURSE".ToLower()); // 15
            Console.WriteLine(index);

            index = str.IndexOf("ram"); // index = 7
            Console.WriteLine(index);

            index = str.IndexOf("r"); // index = 4
            Console.WriteLine(index);

            index = str.IndexOf("r", 8); // index = 18
            Console.WriteLine(index);
        }
    }

}