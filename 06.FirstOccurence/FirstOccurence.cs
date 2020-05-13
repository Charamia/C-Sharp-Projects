namespace _06.FirstOccurence
{

    using System;

    internal class FirstOccurence
    {
        private static int FirstOccurenceSearch(int[] givenArray)
        {
            for (var i = 0; i <= givenArray.Length - 1; i++)
            {
                if (i != 0 && i != givenArray.Length - 1)
                {
                    if (givenArray[i] > givenArray[i - 1] && givenArray[i] > givenArray[i + 1])
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private static void Main()
        {
            int[] givenArray = {8, 4, 1, 50, 98, 7, 6, 87, 1, 9, 12, 4, 7};

            Console.WriteLine(FirstOccurenceSearch(givenArray));
        }
    }

}