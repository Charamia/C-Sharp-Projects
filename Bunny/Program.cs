namespace Bunny
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var boing = new AirCraft();
            boing.Fuel = 100M;

            var battleCruiser = new AirCraft();

            //Console.WriteLine(boing.Fuel);
            //Console.WriteLine(battleCruiser.Fuel);

            boing.Move();
            //Console.WriteLine(AirCraft.Weight);

            //Console.WriteLine(NumeralSystem.ToDecimal(15M, 2));

            var pt = new Point();
            pt.X = 5;
            pt.Y = 10;

            var secondPoint = new Point(0, 0, 0);

            secondPoint.Add(1, 2, 3);

            Console.WriteLine(secondPoint.X);

            Point.Calculate(pt, secondPoint);
        }
    }

}