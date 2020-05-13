namespace ArraysDemo4Lists
{

    using System;
    using System.Collections.Generic;

    internal class ListsDemo
    {
        private static void Main()
        {
            var listOfStrings = new List<string>();
            string[] arrayofStrings = {"Pesho", "Ivan", "Dobri", "Gosho"};
            foreach (var str in arrayofStrings)
            {
                listOfStrings.Add(str);
            }

            Console.WriteLine("using\"foreach\" loop to transfer the List");
            Console.WriteLine(new string('-', 20));
            foreach (var str in listOfStrings)
            {
                Console.WriteLine(str);
                ;
            }

            listOfStrings.Sort();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("using\"for\" loop to transfer the List");
            Console.WriteLine(new string('-', 20));
            for (var i = 0; i < listOfStrings.Count; i++)
            {
                Console.WriteLine(listOfStrings[i]);
            }

            Console.WriteLine();
        }
    }

}