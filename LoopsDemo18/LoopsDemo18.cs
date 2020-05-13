namespace LoopsDemo18
{

    using System;

    internal class LoopsDemo18
    {
        private static void Main()
        {
            for (var a = 0; a < 10; a++)
            for (var b = 0; b < 10; b++)
            for (var c = 0; c < 10; c++)
            {
                var d = a + b - c;
                if (d < 10)
                {
                    Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                }
            }
        }
    }

}