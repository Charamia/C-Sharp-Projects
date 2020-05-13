namespace LoopsDemo5
{

    using System;
    using System.Numerics;

    internal class LoopsDemo5
    {
        private static void Main()
        {
            // 5! = 5*4*3*2*1
            BigInteger n = int.Parse(Console.ReadLine());
            BigInteger product = 1;

            while (n > 0)
            {
                product *= n;
                n--;
            }

            Console.WriteLine(product);
        }
    }

}