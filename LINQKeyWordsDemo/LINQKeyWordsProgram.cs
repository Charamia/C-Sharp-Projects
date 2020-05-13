namespace LINQKeyWordsDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LINQKeyWordsProgram
    {
        private static void Main()
        {
            /* let keyword
             * 
             * The 'let' keyword is useful in query syntax. It projects a new range variable, allows re-use of the expression and makes the query more readable.
             * 
             * For example, you can compare string values and select the lowercase string value as shown below:
             *
             * 
             * 
             */

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Steve", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            var lowercaseStudentNames = from s in studentList
                where s.StudentName.ToLower().StartsWith("r")
                select s.StudentName.ToLower();

            //As we can see, the ToLower() method is used multiple times in the above query. The following example use 'let to introduce new variable 'lowercaseStudentName'
            //that will be then used everywhere. Thus , let keyword to make the query more readable.

            IList<Student> studentList1 = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Steve", Age = 15},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 12},
                new Student {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            var lowercaseStudentNames1 = from s in studentList1
                let lowercaseStudentName = s.StudentName.ToLower()
                where lowercaseStudentName.StartsWith("r")
                select lowercaseStudentName;

            var teenAgerStudents = from s in studentList
                where s.Age > 12 && s.Age < 20
                select s
                into teenStudents
                where teenStudents.StudentName.StartsWith("B")
                select teenStudents;


            foreach (var std in teenAgerStudents)
            {
                Console.WriteLine(std.StudentName);
                // into keyword

                // We have already used the 'into' keyword in grouping. You can also use the 'into' keyword to continue a query afer a select cluse.

                var teenAgerStudents5 = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    select s
                    into teenStudents
                    where teenStudents.StudentName.StartsWith("B")
                    select teenStudents;


                foreach (var std1 in teenAgerStudents5)
                {
                    Console.WriteLine(std1.StudentName);
                }

                //In the above query, the 'into' keyword introduced a new range variable teenStudents, so the first range variable s goes out of scope. You can write a further query after the 
                //into keyword using a new range variable.
            }
        }
    }

}