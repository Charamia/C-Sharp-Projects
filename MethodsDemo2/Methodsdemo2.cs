namespace MethodsDemo2
{

    using System;

    internal class Methodsdemo2
    {
        private static void ChangeNumber(int number)
        {
            number += 100;
        }

        private static void Main()
        {
            var number = 5;
            ChangeNumber(number);
            Console.WriteLine(number);

            var numbers = new int[5];
            numbers[0] = 10;

            ChangeArray(numbers);

            Console.WriteLine(numbers[0]);
        }

        private static void ChangeArray(int[] array)
        {
            array[0] = 100;
        }
    }

}