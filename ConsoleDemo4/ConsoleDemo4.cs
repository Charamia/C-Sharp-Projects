namespace ConsoleDemo4
{

    using System;
    using System.Text;

    internal class ConsoleDemo4
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Здрасти");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("They are green!");
        }
    }

}