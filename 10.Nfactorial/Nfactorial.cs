namespace _10.Nfactorial
{

    using System;
    using System.Numerics;

    internal class Nfactorial
    {
        private static BigInteger[] FindFactorial(int[] arr)
        {
            var result = new BigInteger[arr.Length];


            for (var i = 0; i <= arr.Length - 1; i++)
            {
                if (i == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = result[i - 1] * arr[i];
                }
            }

            return result;
        }

        private static void Main()
        {
            var arr = new int[100];

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            //  Console.WriteLine(arr[i] + " ");

            var result = FindFactorial(arr);

            for (var j = 0; j < result.Length; j++)
            {
                Console.WriteLine(result[j] + " ");
            }
        }
    }

}