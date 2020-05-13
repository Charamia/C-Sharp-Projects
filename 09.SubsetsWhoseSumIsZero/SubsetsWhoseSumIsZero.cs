namespace _09.SubsetsWhoseSumIsZero
{

    using System;

    internal class SubsetsWhoseSumIsZero
    {
        private static void Main()
        {
            var arr = new int[5];
            var sum = 0;
            var sub = new int[arr.Length];
            var temporaryArray = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < arr.Length; i++)
            for (int j = i, col = 0; j < arr.Length; j++, col++)
            {
                temporaryArray += arr[j];
                if (temporaryArray == sum)
                {
                    var total = 0;
                    for (var k = 0; k < sub.Length; k++)
                    {
                        total += sub[k];
                        Console.WriteLine(sub[k] + " ");

                        if (total == sum)
                        {
                            Console.WriteLine("\n");
                            break;
                        }
                    }
                }

                if (temporaryArray > sum)
                {
                    Array.Clear(sub, 0, sub.Length);
                    temporaryArray = 0;
                    break;
                }
            }
        }
    }

}