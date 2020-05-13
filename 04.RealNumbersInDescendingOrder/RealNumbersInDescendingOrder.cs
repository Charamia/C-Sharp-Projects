namespace _04.RealNumbersInDescendingOrder
{

    using System;

    internal class RealNumbersInDescendingOrder
    {
        private static void Main()
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            if (number1 >= number2)
            {
                if (number1 >= number3 && number2 >= number3)
                {
                    Console.WriteLine("{0} {1} {2}", number1, number2, number3);
                }
                else if (number1 >= number3 && number3 >= number2)
                {
                    Console.WriteLine("{0} {1} {2}", number1, number3, number2);
                }
                else if (number1 <= number3)
                {
                    Console.WriteLine("{0} {1} {2}", number3, number1, number2);
                }
            }
            else if (number1 <= number2)
            {
                if (number2 >= number3 && number3 >= number1)
                {
                    Console.WriteLine("{0} {1} {2}", number2, number3, number1);
                }
                else if (number3 >= number2)
                {
                    Console.WriteLine("{0} {1} {2}", number3, number2, number1);
                }
                else if (number2 >= number3 && number3 <= number1)
                {
                    Console.WriteLine("{0} {1} {2}", number2, number1, number3);
                }
            }
        }
    }

}