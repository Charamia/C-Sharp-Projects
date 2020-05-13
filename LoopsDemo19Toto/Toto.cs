namespace LoopsDemo19Toto
{

    using System;

    internal class Toto
    {
        private static void Main()
        {
            var counter = 0;

            for (var i = 1; i < 44; i++)
            for (var j = i + 1; j < 45; j++)
            for (var k = j + 1; k < 46; k++)
            for (var l = k + 1; l < 47; l++)
            for (var m = l + 1; m < 48; m++)
            for (var n = m + 1; n < 49; n++)
                //Console.WriteLine(i + " " + j + " " + k + " " + l + " " + m + " " + n);
            {
                counter++;
            }

            Console.WriteLine(counter);
        }
    }

}