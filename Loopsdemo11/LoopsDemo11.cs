namespace Loopsdemo11
{

    using System;

    internal class LoopsDemo11
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            for (var i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0) //or we can it without continue : (i % 7 != 0)
                {
                    continue;
                }

                sum += i;
            }

            Console.WriteLine(sum);
        }
    }

}