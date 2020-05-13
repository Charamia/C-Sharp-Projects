namespace LoopsDemo7
{

    using System;

    internal class LoopsDemo7
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            for (var i = 0; i <= n; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}