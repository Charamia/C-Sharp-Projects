namespace ArraysDemo2
{

    using System;

    internal class Arraysdemo2
    {
        private static void Main()
        {
            Console.Write("Number of elements = ");
            var size = int.Parse(Console.ReadLine());

            var array = new int[size];

            for (var i = 0; i < size; i++)
            {
                Console.WriteLine("arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            var isSymethric = true;
            for (var i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[size - i - 1])
                {
                    isSymethric = false;
                    break;
                }
            }

            Console.WriteLine("Symmetric? --> {0}", isSymethric);
        }
    }

}