namespace PeremeterAndAreaOfACircle
{

    using System;

    internal class PeremeterAreaOfACircle
    {
        private static void Main()
        {
            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = Math.PI * Math.Pow(radius, 2);
            var perimeterOfCircle = 2 * Math.PI * radius;

            Console.WriteLine("The area of a circle with radius {0} is {1:F2}", radius, areaOfCircle);
            Console.WriteLine("The perimeter of a circle with radius {0} is {1:F2}", radius, perimeterOfCircle);
        }
    }

}