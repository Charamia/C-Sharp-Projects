namespace _13.FromBinaryToDecimal
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var binaryNumber = int.Parse(Console.ReadLine());
            var decimalNUmber = 0;
            var reminder = 1;
            var baseValue = 1;

            while (binaryNumber > 0)
            {
                reminder = binaryNumber % 10;
                decimalNUmber = decimalNUmber + reminder * baseValue;
                binaryNumber = binaryNumber / 10;

                baseValue = baseValue * 2;
            }


            Console.WriteLine(decimalNUmber);
        }
    }

}