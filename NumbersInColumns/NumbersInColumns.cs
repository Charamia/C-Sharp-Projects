namespace NumbersInColumns
{

    using System;

    internal class NumbersInColumns
    {
        private static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var thirdNumber = double.Parse(Console.ReadLine());


            var formatedText = "{0, -30} {1, -40:F2} {2, -50:F2}";

            Console.WriteLine(formatedText, firstNumber.ToString("X"), secondNumber, thirdNumber);

            //Console.WriteLine("|0x{0,-8:X|", firstnumber);
            //Console.WriteLine("|0,10:F2}|", secondNumber);
        }
    }

}