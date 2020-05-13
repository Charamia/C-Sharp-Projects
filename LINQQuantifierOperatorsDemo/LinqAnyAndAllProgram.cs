namespace LINQQuantifierOperatorsDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqAnyAndAllProgram
    {
        private static void Main()
        {
            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 15}
            };

            //All operator evaluates each element in the given collection on a aspecified condition and returns True if all the elements satisfy the condition
            // checks whether all the students are teenagers    
            var areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);


            Console.WriteLine(areAllStudentsTeenAger);

            //Any checks whether any element satisfy diven condition or not? In the following example, Any operation is used to check wheterh any student is teenager or not
            // checks whether any of the students is teenager   
            var isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);


            Console.WriteLine(isAnyStudentTeenAger);

            //Quantifier operators are NOT SUPPORTED with C# Query syntax
        }
    }

}