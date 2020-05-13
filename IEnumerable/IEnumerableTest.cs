namespace IEnumerable
{

    using System;
    using System.Collections.Generic;

    public class IEnumerableTest

    {
        public static void AddNumber(int number)
        {
            Console.WriteLine(number + 100);
        }

        public static void Main()
        {
            var enumerable = new List<int> {5, 10, 100};


            Console.WriteLine("Using slow way");
            foreach (var item in enumerable)
                // do something
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("using cool way");
            enumerable.ForEach(AddNumber);

            // the code below is anonymous function
            enumerable.ForEach(x => Console.WriteLine(x + 10000));
        }
    }

}