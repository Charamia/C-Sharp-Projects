namespace MathodsDemo7
{

    using System;

    internal class MethodsDemo7
    {
        private static bool ArePositive(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void Main()
        {
            int[] numbers = {1, 2, 3, -4, 5};
            Console.WriteLine(ArePositive(numbers));
        }
    }

}