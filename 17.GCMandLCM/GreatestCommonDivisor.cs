namespace _17.GCMandLCM
{

    using System;

    internal class GreatestCommonDivisor
    {
        private static void Main()
        {
            Console.WriteLine("Enter your number1: ");
            var number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            var number2 = double.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                var temporaryNumber = number1;
                number1 = number2;
                number2 = temporaryNumber;
            }

            double result;
            double resultReminder = 0;
            double leastCommonMultiple;
            Console.WriteLine();

            while (true)
            {
                result = number1 / number2;
                resultReminder = number1 % number2;

                if (resultReminder != 0)
                {
                    number1 = number2;
                    number2 = resultReminder;
                    Console.WriteLine("{0} : {1} ={2} ; reaminder = {3}", number1, number2, result, resultReminder);
                }
                else
                {
                    Console.WriteLine("{0} : {1} = {2}; reminder = {3}", number1, number2, result, resultReminder);
                    Console.WriteLine("The Greatest Common Divisor is {0}", number2);
                    leastCommonMultiple = Math.Abs(number1 * number2) / number2;
                    Console.WriteLine("The Least Common Multiple is {0}", leastCommonMultiple);
                    break;
                }
            }
        }
    }

}