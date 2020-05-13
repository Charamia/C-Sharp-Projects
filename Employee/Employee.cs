namespace Employee
{

    using System.Collections.Generic;

    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public List<string> Technology { get; set; }

        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000,
                    Technology = new List<string> {"C#", "Jave", "C++"}
                },
                new Employee
                {
                    ID = 102, FirstName = "Priyanka", LastName = "Dewagan", Salary = 50000,
                    Technology = new List<string> {"WCF", "SQL Server", "C#"}
                },
                new Employee
                {
                    ID = 103, FirstName = "Hina", LastName = "Shatma", Salary = 40000,
                    Technology = new List<string> {"MVC", "Jave", "LINQ"}
                },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 450000},
                new Employee {ID = 105, FirstName = "Sambit", LastName = "satapathy", Salary = 550000},
                new Employee
                {
                    ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 700000,
                    Technology = new List<string> {"ADO.Net", "C#", "LINQ"}
                }
            };

            return employees;
        }
    }

}