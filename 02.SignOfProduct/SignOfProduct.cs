namespace _02.SignOfProduct
{

    using System;

    internal class SignOfProduct
    {
        private static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a * b * c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a * b * c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }

}