namespace _6.RectanglePerimeterAndArea
{

    using System;

    internal class StartUp
    {
        private static void Main()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            var perimeter = 2 * (sideA + sideB);
            var area = sideA * sideB;
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        }
    }

}