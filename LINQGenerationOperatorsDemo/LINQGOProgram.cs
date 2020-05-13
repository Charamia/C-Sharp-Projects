namespace LINQGenerationOperatorsDemo
{

    using System;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LINQGOProgram
    {
        private static void Main()
        {
            //LINQ includes generation operators DefaultIfEmpty, Empty, Range & Repeat. The Empty, Range & Repeat methods are not extension methods for IEnumerable or IQueryable
            //but they are simply static methods defined in a static class Enumerable.

            /*
             * The Empty() method is not an extension method of IEnumerable or IQueryable like other LINQ methods. It is a static method included in Enumerable static class.
             * So, you can call it the same way as other static methods like Enumerable.Empty<TResult>(). The Empty() method returns an empty collection of a specified type as shown below.
             * 
             */

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Type: {0}", emptyCollection1.GetType().Name);
            Console.WriteLine("Count: {0}", emptyCollection1.Count());

            Console.WriteLine("Type: {0}", emptyCollection2.GetType().Name);
            Console.WriteLine("Count: {0}", emptyCollection2.Count());

            //The Range() method returns a collection of IEnumerable<T> type with specified number of elements and sequential values starting from the first element.
            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());

            for (var i = 0; i < intCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
            }

            //In the above example, Enumerable.Range(10, 10) creates collection with 10 integer elements with the sequential values starting from 10.
            //First parameter specifies the starting value of elements and second parameter specifies the number of elements to create.

            //The Repeat() method generates a collection of IEnumerable<T> type with specified number of elements and each element contains same specified value.

            var intCollection1 = Enumerable.Repeat(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection1.Count());

            for (var i = 0; i < intCollection1.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollection1.ElementAt(i));
            }

            //In the above example, Enumerable.Repeat<int>(10, 10) creates collection with 100 integer type elements with the repeated value of 10. 
            //First parameter specifies the values of all the elements and second parameter specifies the number of elements to create.
        }
    }

}