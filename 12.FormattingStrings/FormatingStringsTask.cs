namespace _12.FormattingStrings
{

    using System;

    internal class FormatingStringsTask
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:0.00} - 15-character field, aligned right", number);
            Console.WriteLine("{0,15:C2} - currency", number);
            Console.WriteLine("{0,15:X} - hexadecimal ", number);
            Console.WriteLine("{0,15:P0} - percentage ", number);
            Console.WriteLine("{0,15:E} - exponential ", number);
            Console.WriteLine();
        }
    }

}