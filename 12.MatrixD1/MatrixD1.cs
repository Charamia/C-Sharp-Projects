namespace _12.MatrixD1
{

    using System;

    internal class MatrixD1
    {
        private static void Main()

        {
            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];

            var positionX = 0;
            var positionY = 0;

            var direction = 0;
            var stepCount = n;
            var stepPosition = 0;
            var stepChange = 0;

            var counter = 1;

            for (var i = 0; i < n * n; i++)
            {
                matrix[positionY, positionX] = counter;
                counter++;

                if (stepPosition < stepCount) // Check for direction/step changes
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepCount--;
                    }

                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }

                switch (direction) // Move to the next cell in the current direction
                {
                    case 0:
                        positionY++;
                        break;
                    case 1:
                        positionX++;
                        break;
                    case 2:
                        positionY--;
                        break;
                    case 3:
                        positionX--;
                        break;
                }
            }

            for (var j = 0; j < n; j++)
            {
                for (var k = 0; k < n; k++)
                {
                    Console.Write("{0,3}", matrix[j, k]);
                }

                Console.WriteLine();
            }
        }
    }

}