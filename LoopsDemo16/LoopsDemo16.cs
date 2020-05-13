namespace LoopsDemo16
{

    using System;

    internal class LoopsDemo16
    {
        private static void Main()
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            for (var i = min; i <= max; i++)
            {
                var divider = 2;
                var isPrime = true;

                while (divider < i)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    divider++;
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}