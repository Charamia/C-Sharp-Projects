namespace LINQOuterJoinDemo
{

    using System;
    using System.Linq;
    using EmployeeInfo;

    internal class LeftOuterJoinProgram
    {
        private static void Main()
        {
            /*So, in simple words, we can say that the Left Outer Join is going to return all the matching data from both the data sources as well as all the non-matching 
             * data from the left data source. In such cases, for the non-matching data, it will take null values for the second data source.
             * In order to implement the Left Outer Join in Linq, it’s mandatory to use the “INTO” keyword along with the “DefaultIfEmpty()” method.
             * 
             * Left Outer Join in Linq using Method Syntax:
             * In order to implement Left Outer Join in Linq using Method Syntax we need to use the GroupJoin() method along with SelectMany() and DefaultIfEmpty() methods. 
             */

            var MSOuterJOIN = Employee.GetAllEmployees()
                .GroupJoin(
                    Address.GetAddress(),
                    emp => emp.AddressId,
                    add => add.ID,
                    (emp, add) => new {emp, add}
                )
                .SelectMany(
                    x => x.add.DefaultIfEmpty(),
                    (employee, address) => new {employee, address}
                );
            foreach (var item in MSOuterJOIN)
            {
                Console.WriteLine($"Name : {item.employee.emp.Name}, Address : {item.address?.AddressLine} ");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            //Anonymous type with user-defined properties in the ResultSet:
            //Using Method Syntax
            var MethodSOuterJOIN = Employee.GetAllEmployees()
                .GroupJoin(
                    Address.GetAddress(),
                    emp => emp.AddressId,
                    add => add.ID,
                    (emp, add) => new {emp, add}
                )
                .SelectMany(
                    x => x.add.DefaultIfEmpty(),
                    (employee, address) => new
                    {
                        EmployeeName = employee.emp.Name,
                        AddressLine = address == null ? "NA" : address.AddressLine
                    }
                );
            //Using Query Syntax
            var QuerySOuterJoin = from emp in Employee.GetAllEmployees()
                join add in Address.GetAddress()
                    on emp.AddressId equals add.ID
                    into EmployeeAddressGroup
                from address in EmployeeAddressGroup.DefaultIfEmpty()
                select new
                {
                    EmployeeName = emp.Name,
                    AddressLine = address == null ? "NA" : address.AddressLine
                };
            foreach (var item in MethodSOuterJOIN)
            {
                Console.WriteLine($"Name : {item.EmployeeName}, Address : {item.AddressLine} ");
            }

            //Note: If you want to perform Right outer join then simply exchange the data source.
        }
    }

}