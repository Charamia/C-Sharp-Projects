namespace LINQDefaultIfEmptyDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LinqDIFProgram
    {
        private static void Main()
        {
            /*
             * f the sequence or data source on which the DefaultIfEmpty method is called is not empty, then the values of the original sequence or data source are going to be returned. 
             * On the other hand, if the sequence or data source is empty, then it returns a sequence with the default values based on the data type.
             * There are two overloaded versions available for this DefaultIfEmpty method in Linq 
             * The first overloaded version does not take any parameter and in this case, if the sequence is empty then it will return the default values based on the data type.
             * In the second overloaded version of the DefaultIfEmpty method, you can pass the default value and if the sequence is empty then this default value (what you pass to the method) 
             * is going to be returned by the method.
             */

            //In the following example, the sequence is not empty. So, it is going to return a copy of the original values.
            var numbers = new List<int> {10, 20, 30};
            var result = numbers.DefaultIfEmpty();
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //In the below example, the sequence is empty. So, in this case, it is going to return “0” as the default value. This is because 0 is the default value for the integer data type.

            var numbers1 = new List<int>();
            var result1 = numbers1.DefaultIfEmpty();

            foreach (var num in result1)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //In the following example, the sequence is empty but here we have supplied a default value (i.e. 5) to the DefaultIfEmpty method. So, in this case, the default value that we supplied (5) is going to be returned.

            var result2 = numbers1.DefaultIfEmpty(5);

            foreach (var num in result2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //Note: If we supplied a default value but the sequence is not empty then, in that case, the original values that are present in the sequence is going to be returned.
            //In the below example, we have supplied a default value i.e. 5 to the DefaultIfEmpty method but the sequence is not empty. So, in this case, the elements which are present 
            //in the sequence are going to be returned.

            var result3 = numbers.DefaultIfEmpty(5);

            foreach (var num in result3)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            IList<string> emptyList = new List<string>();

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));

            /*
             * In the above example, emptyList.DefaultIfEmpty() returns a new string collection with one element whose value is null because null is a default
             * value of string. Another method emptyList.DefaultIfEmpty("None") returns a string collection with one element whose value is "None" instead of null
             * 
             * The following example demonstrates calling DefaultIfEmpty on int collection.
             */

            IList<int> emptyList1 = new List<int>();

            var newList3 = emptyList1.DefaultIfEmpty();
            var newList4 = emptyList1.DefaultIfEmpty(100);

            Console.WriteLine("Count: {0}", newList3.Count());
            Console.WriteLine("Value: {0}", newList3.ElementAt(0));

            Console.WriteLine("Count: {0}", newList4.Count());
            Console.WriteLine("Value: {0}", newList4.ElementAt(0));

            //

            IList<Student> emptyStudentList = new List<Student>();

            var newStudentList1 = emptyStudentList.DefaultIfEmpty();
            var newStudentList2 = emptyStudentList.DefaultIfEmpty(new Student {StudentID = 0, StudentName = ""});

            Console.WriteLine("Count: {0} ", newStudentList1.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0));

            Console.WriteLine("Count: {0} ", newStudentList2.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList2.ElementAt(0).StudentID);
        }
    }

}