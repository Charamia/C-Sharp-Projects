namespace LoopsDemo4
{

    using System;

    internal class LoopsDemo4
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var isPrime = true;
            var devider = 2;

            while (devider < n)
            {
                if (n % devider == 0)
                {
                    isPrime = false;
                    break;
                }

                devider++;
            }

            Console.WriteLine("{0} is prime: {1}", n, isPrime);
        }
    }

}