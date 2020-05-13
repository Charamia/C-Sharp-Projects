namespace LINQGroupJoinDemo
{

    using System;
    using System.Linq;
    using EmployeeInfo;

    internal class GroupJoin
    {
        private static void Main()
        {
            /*In Linq, we can apply the Group Join on two or more data sources based on a common key (the key must exist in both the data sources) and then it produces the result 
             * set in the form of groups. In simple words, we can say that Linq Group Join is used to group the result sets based on a common key.
             * So, the Group Join is basically used to produces hierarchical data structures. Each item from the first data source is paired with a set of correlated items from
             * the second data source. There are two overloaded versions of this method
             */

            //// Student collection
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //IList<Standard> standardList = new List<Standard>() {
            //    new Standard(){ StandardID = 1, StandardName="Standard 1"},
            //    new Standard(){ StandardID = 2, StandardName="Standard 2"},
            //    new Standard(){ StandardID = 3, StandardName="Standard 3"}
            //};

            //var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
            //                        std => std.StandardID, //outerKeySelector 
            //                        s => s.StandardID,     //innerKeySelector
            //                        (std, studentsGroup) => new // resultSelector 
            //                    {
            //                            Students = studentsGroup,
            //                            StandarFulldName = std.StandardName
            //                        });

            //foreach (var item in groupJoin)
            //{
            //    Console.WriteLine(item.StandarFulldName);

            //    foreach (var stud in item.Students)
            //        Console.WriteLine(stud.StudentName);
            //}
            ////Use of the equals operator to match key selector. == is not valid.

            //var groupJoin1 = from std in standardList
            //                join s in studentList
            //                on std.StandardID equals s.StandardID
            //                    into studentGroup
            //                select new
            //                {
            //                    Students = studentGroup,
            //                    StandardName = std.StandardName
            //                };


            //foreach (var item in groupJoin)
            //{
            //    Console.WriteLine(item.StandarFulldName);

            //    foreach (var stud in item.Students)
            //        Console.WriteLine(stud.StudentName);
            //}

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");

            //Group Join using Method Syntax

            var GroupJoinMS = Department.GetAllDepartments().GroupJoin(
                Employee.GetAllEmployees(),
                dept => dept.ID,
                emp => emp.DepartmentID,
                (dept, emp) => new {dept, emp}
            );
            //Printing the Result set
            //Outer Foreach is for all department

            foreach (var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a department
                foreach (var employee in item.emp)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }

            //The above example done in query syntax is:
            /*
                var GroupJoinQS = from dept in Department.GetAllDepartments()
                            join emp in Employee.GetAllEmployees()
                            on dept.ID equals emp.DepartmentId
                            into EmployeeGroups
                            select new { dept, EmployeeGroups };
            
                //Outer Foreach is for all department
                foreach(var item in GroupJoinQS)
                {
                    Console.WriteLine("Department :" + item.dept.Name);
                    //Inner Foreach loop for each employee of a department
                    foreach(var employee in item.EmployeeGroups)
                    {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                    }
                }

             */

            //Specifying user-defined names in ResultSet
            //It is also possible to specify user-defined names as shown in the below example.
            Console.WriteLine();
            Console.WriteLine("------------------------------");

            //Using Method Syntax
            var GroupJoinMethodS = Department.GetAllDepartments().GroupJoin(
                Employee.GetAllEmployees(),
                dept => dept.ID,
                emp => emp.DepartmentID,
                //User Defined names in Result Selector
                (dept, emp) => new
                {
                    Departments = dept,
                    Employees = emp
                }
            );
            //Using Query Syntax
            var GroupJoinQueryS = from dept in Department.GetAllDepartments()
                join emp in Employee.GetAllEmployees()
                    on dept.ID equals emp.DepartmentID
                    into EmployeeGroups
                //User Defined names in Result Selector
                select new
                {
                    Departments = dept,
                    Employees = EmployeeGroups
                };

            foreach (var item in GroupJoinMethodS)
            {
                Console.WriteLine("Department :" + item.Departments.Name);
                foreach (var employee in item.Employees)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }
    }

}