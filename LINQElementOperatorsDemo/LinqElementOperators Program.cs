namespace LINQElementOperatorsDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            //The Element Operators in Linq are used to return a single element from a data source using the element index or based on a predicate i.e. a condition. 
            //These Element Operators can be used with a single data source or on a query of multiple data sources.

            /*If you want to perform the following operations, then you need to use the Element Operators:

                1. Select the First record from a data source.
                2. Fetch a specific record from the data source.
                3. Select the last record from a data source.
             * 
             * The following methods are provided by Linq to perform element operations.

                    1. ElementAt and ElementAtOrDefault
                    2. First and FirstOrDefault
                    3. Last and LastOrDefault
                    4. Single and SingleOrDefault
                    5. DefaultIfEmpty
                    
             The ElementAt operator is used to return an element from a specific index. If the data source is empty or if the provided index value is out of range, then we will get 
             ArgumentOutOfRangeException. 
             This method takes one parameter i.e. the index position. Then it will return the element present in that index position of the data source. There is no overloaded
             version available for ElementAt method.

             Note: If the data source is empty or if you specify a negative value for the index position or if you specify the index position which is out of range then you will get 
             a runtime exception.

             If you don’t want that exception then you need to use the ElementAtOrDefault method.

            The ElementAtOrDefault method does the same thing as the ElementAt method except that the first method doesn't throw an exception when the data source is empty or when
            the supplied index value is out of range. In such cases, it will return the default value based on the data type of the element the data source contain.
             */


            IList<int> intList = new List<int> {10, 21, 30, 45, 50, 87};

            IList<string> strList = new List<string> {"One", null, "Three", "Four", "Five"};


            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

            Console.WriteLine("10th Element in intList: {0} - default int value", intList.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in strList: {0} - default string value (null)",
                strList.ElementAtOrDefault(9));


            Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(intList.ElementAt(9));

            //As we can see in the above example, intList.ElementAtOrDefault(9) returns 0 (default value of int range) 
            //because intList does not include10th element. However intList.ElementAt(9) throws "Index out of range" exception.
            //The same way, strList.ElementAtOrDefault(9) returns null which is default value of string type. (console display empty space because it cannot display null)
            //it is advisable to use ElementAtOrDefault extention method to eliminate the possibility of a runtime exception
        }
    }

}