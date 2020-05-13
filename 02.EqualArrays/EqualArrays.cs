namespace _02.EqualArrays
{

    using System;

    internal class EqualArrays
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array1 = new int[n];

            var k = int.Parse(Console.ReadLine());
            var array2 = new int[k];

            for (var i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (var j = 0; j < k; j++)
            {
                array2[j] = int.Parse(Console.ReadLine());
            }

            if (array1.Length == array2.Length)
            {
                for (var r = 0; r < n; r++)
                {
                    if (array1[r] != array2[r])
                    {
                        Console.WriteLine("These two arrays are not equal.");
                        break;
                    }

                    if (array1[r] == array2[r])
                    {
                        Console.WriteLine("These two arrays are equal.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("These two arrays are not equal.");
            }
        }
    }

}