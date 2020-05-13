namespace LINQIntersectDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LinqIntersectProgram
    {
        private static void Main()
        {
            //The Intersect extension method requires two collections. It returns a new collection that includes common elements that exists in both the collection. Consider the following example.

            IList<string> strList1 = new List<string> {"One", "Two", "Three", "Four", "Five"};
            IList<string> strList2 = new List<string> {"Four", "Five", "Six", "Seven", "Eight"};

            var result = strList1.Intersect(strList2);

            //foreach (string str in result)
            //{
            //    Console.WriteLine(str);
            //}

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

            var resultedCol = studentList1.Intersect(studentList2, new StudentComparer());

            Console.WriteLine();

            //foreach (Student std in resultedCol)
            //{
            //    Console.WriteLine(std.StudentName);
            //}

            var MS = studentList1.Select(x => x.StudentName)
                .Intersect(studentList2.Select(y => y.StudentName)).ToList();

            //Query Syntax

            var QS = (from std in studentList1
                    select std.StudentName)
                .Intersect(studentList2.Select(y => y.StudentName)).ToList();

            //foreach (var name in MS)
            //{
            //    Console.WriteLine(name);
            //}

            Console.WriteLine();

            //Method Syntax

            var MS1 = studentList1.Intersect(studentList2).ToList();

            //Query Syntax

            var QS1 = (from std in studentList1
                select std).Intersect(studentList2).ToList();

            foreach (var student in MS1)
            {
                Console.WriteLine($" ID : {student.StudentID} Name : {student.StudentName}");
            }


            //Method Syntax
            var MSWithAnonymousType = studentList1.Select(x => new {x.StudentID, x.StudentName})
                .Intersect(studentList2.Select(x => new {x.StudentID, x.StudentName})).ToList();

            //Query Syntax
            var QSWithanonymousType = (from std in studentList1
                    select new {std.StudentID, std.StudentName})
                .Intersect(studentList2.Select(x => new {x.StudentID, x.StudentName})).ToList();

            foreach (var student in MSWithAnonymousType)
            {
                Console.WriteLine($" ID : {student.StudentID} Name : {student.StudentName}");
            }

            //Intersect operator is NOT Supported in C# & VB.Net Query syntax. However, we can use the Intersect method on a query variable or wrap whole query into brackets and then call Intersect()
        }
    }

}