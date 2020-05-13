namespace _9.WithinThecircleOutoftheRectangle
{

    using System;

    internal class StartUp
    {
        private static void Main()
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var circleRadius = 5;

            var pointCoordinates = x1 * x1 + y1 * y1 <= circleRadius * circleRadius;
            var outOfRectangle = (x1 < -1) & (x1 > -5) & (y1 < 1) & (y1 > -5);

            Console.WriteLine(
                $"The point is {(pointCoordinates && outOfRectangle ? "in the circle and out of the rectangle" : "out")}");
        }
    }

}