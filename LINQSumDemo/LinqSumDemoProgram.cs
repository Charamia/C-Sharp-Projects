namespace LINQSumDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LinqSumDemoProgram
    {
        private static void Main()
        {
            //The sum method calculates the sum of numeric items in the collection
            //The following example demonstrates Sum() on the primitive collection

            IList<int> intList = new List<int> {10, 21, 30, 45, 50, 87, 90, 100, 110, 89};

            var total = intList.Sum();

            //Console.WriteLine("Sum: {0}", total);

            var sumOfEvenElements = intList.Sum(i =>
            {
                if (i % 2 == 0)
                {
                    return i;
                }

                return 0;
            });

            var MSTotal = intList.Sum(num =>
            {
                if (num > 50)
                {
                    return num;
                }

                return 0;
            });

            //Console.WriteLine("Sum = " + MSTotal);


            //Console.WriteLine("Sum of Even Element: {0}", sumOfEvenElements);

            //The following example calculates the sum of all student's age and also number of adult students in a student collection

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Steve", Age = 15}
            };

            var sumOfAge = studentList.Sum(s => s.Age);

            //Console.WriteLine("Sum of all student's age: {0}", sumOfAge);

            var totalAdults = studentList.Sum(s =>
            {
                if (s.Age >= 18)
                {
                    return 1;
                }

                return 0;
            });


            //  Console.WriteLine("Total Adult Students: {0}", totalAdults);

            //Sum operator is NOT SUPPORTED in C# Query syntax!


            //Using Method Syntax
            var TotalSalaryMS = Employee.GetAllEmployees()
                .Sum(emp => emp.Salary);
            //Using Query Syntax
            var TotalSalaryQS = (from emp in Employee.GetAllEmployees()
                select emp).Sum(e => e.Salary);

            Console.WriteLine("Sum Of Salary = " + TotalSalaryMS);

            Console.WriteLine();

            //Using Method Syntax
            var TotalSalaryMethodSyntax = Employee.GetAllEmployees()
                .Where(emp => emp.Department == "IT")
                .Sum(emp => emp.Salary);
            //Using Query Syntax
            var TotalSalaryQuerySyntax = (from emp in Employee.GetAllEmployees()
                where emp.Department == "IT"
                select emp).Sum(e => e.Salary);

            Console.WriteLine("IT Department Total Salary = " + TotalSalaryMethodSyntax);
        }
    }

}