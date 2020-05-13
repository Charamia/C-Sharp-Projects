namespace JaggedArrays
{

    using System;

    internal class JaggedArrays
    {
        private static void Main()
        {
            int[] numbers = {0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2};
            var sizes = new int[3];
            var offsets = new int[3];

            //Calculate the sizes for each reminder (0, 1 and 2)
            foreach (var number in numbers)
            {
                var reminder = number % 3;
                sizes[reminder]++;
            }

            //Calculate the list of numbers for each reminder ( 0, 1 and 2)
            var numbersOfZeroRemainders = sizes[0];
            var numbersOfOnereminders = sizes[1];
            var numbersOfTworeminders = sizes[2];

            var numbersByreminder = new int[3][]
            {
                new int[numbersOfZeroRemainders],
                new int[numbersOfOnereminders],
                new int[numbersOfTworeminders]
            };

            //OR 
            //int[][] numbersByreminder = new int[3][]
            //{
            //    new int[sizes[0]],
            //    new int[sizes[1]],
            //    new int[sizes[2]]
            //};

            foreach (var number in numbers)
            {
                var reminder = number % 3;
                var index = offsets[reminder];
                numbersByreminder[reminder][index] = number;
                offsets[reminder]++;
            }

            //Print the result jagged array
            for (var row = 0; row < numbersByreminder.GetLength(0); row++)
            {
                foreach (var num in numbersByreminder[row])
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }
    }

}