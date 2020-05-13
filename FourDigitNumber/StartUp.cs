namespace FourDigitNumber
{

    using System;

    internal class StartUp
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var firstNumber = number / 1000 % 10;
            var secondNumber = number / 100 % 10;
            var thirdNumber = number / 10 % 10;
            var fourthNumber = number % 10;

            Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("{0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
        }
    }

}