namespace _03.EnglishNameOfTheLastDigit
{

    using System;

    internal class EnglishNameOfTheLastDigit
    {
        private static void LastDigitInEnglish(int number)
        {
            var result = number % 10;
            switch (result)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
            }
        }

        private static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());

            LastDigitInEnglish(number);
        }
    }

}