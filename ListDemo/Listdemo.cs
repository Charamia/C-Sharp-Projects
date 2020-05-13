namespace ListDemo
{

    using System;
    using System.Collections.Generic;

    internal class Listdemo
    {
        private static void Main()
        {
            var list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Count);

            list.Remove(0);
        }
    }

}