namespace QueueDemo
{

    using System;
    using System.Collections.Generic;

    internal class StartUp
    {
        private static void Main()
        {
            var gosho = new Queue<int>();

            gosho.Enqueue(1);
            gosho.Enqueue(0);

            var myValue = gosho.Dequeue();
            Console.WriteLine(myValue);

            Console.WriteLine(gosho.Dequeue());
        }
    }

}