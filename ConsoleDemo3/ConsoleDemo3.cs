namespace ConsoleDemo3
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var text = Console.ReadLine();
            int number;

            var isParsed = int.TryParse(text, out number);

            //string result = isParsed ? "Valid" : "Invalid";

            //Console.WriteLine(result);

            if (isParsed)
            {
                Console.WriteLine("Number is: {0}", number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }

}