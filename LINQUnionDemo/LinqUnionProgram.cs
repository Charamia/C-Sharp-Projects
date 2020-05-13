namespace LINQUnionDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LinqUnionProgram
    {
        private static void Main()
        {
            //The Union extension method requires two collections and returns a new collection that includes distinct elements from both the collections. Consider the following example.

            IList<string> strList1 = new List<string> {"One", "Two", "three", "Four"};
            IList<string> strList2 = new List<string> {"Two", "THREE", "Four", "Five"};

            var result = strList1.Union(strList2, StringComparer.OrdinalIgnoreCase);

            //foreach (string str in result)
            //{
            //    Console.WriteLine(str);
            //}


            /*
             * The Union extension method doesn't return the correct result for the collection of complex types. 
             * 
             * We need to implement IEqualityComparer interface in order to get the correct result from Union method.
             */

            Console.WriteLine();

            IList<Student> studentList1 = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Steve", Age = 15},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 5, StudentName = "Ron", Age = 19}
            };

            IList<Student> studentList2 = new List<Student>
            {
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 5, StudentName = "Ron", Age = 19}
            };

            var result1 = studentList1.Union(studentList2, new StudentComparer());

            //foreach (var std in result1)
            //{
            //    Console.WriteLine(std.StudentName);
            //}

            var methodSyntax = studentList1.Select(x => new {x.StudentID, x.StudentName})
                .Union(studentList2.Select(x => new {x.StudentID, x.StudentName})).ToList();


            foreach (var student in methodSyntax)
            {
                Console.WriteLine($" ID : {student.StudentID} Name: {student.StudentName}");
            }
        }
    }

}