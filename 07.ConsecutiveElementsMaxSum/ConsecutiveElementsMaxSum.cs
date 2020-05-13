namespace _07.ConsecutiveElementsMaxSum
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ConsecutiveElementsMaxSum
    {
        private static void Main()
        {
            Console.WriteLine("Please enter your N number");
            var nNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your K number, bear in mind that K < N");
            var kNumber = int.Parse(Console.ReadLine());
            //int sum = 0;
            var maximalSum = 0;


            var array = new int[nNumber];
            var kConsecutiveElementsMaxSum = new List<int>();
            var temporarySum = new List<int>();

            for (var i = 0; i < nNumber; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            if (kNumber < nNumber)
            {
                for (var i = 0; i <= array.Length - kNumber; i++)
                {
                    for (var j = 0; j < kNumber; j++)
                        //sum += array[i + j];
                    {
                        temporarySum.Add(array[i + j]);
                    }

                    //if(maximalSum < sum) 
                    if (maximalSum < temporarySum.Sum())
                        //  maximalSum = sum;
                    {
                        kConsecutiveElementsMaxSum = temporarySum;
                    }

                    //sum = 0;
                    temporarySum = new List<int>();
                }
            }

            foreach (var item in kConsecutiveElementsMaxSum)
            {
                Console.WriteLine(item);
            }
        }
    }

}