namespace _04.MaximumSequenceOfConsecutiveEqualElements
{

    using System;

    internal class MaximumSequence
    {
        private static void Main()
        {
            var input = new[] {1, 2, 1, 1, 1, 1, 1, 7, 7, 7, 7, 7};

            var sequence = 0;
            var maxConsecutiveElements = 0;
            var consecutiveElements = 1;

            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    for (var j = i + 1; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            consecutiveElements++;
                            continue;
                        }

                        break;
                    }

                    if (maxConsecutiveElements <= consecutiveElements)
                    {
                        maxConsecutiveElements = consecutiveElements;
                        sequence++;
                    }

                    consecutiveElements = 1;
                }
            }

            Console.WriteLine($"Max lenght {maxConsecutiveElements}");
            Console.WriteLine($"Many times {sequence}");
        }
    }

}