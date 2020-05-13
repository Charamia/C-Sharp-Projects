namespace LINQExceptDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LinqExceptProgram
    {
        private static void Main()
        {
            //The Except() method requires two collections. It returns a new collection with elements from the first collection which do not exist in the second collection (parameter collection).

            IList<string> strList1 = new List<string> {"One", "Two", "Three", "Four", "Five"};
            IList<string> strList2 = new List<string> {"Four", "Five", "Six", "Seven", "Eight"};

            var result = strList1.Except(strList2);

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            /*
             * Except extension method doesn't return the correct result for the collection of complex types.
             * We need to implement IEqualityComparer interface in order to get the correct result from Except method.
             */

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
                new Student {StudentID = 5, StudentName = "Ron", Age = 19},
                new Student {StudentID = 6, StudentName = "Ram", Age = 29}
            };

            var resultedCol = studentList1.Except(studentList2, new StudentComparer());

            foreach (var std in resultedCol)
            {
                Console.WriteLine(std.StudentName);
            }

            //The Except operator is Not Supported in C# & VB.Net Query syntax. However, we can use Distinct method on query variable or wrap whole query into brackets and then call Except().
        }
    }

}