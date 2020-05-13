namespace LINQSingleDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LINQSingleProgram
    {
        private static void Main()
        {
            /*
             * The Linq Single Method is used to returns a single element from a data source or you can say from a sequence. There are two overloaded versions available for this Linq Single Method
             * The first overloaded version of the Single method does not take any parameter. This method simply returns the only element from a sequence. If the data source is empty or if the data 
             * source contains more than one element, then it throws an exception.
             * On the other hand, the second overloaded version of the Single method takes one predicate as a parameter and using this predicate you can specify a condition. 
             * This method returns the only element from the sequence which satisfies the given condition. In this case, the method will throw an exception when any of the following condition is true.

                    1. If the data source is empty.
                    2. When the given condition does not satisfy any element in the sequence.
                    3. If the given condition satisfies more than one element.
             */

            IList<int> oneElementList = new List<int> {7};
            IList<int> intList = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string> {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.SingleOrDefault());

            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            Console.WriteLine("The only element which is less than 10 in intList: {0}", intList.Single(i => i < 10));

            //Followings throw an exception
            //Console.WriteLine("The only Element in intList: {0}", intList.Single());
            //Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());
            //Console.WriteLine("The only Element in emptyList: {0}", emptyList.Single());

            //The following example code throws an exception because Single() or SingleOrDefault() returns none or multiple elements for the specified condition

            IList<int> oneElementList1 = new List<int> {7};
            IList<int> intList1 = new List<int> {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList1 = new List<string> {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList1 = new List<string>();

            //following throws error because list contains more than one element which is less than 100
            Console.WriteLine("Element less than 100 in intList: {0}", intList1.Single(i => i < 100));


            //following throws error because list contains more than one element which is less than 100
            Console.WriteLine("Element less than 100 in intList: {0}", intList1.SingleOrDefault(i => i < 100));

            //following throws error because list contains more than one elements
            Console.WriteLine("The only Element in intList: {0}", intList1.Single());

            //following throws error because list contains more than one elements
            Console.WriteLine("The only Element in intList: {0}", intList1.SingleOrDefault());

            //following throws error because list does not contains any element
            Console.WriteLine("The only Element in emptyList: {0}", emptyList1.Single());

            /*
             * Single() expects one and only one element in the collection.
             * Single() throws an exception when it gets no element or more than one elements in the collection.
             * If specified a condition in Single() and result contains no element or more than one elements then it throws an exception.
             * SingleOrDefault() will return default value of a data type of generic collection if there is no elements in a colection or for the specified condition
             * SingleOrDefault() will not  throw an exception if there is more than one elements in a colection or for the specified condition.
             * 
            */
        }
    }

}