namespace BitTrueOrFalse
{

    using System;

    internal class BitTrueOrFalse
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var bitPosition = int.Parse(Console.ReadLine());
            var i = 1;

            var mask = i << bitPosition;
            var numberAndMask = number & mask;


            Console.WriteLine($"{((number & mask) != 0 ? "True" : "False")}");

            //Console.WriteLine( ($"The third bit is {(bit3 ? "1" : "0")}");
        }
    }

}