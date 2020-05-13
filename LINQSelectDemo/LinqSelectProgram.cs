namespace LINQSelectDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqSelectProgram
    {
        private static void Main()
        {
            //Select in Query Syntax C#
            //The following example of the select clause returns a collection of anonymous type containing the Name and Age property

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 15}
            };
            /*
            // returns collection of anonymous objects with Name and Age property
            var selectResult = from s in studentList
                               select new { Name = "Mr. " + s.StudentName, Age = s.Age };

            // iterate selectResult
            foreach (var item in selectResult)
            {
                Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
            }
            */

            //Select in Method Syntax 

            //The Select operator is optional in the method syntax. However, you can use it to shape the data. 
            //In the following example, Select extention method returns a collection of anonymous object with the Nme and Age property

            // returns collection of anonymous objects with Name and Age property
            var selectResult = studentList.Select(s => new
            {
                Name = s.StudentName,
                s.Age
            });

            // iterate selectResult
            foreach (var item in selectResult)
            {
                Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
            }
        }
    }

}