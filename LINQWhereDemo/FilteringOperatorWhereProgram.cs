namespace LINQWhereDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class FilteringOperatorWhereProgram
    {
        private static void Main()
        {
            /*
             * Filtering is nothing but the process to get only those elements from a data source that satisfied the given condition. It is also possible to fetch the data from a data
             * source with more than one condition as per our business requirement.
             * 
             * There are two methods provided by LINQ in C# which are used for filtering. They are as follows: Whete and OfType
             * 
             * We need to use the where standard query operator in LINQ when we need to filter the data from a data source based on some condition(s) just like as we did in SQL using the where clause.
             * So in simple words, we can say that it is used to filter the data from a data source based on some condition(s).
             * 
             * The “where” always expects at least one condition and we can specify the condition(s) using predicates. The conditions can be written using the following symbols
             * ==, >=, <=, &&, ||, >, <, etc.  
             *
             * There are two overloaded versions of the “where” operator is available.
             */

            var intList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //Method Syntax
            var filteredData = intList.Where(num => num > 5);
            //Query Syntax
            var filteredResult = from num in intList
                where num > 5
                select num;

            foreach (var number in filteredData)
            {
                Console.WriteLine(number);
            }

            //As we can see in the above image, the predicate (Func<int, bool> predicate) expects one input parameter of type integer and it returns a boolean value.

            //Method Syntax
            var filteredData1 = intList.Where(num => CheckNumber(num));
            foreach (var number in filteredData1)
            {
                Console.WriteLine(number);
            }


            //In the second overloaded version of the “where” extension method, the int parameter of the predicate function represents the index position of the source element.
            //Here we need to filter only the odd numbers i.e. the numbers which are not divisible by 2. Along with the numbers we also need to fetch the index position of the number. The index is 0 based.

            //Method Syntax
            var OddNumbersWithIndexPosition = intList.Select((num, index) => new
                {
                    Numbers = num,
                    IndexPosition = index
                }).Where(x => x.Numbers % 2 != 0)
                .Select(data => new
                {
                    Number = data.Numbers,
                    data.IndexPosition
                });

            foreach (var item in OddNumbersWithIndexPosition)
            {
                Console.WriteLine($"IndexPosition :{item.IndexPosition} , Value : {item.Number}");
            }

            //Query Syntax
            var OddNumbersWithIndexPosition1 =
                from number in intList.Select((num, index) => new {Numbers = num, IndexPosition = index})
                where number.Numbers % 2 != 0
                select new
                {
                    Number = number.Numbers,
                    number.IndexPosition
                };

            //Query Syntax
            var QuerySyntax = from employee in Employee.GetEmployees()
                where employee.Salary > 50000
                select employee;
            //Method Syntax
            var MethodSyntax = Employee.GetEmployees()
                .Where(emp => emp.Salary > 50000);

            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}, Gender : {emp.Gender}");
                if (emp.Technology != null && emp.Technology.Count() > 0)
                {
                    Console.Write(" Technology : ");
                    foreach (var tech in emp.Technology)
                    {
                        Console.Write(tech + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Technology Not Available ");
                }
            }

            //Using multiple conditions:

            //Query Syntax
            var QuerySyntax1 = from employee in Employee.GetEmployees()
                where employee.Salary > 500000 && employee.Gender == "Male"
                select employee;
            //Method Syntax
            var MethodSyntax1 = Employee.GetEmployees()
                .Where(emp => emp.Salary > 500000 && emp.Gender == "Male")
                .ToList();

            foreach (var emp in MethodSyntax1)
            {
                Console.WriteLine($"Name : {emp.Name}, Salary : {emp.Salary}, Gender : {emp.Gender}");
                if (emp.Technology != null && emp.Technology.Count() > 0)
                {
                    Console.Write(" Technology : ");
                    foreach (var tech in emp.Technology)
                    {
                        Console.Write(tech + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Technology Not Available ");
                }
            }

            //Multiple conditions with the custom operation and projecting the data to an anonymous type:
            //Requirement:
            //All employees whose salary is greater than or equal to 50000 and technology should not be null
            //We need to fetch the following to anonymous type: 1) Name as it is 2) Gender as it is 3) MonthlySalary = Salary/12
            Console.WriteLine();
            //Query Syntax
            var QuerySyntax3 = (from employee in Employee.GetEmployees()
                where employee.Salary >= 50000 && employee.Technology != null
                select new
                {
                    EmployeeName = employee.Name,
                    employee.Gender,
                    MonthlySalary = employee.Salary / 12
                }).ToList();

            //Method Syntax
            var MethodSyntax3 = Employee.GetEmployees()
                .Where(emp => emp.Salary >= 50000 && emp.Technology != null)
                .Select(emp => new
                {
                    EmployeeName = emp.Name,
                    emp.Gender,
                    MonthlySalary = emp.Salary / 12
                })
                .ToList();

            foreach (var emp in QuerySyntax3)
            {
                Console.WriteLine(
                    $"Name : {emp.EmployeeName}, Gender : {emp.Gender}, Monthly Salary : {emp.MonthlySalary}");
            }

            Console.WriteLine();

            //Fetch elements along with the Index position
            //Here we fetch all th eemployees whose gender is Male and Salary is greater than 500000 along with their index position to an anonymous type

            //Query Syntax
            var QuerySyntax4 =
                (from data in Employee.GetEmployees().Select((Data, index) => new {employee = Data, Index = index})
                    where data.employee.Salary >= 500000 && data.employee.Gender == "Male"
                    select new
                    {
                        EmployeeName = data.employee.Name,
                        data.employee.Gender,
                        data.employee.Salary,
                        IndexPosition = data.Index
                    }).ToList();
            //Method Syntax
            var MethodSyntax4 = Employee.GetEmployees().Select((Data, index) => new {employee = Data, Index = index})
                .Where(emp => emp.employee.Salary >= 500000 && emp.employee.Gender == "Male")
                .Select(emp => new
                {
                    EmployeeName = emp.employee.Name,
                    emp.employee.Gender,
                    emp.employee.Salary,
                    IndexPosition = emp.Index
                })
                .ToList();
            foreach (var emp in QuerySyntax4)
            {
                Console.WriteLine(
                    $"Position : {emp.IndexPosition} Name : {emp.EmployeeName}, Gender : {emp.Gender}, Salary : {emp.Salary}");
            }
        }

        public static bool CheckNumber(int number)
        {
            if (number > 5)
            {
                return true;
            }

            return false;
        }
    }

}