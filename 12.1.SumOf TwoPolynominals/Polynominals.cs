/*
* 11.Write a method that calculates the sum of two polynomials with integer
*       coefficients, for example (3x2 + x - 3) + (x - 1) = (3x2 + 2x - 4).
*       Represent them as arrays of their coefficients as in the example below:
*       x2 + 5 = 1x2 + 0x + 5 -> |5| |0| |1|
* 
* 12. Write a method that calculates the product of two polynomials with
*       integer coefficients, for example (3x2 + x - 3) * (x - 1) = (3x3 -
*       2x2 - 4x + 3).*       Extend the program to support also subtraction of polynomials.
*/


namespace _12._1.SumOf_TwoPolynominals
{

    using System;

    internal class Polynominals
    {
        private static decimal[] EnterPolynominal(out decimal[] polynominal)
        {
            Console.Write("Enter your polynominal degree: ");
            var degree = int.Parse(Console.ReadLine());

            polynominal = new decimal[degree + 1];

            for (var i = polynominal.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                polynominal[i] = decimal.Parse(Console.ReadLine());
            }

            return polynominal;
        }

        private static void SumTwoPolynominals(decimal[] firstPolynominal, decimal[] secondPolynominal)
        {
            Console.WriteLine("\n" + new string('-', 45) + "\n");
            PrintPolynominal(firstPolynominal);
            Console.WriteLine(" +");
            PrintPolynominal(secondPolynominal);
            Console.WriteLine(" =");

            var biggerLength = Math.Max(firstPolynominal.Length, secondPolynominal.Length);
            var isFirstLonger = firstPolynominal.Length >= secondPolynominal.Length ? true : false;
            var isSecondLonger = !isFirstLonger;
            var isPolynominalZero = true;

            var result = new decimal[biggerLength];

            for (var i = 0; i < biggerLength; i++)
            {
                if (i < firstPolynominal.Length && i < secondPolynominal.Length)
                {
                    result[i] = firstPolynominal[i] + secondPolynominal[i];
                    if (result[i] != 0)
                    {
                        isPolynominalZero = false;
                    }
                }
                else if (isFirstLonger)
                {
                    result[i] = firstPolynominal[i];
                }
                else if (isSecondLonger)
                {
                    result[i] = secondPolynominal[i];
                }
            }

            if (isPolynominalZero)
            {
                Console.Write("     0\n");
            }
            else
            {
                PrintPolynominal(result);
            }
        }

        private static void PrintPolynominal(decimal[] polynominal)
        {
            for (var i = polynominal.Length - 1; i >= 0; i--)
            {
                if (i == polynominal.Length - 1 && polynominal[i] != 0)
                {
                    Console.Write("         {0}{1}x^{2}", polynominal[i] > 0 ? "" : "-", Math.Abs(polynominal[i]), i);
                }
                else if (i == 0)
                {
                    if (polynominal[i] < 0)
                    {
                        Console.Write("{0}{1} ", " - ", -polynominal[i]);
                    }
                    else if (polynominal[i] > 0)
                    {
                        Console.Write("{0}{1} ", "+ ", polynominal[i]);
                    }
                }
                else
                {
                    if (polynominal[i] < 0)
                    {
                        Console.Write("{0}{1}x^{2} ", " - ", -polynominal[i], i);
                    }
                    else if (polynominal[i] > 0)
                    {
                        Console.Write("{0}{1}x^{2} ", " + ", polynominal[i], i);
                    }
                }
            }

            Console.WriteLine();
        }

        private static void MultiplicationOfTwoPolynominals(decimal[] firstPolynominal, decimal[] secondPolynominal)
        {
            Console.WriteLine("\n" + new string('-', 45) + "\n");
            PrintPolynominal(firstPolynominal);
            Console.WriteLine(" *");
            PrintPolynominal(secondPolynominal);
            Console.WriteLine(" =");

            var result = new decimal[firstPolynominal.Length + secondPolynominal.Length - 1];

            for (var i = 0; i < firstPolynominal.Length; i++)
            for (var j = 0; j < secondPolynominal.Length; j++)
            {
                result[i + j] += firstPolynominal[i] * secondPolynominal[j];
            }

            PrintPolynominal(result);
            Console.WriteLine("\n" + new string('-', 45) + "\n");
        }

        private static void Subtraction(decimal[] firstPolynominal, decimal[] secondPolynominal)
        {
            PrintPolynominal(firstPolynominal);
            Console.WriteLine("   -");
            PrintPolynominal(secondPolynominal);
            Console.WriteLine("   =");

            var biggerLength = Math.Max(firstPolynominal.Length, secondPolynominal.Length);
            var isFirstPolynominalBigger = firstPolynominal.Length >= secondPolynominal.Length ? true : false;
            var isSecondPolynominalBigger = !isFirstPolynominalBigger;
            var isPolynominalZero = true;

            var result = new decimal[biggerLength];

            for (var i = 0; i < biggerLength; i++)
            {
                if (i < firstPolynominal.Length && i < secondPolynominal.Length)
                {
                    result[i] = firstPolynominal[i] - secondPolynominal[i];
                    if (result[i] != 0)
                    {
                        isPolynominalZero = false;
                    }
                }
                else if (isFirstPolynominalBigger)
                {
                    result[i] = firstPolynominal[i];
                }
                else if (isSecondPolynominalBigger)
                {
                    result[i] = -secondPolynominal[i];
                }
            }

            if (isPolynominalZero)
            {
                Console.Write("     0\n");
            }
            else
            {
                PrintPolynominal(result);
            }

            Console.WriteLine("\n" + new string('-', 45) + "\n");
        }

        private static void Main()
        {
            decimal[] firstPolynominal = EnterPolynominal(out firstPolynominal);
            Console.Write("Polynominal in normal form: ");
            PrintPolynominal(firstPolynominal);

            Console.WriteLine();

            decimal[] secondPolynominal = EnterPolynominal(out secondPolynominal);
            Console.Write("Polynominal in normal form: ");
            PrintPolynominal(secondPolynominal);

            SumTwoPolynominals(firstPolynominal, secondPolynominal);
            MultiplicationOfTwoPolynominals(firstPolynominal, secondPolynominal);
            Subtraction(firstPolynominal, secondPolynominal);
        }
    }

}