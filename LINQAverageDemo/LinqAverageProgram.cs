namespace LINQAverageDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqAverageProgram
    {
        private static void Main()
        {
            //Average extention method calculates the average of the numeric items in th ecollection. Average method returns nullable or non-nullable decimal, double or float value.
            //The following example demonstrates Average method that returns average value of all the integers in th ecollection

            IList<int> intList = new List<int> {10, 20, 30};

            var avg = intList.Average();

            Console.WriteLine("Average: {0}", avg);

            //We can specify an int, decimal, double or float property of a class as a lambda expression of which you want to get an average value. 
            //The following example demonstrates Average method on th ecomplex type

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 15}
            };

            var avgAge = studentList.Average(s => s.Age);

            Console.WriteLine("Average Age of Student: {0}", avgAge);

            //The Average operator in query syntax is NOT SUPPORTED in C#. However, it is supported in VB.Net.

            int[] intNumbers = {60, 80, 50, 90, 10, 30, 70, 40, 20, 100};
            //Using Method Syntax

            var MSAverageValue = intNumbers.Average();

            Console.WriteLine("Average Value = " + MSAverageValue);
            Console.WriteLine();
            //Linq Average Method with filter

            //Using Method Syntax
            var MethodSAverageValue = intNumbers.Where(num => num > 50).Average();

            //Using Query Syntax

            var QSAverageValue = (from num in intNumbers
                where num > 50
                select num).Average();

            Console.WriteLine("Average Value = " + MethodSAverageValue);

            //Working with complex data type

            Console.WriteLine();

            //Using Method Syntax
            var MSAverageSalary = Employee.GetAllEmployees()
                .Average(emp => emp.Salary);

            //Using Query Syntax
            var QSAverageSalary = (from emp in Employee.GetAllEmployees()
                select emp).Average(e => e.Salary);

            Console.WriteLine("Average Salary = " + MSAverageSalary);

            Console.WriteLine();

            //Using Method Syntax
            var MethodSAverageSalary = Employee.GetAllEmployees()
                .Where(emp => emp.Department == "IT")
                .Average(emp => emp.Salary);
            //Using Query Syntax
            var QuerySAverageSalary = (from emp in Employee.GetAllEmployees()
                where emp.Department == "IT"
                select emp).Average(e => e.Salary);

            Console.WriteLine("IT Department Average Salary = " + MethodSAverageSalary);
        }
    }

}