namespace _11.HowMany0esEnds
{

    using System;
    using System.Numerics;

    internal class HowMany0esEnds
    {
        private static void Main()
        {
            Console.WriteLine("Please enter positive number N: ");
            var numberN = long.Parse(Console.ReadLine());
            var counter = 0;
            BigInteger factorial = 1;
            BigInteger newNumber = 0;


            for (var i = 1; i <= numberN; i++)
            {
                factorial *= i;
            }

            //for (int i = 0; i <  factorial.ToString().Length; i++)
            //{
            //    if(factorial % 10 == 0)
            //    {
            //        factorial = factorial / 10;
            //        counter++;
            //        continue;
            //    }

            //    break;
            //}


            //do
            //{

            //}
            while (factorial % 10 == 0)
            {
                factorial = factorial / 10;
                counter++;
            }


            Console.WriteLine(counter);
        }
    }

}