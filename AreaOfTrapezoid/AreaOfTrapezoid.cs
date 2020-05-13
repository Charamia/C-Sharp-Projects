namespace AreaOfTrapezoid
{

    using System;

    internal class AreaOfTrapezoid
    {
        private static void Main()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var heightH = double.Parse(Console.ReadLine());

            var area = (sideA + sideB) / 2 * heightH;
            Console.WriteLine(area);
        }
    }

}