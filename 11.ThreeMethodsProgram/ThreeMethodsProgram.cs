/// <summary>
/// Write a program that solves the following tasks:
/// - Put the digits from an integer number into a reversed order.
/// - Calculate the average of given sequence of numbers.
/// - Solve the linear equation a* x + b = 0.
/// Create appropriate methods for each of the above tasks.
/// Make the program show a text menu to the user. By choosing an option
/// of that menu, the user will be able to choose which task to be invoked.
/// 348 Fundamentals of Computer Programming with C#
/// Perform validation of the input data:
/// - The integer number must be a positive in the range [1…50,000,000].
/// - The sequence of numbers cannot be empty.
/// - The coefficient a must be non-zero.
/// </summary>

namespace _11.ThreeMethodsProgram
{

    using System;

    internal class ThreeMethodsProgram
    {
        private static int ReverseNumber(int number)
        {
            var left = number;
            var rev = 0;
            while (left > 0)
            {
                var r = left % 10;
                rev = rev * 10 + r;
                left = left / 10; //left = Math.floor(left / 10); 
            }

            return rev;
        }


        private static decimal FindTheAverageOfSequenceOfIntigers(int[] arr)
        {
            var result = 0;
            decimal averageResult = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            averageResult = (decimal) result / arr.Length;

            return averageResult;
        }

        private static decimal SolveLinearEquation(decimal a, decimal b)
        {
            var equationResult = -(b / a);
            return equationResult;
        }

        private static void Main()
        {
            Console.WriteLine("Please choose one of the options below: \n1 - reverse \n2 - average \n3 - equation");

            var initialInput = int.Parse(Console.ReadLine());

            if (initialInput == 1)
            {
                Console.WriteLine("Please enter a positive number int the range [1...50,000,000]: ");
                var n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 50000000)
                {
                    Console.WriteLine("You have entered an invalid number!");
                }
                else
                {
                    Console.WriteLine("You have entered a valid numner!");
                    Console.WriteLine($"The reversed intiger number entred by you is:{ReverseNumber(n)}");
                }
            }
            else if (initialInput == 2)
            {
                Console.WriteLine("Please enter a number for the sequence length: ");
                var sequenceLength = int.Parse(Console.ReadLine());

                while (sequenceLength <= 0)
                {
                    Console.WriteLine("You have entered invalid sequence length number!");

                    Console.WriteLine(
                        "Please enter the length of the sequence of numbers, your number should be positive: ");
                    sequenceLength = int.Parse(Console.ReadLine());
                }


                var arr = new int[sequenceLength];
                for (var i = 0; i < sequenceLength; i++)
                {
                    Console.WriteLine("Please enter a number from your sequence: ");
                    var text = Console.ReadLine();
                    int number;

                    var isParsed = int.TryParse(text, out number);


                    while (isParsed = false)
                    {
                        Console.WriteLine("You have entered an invalid element!");

                        Console.WriteLine("Please enter a valid number: ");
                        text = Console.ReadLine();
                        number = arr[i];
                        isParsed = int.TryParse(text, out number);
                    }

                    arr[i] = number;
                }

                Console.WriteLine($"The average of the given sequence is: {FindTheAverageOfSequenceOfIntigers(arr)}");
            }
            else if (initialInput == 3)
            {
                Console.WriteLine("Please enter number a, which should not be zero: ");
                var a = int.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("You have entered invalid number for a!");

                    Console.WriteLine("Please enter again valid number for a: ");
                    a = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Please enter number b: ");
                var b = int.Parse(Console.ReadLine());

                Console.WriteLine(SolveLinearEquation(a, b));
            }
        }
    }

}