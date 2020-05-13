namespace LINQFirstDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqFirstProgram
    {
        private static void Main()
        {
            //The Linq First Method is used to return the first element from a data source. If the data source is empty, then this method will throw an exception. 
            //First has two overload methods.  The first overloaded version does not take any parameter and it simply returns the first element from the data source. 
            //The second overloaded version takes a predicate as a parameter using which we can specify a condition and then it will return the first element which satisfies the specified condition.
            //The First() method returns the first element of a collection, or the first element that satisfies the specified condition using lambda expression or Func delegate.

            IList<int> intList = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string> {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.First());

            Console.WriteLine("emptyList.First() throws an InvalidOperationException");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(emptyList.First());

            //The following example demonstrates FirstOrDefault()

            IList<int> intList1 = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList1 = new List<string> {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList1 = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList1.FirstOrDefault());

            Console.WriteLine("1st Even Element in intList: {0}", intList1.FirstOrDefault(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList1.FirstOrDefault());

            Console.WriteLine("1st Element in emptyList: {0}", emptyList1.FirstOrDefault());


            //We should be careful when specifying condition in First() or FirstOrdefault(). First() will throw an exception if a condition does not include any element that satisfies the specified 
            //condition or includes null element
            //If a collection includes null element then FirstOrDefault() throws an InvalidOperationException while evaluating the specified condition.

            IList<int> intList2 = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList2 = new List<string> {null, "Two", "Three", "Four", "Five"};

            Console.WriteLine("1st Element which is greater than 250 in intList: {0}", intList2.First(i => i > 250));

            //The following will throw an exception
            //Console.WriteLine("1st Even Element in intList: {0}", strList.FirstOrDefault(s => s.Contains("T")));

            //Note: For the reference types, the default is NULL and for the value types, the default depends on the actual type expected.

            /*
             * In the below example, we have two data sources. The first data source does not contain any item and here we are trying the fetch the first element. 
             * The second data source contains 10 elements from the number 1 to 10 and from this data source we are trying to retrieve the first element which is greater than 50.
             * Here it will print the values as 0 and 0. This is because the data source contains integers. And the default for integer is 0.
             * 
             * There aren't First or FirstOrDefault operators in query syntax, instead method and query syntax can be combined as below
             * 
             *      int QuerySyntax1 = (from num in numbers
                                select num).First();
                    int QuerySyntax2 = (from num in numbers
                                select num).FirstOrDefault();
                      Console.WriteLine(QuerySyntax1);
                      Console.WriteLine(QuerySyntax2);
             * 
             */
        }
    }

}