namespace _06.QuadraticEquationRoots
{

    using System;

    internal class QuadraticEquationRoots
    {
        private static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant == 0)
            {
                var root = -b / (2 * a);
                Console.WriteLine("The equation has one double real root, which is {0:F2}", root);
            }
            else if (discriminant > 0)
            {
                var root1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                var root2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("The equation has two real roots, which are {0:F2}, {1:F2}", root1, root2);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
        }
    }

}