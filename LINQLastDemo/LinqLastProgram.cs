namespace LINQLastDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqLastProgram
    {
        private static void Main()
        {
            /*The Last Method in Linq is used to return the last element from a data source. There are two overloaded versions available for the Last method 
              The first overloaded version of the Last method does not take any parameter. It simply returns the last element from the data source and if the data source is empty then it throws an exception.
              The second overloaded version of the Last method takes a predicate as a parameter. Using this predicate we can specify a condition and then it returns the last element which satisfied the specified 
              condition. In this case, if no element satisfied the specified condition, then it will throw an exception.
              If the data source is empty or if no element is satisfied with the given condition, then it will throw the InvalidOperationException

                Note: the default is NULL for the reference types, and for the value types, the default value depends on the actual type expected.


             */


            IList<int> intList = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string> {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("Last Element in intList: {0}", intList.Last());
            Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

            Console.WriteLine("Last Element in strList: {0}", strList.Last());

            Console.WriteLine("emptyList.Last() throws an InvalidOperationException");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(emptyList.Last());

            IList<int> intList1 = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList1 = new List<string> {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList1 = new List<string>();

            Console.WriteLine("Last Element in intList: {0}", intList1.LastOrDefault());

            Console.WriteLine("Last Even Element in intList: {0}",
                intList1.LastOrDefault(i => i % 2 == 0));

            Console.WriteLine("Last Element in strList: {0}", strList1.LastOrDefault());

            Console.WriteLine("Last Element in emptyList: {0}", emptyList1.LastOrDefault());


            IList<int> intList3 = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList3 = new List<string> {null, "Two", "Three", "Four", "Five"};

            Console.WriteLine("Last Element which is greater than 250 in intList: {0}",
                intList3.Last(i => i > 250));

            //The following throws an exception
            //Console.WriteLine("Last Even Element in intList: {0}",  strList3.LastOrDefault(s => s.Contains("T")));
        }
    }

}