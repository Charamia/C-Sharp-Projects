namespace _07.GreatestOf5
{

    using System;

    internal class GreatestOf5
    {
        private static void Main()
        {
            //var chisla = new[] { 1, 4, 3, 2 };
            var chisla = new int[5];
            for (var i = 0; i < chisla.Length; i++)
            {
                chisla[i] = int.Parse(Console.ReadLine());
            }

            var maxInt = chisla[0];

            for (var i = 1; i < chisla.Length - 1; i++)
            for (var j = 2; j < chisla.Length - 1; j++)
            {
                if (chisla[i] > chisla[j])
                {
                    if (maxInt < chisla[i])
                    {
                        maxInt = chisla[i];
                    }
                }
            }

            Console.WriteLine($"Max number is {maxInt}");
        }
    }

}