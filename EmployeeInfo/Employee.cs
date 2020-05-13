﻿namespace EmployeeInfo
{

    using System.Collections.Generic;

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentID { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee {ID = 1, Name = "Preety", AddressId = 1, DepartmentID = 10},
                new Employee {ID = 2, Name = "Priyanka", AddressId = 2, DepartmentID = 20},
                new Employee {ID = 3, Name = "Anurag", AddressId = 3, DepartmentID = 30},
                new Employee {ID = 4, Name = "Pranaya", AddressId = 4, DepartmentID = 30},
                new Employee {ID = 5, Name = "Hina", AddressId = 5, DepartmentID = 20},
                new Employee {ID = 6, Name = "Sambit", AddressId = 6, DepartmentID = 10},
                new Employee {ID = 7, Name = "Happy", AddressId = 7, DepartmentID = 10},
                new Employee {ID = 8, Name = "Tarun", AddressId = 8, DepartmentID = 0},
                new Employee {ID = 9, Name = "Santosh", AddressId = 9, DepartmentID = 10},
                new Employee {ID = 10, Name = "Raja", AddressId = 10, DepartmentID = 20},
                new Employee {ID = 11, Name = "Sudhanshu", AddressId = 11, DepartmentID = 30}
            };
        }
    }

}