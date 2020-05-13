namespace IEnumerableAndIQueryable
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class IEandIQProgram
    {
        private static void Main()
        {
            var studentList = new List<Student>
            {
                new Student {ID = 1, Name = "James", Gender = "Male"},
                new Student {ID = 2, Name = "Sara", Gender = "Female"},
                new Student {ID = 3, Name = "Steve", Gender = "Male"},
                new Student {ID = 4, Name = "Pam", Gender = "Female"}
            };

            //LINQ Query to fetch all students with Gender Male
            //IEnumerable<Student> querySyntax = from std in studentList
            //                                   where std.Gender == "Male"
            //                                   select std;

            var methodSyntax = studentList.Where(std => std.Gender == "Male");

            var MethodSyntax = studentList.AsQueryable()
                .Where(std => std.Gender == "Male");


            //Iterate through the collection
            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"ID: {student.ID} Name: {student.Name}");
            }
        }
    }

}