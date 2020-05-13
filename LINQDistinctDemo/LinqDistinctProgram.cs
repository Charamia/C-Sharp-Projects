namespace LINQDistinctDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LinqDistinctProgram
    {
        private static void Main()
        {
            //Set operators in LINQ are: Distinct, Except, Intersect, Union
            //Distinct extension method returns a new collection of unique elements from the given collection

            /*
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

            IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

            var distinctList1 = strList.Distinct();

            foreach (var str in distinctList1)
                Console.WriteLine(str);

            var distinctList2 = intList.Distinct();

            foreach (var i in distinctList2)
             /*   Console.WriteLine(i);

            /*
             * The Distinct extension method doesn't compare values of complex type objects. You need to implement IEqualityComparer<T> interface in order to compare the values of complex types. 
             * In the following example, StudentComparer class implements IEqualityComparer<Student> to compare Student< objects.
             */

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Steve", Age = 15},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 5, StudentName = "Ron", Age = 19}
            };


            var distinctStudents = studentList.Distinct(new StudentComparer());

            foreach (var std in distinctStudents)
            {
                Console.WriteLine(std.StudentName);
            }

            //The Distinct operator is NOT SUPPORTED in C# Query syntax. However, we can use Distinct method of quey variable or wrap whole query into brackets and then call Distinct()
        }
    }

}