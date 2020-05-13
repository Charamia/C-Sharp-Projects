namespace _10.MostFrequentlyOccuring
{

    using System;

    /// <summary>
    ///     Defines the <see cref="MostFrequentlyOccuring" />.
    /// </summary>
    internal class MostFrequentlyOccuring
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            int[] inputArray = {1, 2, 3, 4};

            var counter = 1;
            var maxCounter = 0;
            var minValue = 0;


            for (var i = 0; i <= inputArray.Length - 1; i++)
            {
                for (var j = i + 1; j <= inputArray.Length - 1; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        minValue = inputArray[i];
                        counter++;

                        if (maxCounter <= counter)
                        {
                            maxCounter = counter;
                        }
                    }
                }

                counter = 1;
            }

            if (maxCounter == 0 && inputArray.Length > 0)
                //maxCounter = 1;
            {
                Console.WriteLine("All numbers occure only 1 time in the array");
            }
            else
            {
                Console.WriteLine("{0} ({1} times)", minValue, maxCounter);
            }
        }
    }

}