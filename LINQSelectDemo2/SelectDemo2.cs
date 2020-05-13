namespace LINQSelectDemo2
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Employee;

    internal class SelectDemo2
    {
        private static void Main()
        {
            //using Qyery syntax 
            var basicQuery = (from emp in Employee.GetEmployees()
                select emp).ToList();

            foreach (var emp in basicQuery)
            {
                Console.WriteLine($"ID: {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.WriteLine();

            //using Method syntax 
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();

            foreach (var emp in basicMethod)
            {
                Console.WriteLine($"ID: {emp.ID} Name : {emp.FirstName} {emp.LastName}");
            }

            Console.WriteLine();

            var basicPropQuery = (from emp in Employee.GetEmployees()
                select emp.ID).ToList();

            foreach (var id in basicPropQuery)
            {
                Console.WriteLine($"ID: {id}");
            }

            Console.WriteLine();
            //Using Method syntax 

            var basicPropMethod = Employee.GetEmployees().Select(emp => emp.ID);

            foreach (var id in basicPropMethod)
            {
                Console.WriteLine($"ID: {id}");
            }

            Console.WriteLine();

            var selectQuery = from emp in Employee.GetEmployees()
                select new Employee
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary
                };

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName} Salary: {emp.Salary}");
            }

            Console.WriteLine();

            //Method syntax 

            var selectMethod = Employee.GetEmployees()
                .Select(emp => new Employee
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary
                }).ToList();

            foreach (var emp in selectMethod)
            {
                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName} Salary: {emp.Salary}");
            }

            Console.WriteLine();

            //Selecting the data to another class using the LINQ Select operator

            //Query syntax 

            var selectQuery1 = from emp in Employee.GetEmployees()
                select new EmployeeBasicInfo
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary
                };

            foreach (var emp in selectQuery1)
            {
                Console.WriteLine($"Name 2nd example: {emp.FirstName} {emp.LastName} Salary: {emp.Salary}");
            }

            Console.WriteLine();

            //Method syntax 

            var selectMethod1 = Employee.GetEmployees()
                .Select(emp => new EmployeeBasicInfo
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary
                }).ToList();

            foreach (var emp in selectMethod1)
            {
                Console.WriteLine($" Name exampe 3 : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }

            //Select Data to Anonymous Type using LINQ Select operator
            Console.WriteLine();
            //Query syntax 
            var selectQuery2 = from emp in Employee.GetEmployees()
                select new
                {
                    emp.FirstName,
                    emp.LastName,
                    emp.Salary
                };

            foreach (var emp in selectQuery2)
            {
                Console.WriteLine($" Name exampe 4 : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }

            //Method syntax 
            var selectMethod2 = Employee.GetEmployees()
                .Select(emp => new
                {
                    emp.FirstName,
                    emp.LastName,
                    emp.Salary
                }).ToList();

            //How to pweform calculations on a data selected using LINQ Select Operator
            // 1. AnnualSalary = Salary * 12
            // 2. FullName = firstName + " " + LastName
            //Then we need to select the ID, AnnualSalary and fullName to anonymous type

            //Query syntax 
            var selectedQuery4 = from emp in Employee.GetEmployees()
                select new
                {
                    EmployeeId = emp.ID,
                    FullName = emp.FirstName + " " + emp.LastName,
                    AnnualSalary = emp.Salary * 12
                };

            foreach (var emp in selectedQuery4)
            {
                Console.WriteLine($" ID {emp.EmployeeId} Name : {emp.FullName} Annual Salary : {emp.AnnualSalary} ");
            }

            //Method syntax 

            var selectMethod4 = Employee.GetEmployees()
                .Select(emp => new
                {
                    EmployeeId = emp.ID,
                    FullName = emp.FirstName + " " + emp.LastName,
                    AnnualSalary = emp.Salary * 12
                }).ToList();
            // how to select data with index value?

            //Query syntax 
            var query5 = (from emp in Employee.GetEmployees().Select((value, index) => new {value, index})
                select new
                {
                    IndexPosition = emp.index,
                    FullName = emp.value.FirstName + " " + emp.value.LastName,
                    emp.value.Salary
                }).ToList();


            foreach (var emp in query5)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }

            //Method Syntax
            var selectMethod5 = Employee.GetEmployees().Select((emp, index) => new
            {
                IndexPosition = index,
                FullName = emp.FirstName + " " + emp.LastName,
                emp.Salary
            });
        }
    }

}