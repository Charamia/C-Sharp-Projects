namespace Thirdbit
{

    using System;

    internal class StartUp
    {
        private static void Main()
        {
            //int number = int.Parse(Console.ReadLine());
            //int bitPosition = 3;

            //int mask = 1 << bitPosition;
            //int numberAndMask = number & mask;
            //int bit = numberAndMask >> bitPosition;
            var num = int.Parse(Console.ReadLine());
            var bit3 = (num & 8) != 0;

            Console.WriteLine($"The third bit is {(bit3 ? "1" : "0")}");
        }
    }

}