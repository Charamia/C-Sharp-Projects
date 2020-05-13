namespace MethodsDemo1
{

    using System;

    internal class MethodsDemo1
    {
        private static void PrintFirstTenNumbers()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        private static void Main()
        {
            PrintSign(-7);
            PrintTheSumOfFiveAndSix(7, 9);
        }

        private static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("+");
            }
            else if (number < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void PrintTheSumOfFiveAndSix(int firstNUmber, int secondNumber)
        {
            Console.WriteLine("Sum: " + (firstNUmber + secondNumber));
        }
    }

}