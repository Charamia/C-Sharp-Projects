namespace _8.WithinTheCircle
{

    using System;

    internal class StartUp
    {
        private static void Main()
        {
            var pointX = int.Parse(Console.ReadLine());
            var pointY = int.Parse(Console.ReadLine());

            var circleRadius = 5;

            var pointCoordinates = pointX * pointX + pointY * pointY <= circleRadius * circleRadius;

            Console.WriteLine($"The point is {(pointCoordinates ? "in" : "out")}");
        }
    }

}