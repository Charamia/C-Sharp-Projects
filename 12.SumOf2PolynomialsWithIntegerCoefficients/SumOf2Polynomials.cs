namespace _12.SumOf2PolynomialsWithIntegerCoefficients
{

    using System;

    internal class SumOf2Polynomials
    {
        private static void Main()
        {
            decimal[] firstPolynomial = EnterPolynomial(out firstPolynomial);
            Console.Write("Polynomial in normal form:");
            PrintPolynomial(firstPolynomial);

            Console.WriteLine();

            decimal[] secondPolynomial = EnterPolynomial(out secondPolynomial);
            Console.Write("Polynomial in normal form:");
            PrintPolynomial(secondPolynomial);

            Аccumulation(firstPolynomial, secondPolynomial);
            Subtraction(firstPolynomial, secondPolynomial);
            Multiplication(firstPolynomial, secondPolynomial);
        }

        private static decimal[] EnterPolynomial(out decimal[] polynomial)
        {
            Console.Write("Enter your polynomial degree: ");
            var degree = byte.Parse(Console.ReadLine());

            polynomial = new decimal[degree + 1];

            for (var i = polynomial.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                polynomial[i] = decimal.Parse(Console.ReadLine());
            }

            return polynomial;
        }

        private static void Аccumulation(decimal[] first, decimal[] second)
        {
            Console.WriteLine("\n" + new string('-', 40) + "\n");
            PrintPolynomial(first);
            Console.WriteLine("   +");
            PrintPolynomial(second);
            Console.WriteLine("   =");

            var lengthBigger = Math.Max(first.Length, second.Length);
            var isFirstBigger = first.Length >= second.Length ? true : false;
            var isSecondBigger = !isFirstBigger;
            var isPolynomialZero = true;

            var result = new decimal[lengthBigger];

            for (var i = 0; i < lengthBigger; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    result[i] = first[i] + second[i];
                    if (result[i] != 0)
                    {
                        isPolynomialZero = false;
                    }
                }
                else if (isFirstBigger)
                {
                    result[i] = first[i];
                }
                else if (isSecondBigger)
                {
                    result[i] = second[i];
                }
            }

            if (isPolynomialZero)
            {
                Console.Write("     0\n");
            }
            else
            {
                PrintPolynomial(result);
            }
        }

        private static void Subtraction(decimal[] first, decimal[] second)
        {
            Console.WriteLine("\n" + new string('-', 40) + "\n");
            PrintPolynomial(first);
            Console.WriteLine("   -");
            PrintPolynomial(second);
            Console.WriteLine("   =");

            var lengthBigger = Math.Max(first.Length, second.Length);
            var isFirstBigger = first.Length >= second.Length ? true : false;
            var isSecondBigger = !isFirstBigger;
            var isPolynomialZero = true;

            var result = new decimal[lengthBigger];

            for (var i = 0; i < lengthBigger; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    result[i] = first[i] - second[i];
                    if (result[i] != 0)
                    {
                        isPolynomialZero = false;
                    }
                }
                else if (isFirstBigger)
                {
                    result[i] = first[i];
                }
                else if (isSecondBigger)
                {
                    result[i] = -second[i];
                }
            }

            if (isPolynomialZero)
            {
                Console.Write("     0\n");
            }
            else
            {
                PrintPolynomial(result);
            }
        }

        private static void Multiplication(decimal[] first, decimal[] second)
        {
            Console.WriteLine("\n" + new string('-', 40) + "\n");
            PrintPolynomial(first);
            Console.WriteLine("   *");
            PrintPolynomial(second);
            Console.WriteLine("   =");

            var result = new decimal[first.Length + second.Length - 1];

            for (var i = 0; i < first.Length; i++)
            for (var j = 0; j < second.Length; j++)
            {
                result[i + j] += first[i] * second[j];
            }

            PrintPolynomial(result);

            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }

        // Prints polynomial in normal form -> good looking
        private static void PrintPolynomial(decimal[] polynomial)
        {
            for (var i = polynomial.Length - 1; i >= 0; i--)
            {
                if (i == polynomial.Length - 1 && polynomial[i] != 0)
                {
                    Console.Write("     {0}{1}x^{2} ", polynomial[i] > 0 ? "" : "-", Math.Abs(polynomial[i]), i);
                }
                else if (i == 0)
                {
                    if (polynomial[i] < 0)
                    {
                        Console.Write("{0}{1} ", "- ", -polynomial[i]);
                    }
                    else if (polynomial[i] > 0)
                    {
                        Console.Write("{0}{1} ", "+ ", polynomial[i]);
                    }
                }
                else
                {
                    if (polynomial[i] < 0)
                    {
                        Console.Write("{0}{1}x^{2} ", "- ", -polynomial[i], i);
                    }
                    else if (polynomial[i] > 0)
                    {
                        Console.Write("{0}{1}x^{2} ", "+ ", polynomial[i], i);
                    }
                }
            }

            Console.WriteLine();
        }
    }

}