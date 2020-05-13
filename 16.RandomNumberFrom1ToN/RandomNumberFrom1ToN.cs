namespace _16.RandomNumberFrom1ToN
{

    using System;

    internal class RandomNumberFrom1ToN
    {
        private static void Main()
        {
            var numberN = int.Parse(Console.ReadLine());


            var array = new int[numberN];


            for (var i = 1; i <= array.Length - 1; i++)
            {
                array[i] = i;
            }

            var sluchaen = new Random();
            for (var j = 1; j < numberN; j++)
            {
                var randomIndex = sluchaen.Next(1, numberN);
                var temporary = array[randomIndex];
                array[randomIndex] = array[j];
                array[j] = temporary;
            }

            Console.WriteLine("Random numbers: " + string.Join(" ", array));
        }
    }

}