namespace LINQMinDemo
{

    using System;
    using System.Linq;

    internal class MinProgram
    {
        private static void Main()
        {
            //The Linq Min method is used to returns the lowest numeric value from the collection on which it is applied. 

            int[] intNumbers = {60, 80, 50, 90, 10, 30, 70, 40, 20, 100};

            //Using Method Syntax

            var MSLowestNumber = intNumbers.Min();

            //Using Query Syntax

            var QSLowestNumber = (from num in intNumbers
                select num).Min();

            Console.WriteLine("Lowest Number = " + MSLowestNumber);

            Console.WriteLine();

            //Example with filter

            //Using Method Syntax

            var MethodSLowestNumber = intNumbers.Where(num => num > 50).Min();

            //Using Query Syntax

            var QuerySLowestNumber = (from num in intNumbers
                where num > 50
                select num).Min();

            Console.WriteLine("Lowest Number = " + MethodSLowestNumber);

            Console.WriteLine();

            //Work with complex type

            //Using Method Syntax
            var MSLowestSalary = Employee.GetAllEmployees()
                .Min(emp => emp.Salary);
            //Using Query Syntax
            var QSLowestSalary = (from emp in Employee.GetAllEmployees()
                select emp).Min(e => e.Salary);

            Console.WriteLine("Lowest Salary = " + MSLowestSalary);


            //Using Method Syntax
            var MethodSLowestSalary = Employee.GetAllEmployees()
                .Where(emp => emp.Department == "IT")
                .Min(emp => emp.Salary);

            //Using Query Syntax
            var QueryLowestSalary = (from emp in Employee.GetAllEmployees()
                where emp.Department == "IT"
                select emp).Min(e => e.Salary);

            Console.WriteLine("IT Department Lowest Salary = " + QSLowestSalary);
        }
    }

}