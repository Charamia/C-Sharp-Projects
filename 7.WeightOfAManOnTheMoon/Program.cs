namespace _7.WeightOfAManOnTheMoon
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var weightOntheEarth = double.Parse(Console.ReadLine());

            var weightOfTheManOnTheMoon = weightOntheEarth * 0.17;

            Console.WriteLine(weightOfTheManOnTheMoon);
        }
    }

}