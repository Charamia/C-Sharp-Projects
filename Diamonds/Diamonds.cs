namespace Diamonds
{

    using System;

    internal class Diamonds
    {
        private static void Main()
        {
            //You will be given the size N for the top of the diamond and you must create it 
            //The width of the diamond must be N * 2 + 1
            //The height must be (6 +((N-3) / 2) * 3)
            //The diamond must have a line going vertically through its middle and a horizontal line where the top and the bottom parts connect.
            //Input : the input data should be read from the console
            //You should hava an integer N - the width of the top of the diamond
            //The input data will always be valid and in th eformat described. There is no need to check it explicitly.
            //The output should be printed on the console
            //Use "*"(star characters for the lines and "."(dot for the rest.
            //constarins: N will always be a positive number abetween 3 and 27 inclusive
            // Allowed working time for your program i: 0.1 seconds and allowed memory: 16MB

            var n = int.Parse(Console.ReadLine());

            var width = n * 2 + 1;
            var height = 6 + (n - 3) / 2 * 3;

            var topDots = (width - n) / 2;


            Console.Write(new string('.', topDots));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', topDots));

            var nextDots = topDots - 1;
            var topRows = topDots;

            for (var i = 0; i < topRows - 1; i++)
            {
                topDots--;
                Console.Write(new string('.', topDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.WriteLine(new string('.', topDots));


                nextDots++;
            }

            Console.WriteLine(new string('*', width));

            var firstDots = 1;

            for (var i = 0; i < n - 1; i++)
            {
                nextDots--;
                Console.Write(new string('.', firstDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.WriteLine(new string('.', firstDots));

                firstDots++;
            }

            Console.Write(new string('.', width / 2));
            Console.Write('*');
            Console.WriteLine(new string('.', width / 2));
        }
    }

}