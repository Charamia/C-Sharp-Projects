namespace GreatestOf5
{

    using System;

    internal class GreatestOf5
    {
        private static void Main()
        {
            Console.WriteLine("Please enter your first number:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your third number:");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your fourth number:");
            var d = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your fifth number:");
            var e = int.Parse(Console.ReadLine());


            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The greatest number is {0}", a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The greatest number is {0}", b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("The greatest number is {0}", c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("The greatest number is {0}", d);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine("The greatest number is {0}", e);
            }
        }
    }

}