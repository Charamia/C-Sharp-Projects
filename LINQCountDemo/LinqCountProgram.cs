namespace LINQCountDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqCountProgram
    {
        private static void Main()
        {
            //The count operator returns the number of elements that have satisfied the given collection.
            //The Count() extension method has 2 overloads
            //The first overload method of Count returns the number of elements in the especified collection, whereas the second overload method returns the number of elements which  have satisfied
            //the specified condition given as lambda expression/predicate function
            //The return type of Count() function is always going to be int. 
            //The following example demonstrates Count() on primitive collection

            IList<int> intList = new List<int> {10, 21, 30, 45, 50};

            var totalElements = intList.Count();

            Console.WriteLine("Total Elements: {0}", totalElements);

            var evenElements = intList.Count(i => i % 2 == 0);

            Console.WriteLine("Even Elements: {0}", evenElements);

            var MSCount = intList.Where(num => num > 40).Count();
            Console.WriteLine();

            Console.WriteLine("Number of elements = " + MSCount);

            Console.WriteLine();

            //The following example demonstrates Count() method ion complex type collection

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 15}
            };

            var totalStudents = studentList.Count();

            Console.WriteLine("Total Students: {0}", totalStudents);

            var adultStudents = studentList.Count(s => s.Age >= 18);

            Console.WriteLine("Number of Adult Students: {0}", adultStudents);

            //Count(predicate) extention method with predicate parameter is NOT SUPPORTED in the VB.Net

            //C# Query Syntax doesn't support aggregation operators. However, we can wrap the query into brackets and use an aggregation functions as shown below

            var totalAge = (from s in studentList
                select s.Age).Count();

            Console.WriteLine();

            var MethodSCount = Employee.GetAllEmployees().Count();

            Console.WriteLine("Total No of Employees = " + MethodSCount);

            Console.WriteLine();

            //Using Method Syntax
            var MSyntaxCount = Employee.GetAllEmployees()
                .Where(emp => emp.Department == "IT")
                .Count();

            Console.WriteLine("Total No of Employees of IT Department = " + MSyntaxCount);
        }
    }

}