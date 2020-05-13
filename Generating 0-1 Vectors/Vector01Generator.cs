namespace Generating_0_1_Vectors
{

    using System;

    internal class Vector01Generator
    {
        private static void Gen01(int index, int[] vector)
        {
            if (index == -1)
            {
                Print(vector);
            }
            else
            {
                for (var i = 1; i >= 0; i--) //(int i = 0; i <= 0; i++)
                {
                    vector[index] = i;
                    Gen01(index - 1, vector);
                }
            }
        }

        private static void Print(int[] vector)
        {
            foreach (var i in vector)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }

        private static void Main()
        {
            Console.Write("n = ");
            var number = int.Parse(Console.ReadLine());

            var vector = new int[number];

            Gen01(number - 1, vector);
        }
    }

}