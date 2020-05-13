namespace ConsoleDemo1
{

    using System;

    internal class ConsoleDemo
    {
        private static void Main()
        {
            Console.Write("Please enterinteger: ");


            var inputNumber = int.Parse(Console.ReadLine());

            var result = inputNumber + 1;

            Console.Write("Your result is: ");
            ;
            Console.WriteLine(result);
        }
    }

}