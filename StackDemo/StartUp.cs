namespace StackDemo
{

    using System;
    using System.Collections.Generic;

    internal class StartUp
    {
        private static void Main()
        {
            var pesho = new Stack<int>();

            pesho.Push(1);
            pesho.Push(2);
            pesho.Push(3);
            pesho.Push(4);


            Console.WriteLine(pesho.Peek());

            Console.WriteLine(pesho.Pop());

            Console.WriteLine(pesho.Peek());

            var intArray = pesho.ToArray();

            Console.WriteLine(pesho.Peek());

            pesho.Clear();
        }
    }

}