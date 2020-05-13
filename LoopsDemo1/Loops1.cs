namespace LoopsDemo1
{

    using System;

    internal class Loops1
    {
        private static void Main()
        {
            Console.Write("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());
            var counter = 0;

            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("End");
            ;
        }
    }

}