namespace LINQAggregateDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class AggregateProgram
    {
        private static void Main()
        {
            //The aggregation operators perform mathematical operations like Average, Aggregate, Count, Max, Min and Sum on the numeric property of the elements in th ecollection
            //THe aggregate method performs an accumulate operation. Aggregate method has 3 overload methods

            IList<string> strList = new List<string> {"One", "Two", "Three", "Four", "Five"};

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(commaSeperatedString);

            //In the above example, Aggregate extention method returns comma separated strings from strList collection. First item of strList "One" will be passed as s1 and the rest of 
            //the items will be passed as s2. The lambda expression (s1, s2) => s1 + ", " + s2 will be treated like s1 = s1 + ", " + s1 where s1 will be accumulated for each item in th ecollection.
            //Thus, Aggregate method will return comma separated string

            //Aggregate method with Seed Value
            // The second overload method of Aggregate requires first parameter for seed value to accumulate. Second parameter is Func type delegate:
            //TAccumulate Aggregate<TSource, TAccumulate>(TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 15}
            };

            var commaSeparatedStudentNames = studentList.Aggregate(
                "Student Names: ", // seed value
                (str, s) => str += s.StudentName + ", ");

            Console.WriteLine(commaSeparatedStudentNames);

            //In the above example, the first parameter of the Aggregate method is the "Student Names: " string that will be accumulated with all student names.
            //The comma in the lambda expression will be passed as a second parameter

            //The following example use Aggregate operator to add the age of all the students

            var SumOfStudentsAge = studentList.Aggregate(0, (age, s) => age += s.Age);

            Console.WriteLine(SumOfStudentsAge);

            //Aggregate method with Result Selector
            //The third overload method of Aggregate requires third parameter of the Func delegate expression for the result selector, so that you can formulate the result
            var commaSeparatedStudentNames1 = studentList.Aggregate(
                string.Empty, // seed value
                (str, s) => str +=
                    s.StudentName +
                    ",", // returns result using seed value, String.Empty goes to lambda expression as str
                str => str.Substring(0, str.Length - 1));

            Console.WriteLine(commaSeparatedStudentNames1);

            //In the above example, we have specified a lambda expression str => str.Substring(0, str.Length - 1) which will remove the last comma in the string result.
            //Aggregate operator is NOT SUPPORTED with query syntax in C# and VB.Net


            Console.WriteLine();


            int[] intNumbers = {3, 5, 7, 9};

            var result = intNumbers.Aggregate((n1, n2) => n1 * n2);

            Console.WriteLine(result);

            Console.WriteLine();


            var result1 = intNumbers.Aggregate(2, (n1, n2) => n1 * n2);

            Console.WriteLine(result1);

            /*How does it work?
             * 
             * Step1: First it multiplies (2*3) to produce the result as 6
             * Step2: Result of Step 1 i.e. 6 is then multiplied with 5 to produce the result as 30
             * Step3: Result of Step 2 i.e. 30 is then multiplied with 7 to produce the result as 210.
             * Step4: Result of Step 3 i.e. 210 is then multiplied with 9 to produce the final result as 1890.
             */

            //Aggregate Method with complex type

            var Salary = Employee.GetAllEmployees()
                .Aggregate(0,
                    (TotalSalary, emp) => TotalSalary += emp.Salary);

            //Please note that here we passed the seed value as 0. Once you run the application, it gives you the output as expexted
            Console.WriteLine();
            Console.WriteLine(Salary);

            var CommaSeparatedEmployeeNames = Employee.GetAllEmployees().Aggregate(
                "Employee Names : ", // seed value
                (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ", ");

            var LastIndex = CommaSeparatedEmployeeNames.LastIndexOf(",");
            CommaSeparatedEmployeeNames = CommaSeparatedEmployeeNames.Remove(LastIndex);

            Console.WriteLine(CommaSeparatedEmployeeNames);

            //Aggregate method with result selector
            //The third overload version requires the third parameter of the Func delegate expression for the result selector
            //so that we can formulate the result. In our previous example, once we get the comma-separated string then we remove the last comma using some additional logic. 

            var CommaSeparatedEmployeeNames1 = Employee.GetAllEmployees().Aggregate(
                "Employee Names : ", // seed value
                (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ",",
                employeeNames => employeeNames.Substring(0, employeeNames.Length - 1));

            Console.WriteLine(CommaSeparatedEmployeeNames1);
        }
    }

}