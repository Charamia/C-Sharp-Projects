namespace MethodsDemo6
{

    using System;

    internal class MethodsDemo6
    {
        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static void Main()
        {
            var result = Sum(1, 2);
            var anotherResult = Sum(2, 3);

            Console.WriteLine(result);
            Console.WriteLine(anotherResult);
        }
    }

}