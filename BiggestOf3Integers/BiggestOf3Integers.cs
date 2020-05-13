namespace BiggestOf3Integers
{

    using System;

    internal class BiggestOf3Integers
    {
        private static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The biggest number is {0}", a);
                }
                else if (a < c)
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }
            else if (a < b)
            {
                if (a < c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("The biggest number is {0}", b);
                    }
                    else if (b < c)
                    {
                        Console.WriteLine("The biggest number is {0}", c);
                    }
                }
            }
        }
    }

}