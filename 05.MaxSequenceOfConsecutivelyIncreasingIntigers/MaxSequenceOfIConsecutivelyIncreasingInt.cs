namespace _05.MaxSequenceOfConsecutivelyIncreasingIntigers
{

    using System;
    using System.Collections.Generic;

    internal class MaxSequenceOfIConsecutivelyIncreasingInt
    {
        private static void Main()
        {
            var inputList = new List<int> {3, 2, 3, 4, 3, 2, 2, 4};
            var outputList = new List<int>();
            var spareList = new List<int>();

            for (var i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] < inputList[i + 1])
                {
                    spareList.Add(inputList[i]);

                    for (var j = i; j < inputList.Count - 1; j++)
                    {
                        if (inputList[j] < inputList[j + 1])
                        {
                            spareList.Add(inputList[j + 1]);
                            continue;
                        }

                        break;
                    }

                    if (outputList.Count < spareList.Count)
                    {
                        outputList = new List<int>(spareList);
                    }

                    spareList = new List<int>();
                }
            }

            foreach (var item in outputList)
            {
                Console.WriteLine(item);
            }
        }
    }

}