namespace _01.Hello
{

    using System;

    internal class Helllo
    {
        private static void Hello(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }

        private static void Main()
        {
            Hello("Eli");
        }
    }

}