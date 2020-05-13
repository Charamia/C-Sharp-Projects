namespace _07.StringLength20
{

    using System;

    internal class CheckStringLength
    {
        private static void Main()
        {
            var text = Console.ReadLine();

            if (text.Length < 20)
            {
                var string20Length = text.PadRight(20, '*');
                Console.WriteLine(string20Length);
            }
            else
            {
                Console.WriteLine("This string \"{0}\" has length {1}", text, text.Length);
            }
        }
    }

}