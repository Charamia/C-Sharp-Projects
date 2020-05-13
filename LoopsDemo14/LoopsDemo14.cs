namespace LoopsDemo14
{

    using System;

    internal class LoopsDemo14
    {
        private static void Main()
        {
            for (var i = 0; i < 10; i++)
            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine(i + j);
            }
        }
    }

}