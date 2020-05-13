namespace LINQEmptyDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LEmptyProgram
    {
        private static void Main()
        {
            /*
             * The Empty Method belongs to the Generation Operator category. It is a static method included in the static Enumerable class. The
             * LINQ Empty Method is used to return an empty collection (i.e. IEnumerable<T>) of a specified type. The following is the signature of this method.
             * 
             * public static IEnumerable<TResult>Empty<Tresult>();
             * 
             * Here TResult specifies the type parameter of the returned generic IEnumerable<TResult>. This method returns an empty IEnumerable<TResult> whose type argument is TResult.
             * 
             * Note: The main advantage of using the Empty method is “Even if you use an empty array or empty collection, then those are objects. As objects, they 
             * are going to be stored in the memory. Once they stored in memory, then it is the responsibility of Garbage Collector to take care of them”.
             * 
             * 
             * In the following example, we have created two empty collections using the LINQ Empty Method. The first Empty method returns an empty collection of string while the
             * second Empty method returns an empty collection of students.
             * 
             * 
             */

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();
            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);
            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);

            //Why do we need the LINQ Empty Method?
            //Consider one scenario, where our application calls a method which returns an IEnumerable<int>. There might be a situation where the method returns null.
            //In the following example, the GetData() method is returning null. So, when we run the following program, it will throw NULL reference exception.

            /*
             *  IEnumerable<int> integerSequence = GetData();
                 foreach (var num in integerSequence)
                     {
                         Console.WriteLine(num);
                     }

            The above problem can be fixed in two ways

            Solution1:
            We need to check for NULL before looping through the items in the collection as shown in the below example.
             */

            var integerSequence = GetData();

            if (integerSequence != null)
            {
                foreach (var num in integerSequence)
                {
                    Console.WriteLine(num);
                }
            }

            var integerSequence1 = GetData() ?? Enumerable.Empty<int>();
            ;

            foreach (var num in integerSequence1)
            {
                Console.WriteLine(num);
            }
        }

        private static IEnumerable<int> GetData()
        {
            return null;
        }

        //Solution2
        //We can solve the problem by using the LINQ Empty Method as shown in the below example. Here, we are using the NULL-COALESCING operator which checks if the GetData() method
        //returns NULL, then initialized the integerSequence variable with an empty IEnumerable<int>.
    }

}