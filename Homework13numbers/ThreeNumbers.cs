namespace Homework13numbers
{

    using System;

    internal class ThreeNumbers
    {
        private static void Main()
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(number1 + number2 + number3);
        }
    }

}