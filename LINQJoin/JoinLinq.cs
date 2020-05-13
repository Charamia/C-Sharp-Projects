/*
 * Points to Remember :
Join and GroupJoin are joining operators.
Join is like inner join of SQL. It returns a new collection that contains common elements from two collections whose keys match.
Join operates on two sequences inner sequence and outer sequence and produces a result sequence.
Join query syntax:
from... in outerSequence
join... in innerSequence 
on  outerKey equals innerKey
select ...
 * */

namespace LINQJoin
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EmployeeInfo;

    public class JoinLinq
    {
        public static void Main()
        {
            // Student collection
            IList<string> strList1 = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four"
            };

            IList<string> strList2 = new List<string>
            {
                "One",
                "Two",
                "Five",
                "Six"
            };

            var innerJoinResult = strList1.Join( // outer sequence 
                strList2, // inner sequence 
                str1 => str1, // outerKeySelector
                str2 => str2, // innerKeySelector
                (str1, str2) => str1);

            foreach (var str in innerJoinResult)
            {
                Console.WriteLine("{0} ", str);
            }

            // Student collection
            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1},
                new Student {StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2},
                new Student {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            IList<Standard> standardList = new List<Standard>
            {
                new Standard {StandardID = 1, StandardName = "Standard 1"},
                new Standard {StandardID = 2, StandardName = "Standard 2"},
                new Standard {StandardID = 3, StandardName = "Standard 3"}
            };

            var innerJoinResult1 = studentList.Join( // outer sequence 
                standardList, // inner sequence 
                student => student.StandardID, // outerKeySelector
                standard => standard.StandardID, // innerKeySelector
                (student, standard) => new // result selector
                {
                    student.StudentName,
                    standard.StandardName
                });

            foreach (var obj in innerJoinResult1)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }

            Console.WriteLine();

            //Join operator in query syntax C#
            Console.WriteLine("Join operator in query syntax C#");
            Console.WriteLine();

            var innerJoinResult2 = from s in studentList // outer sequence
                join st in standardList //inner sequence 
                    on s.StandardID equals st.StandardID // key selector 
                select new
                {
                    // result selector 
                    s.StudentName,
                    st.StandardName
                };

            foreach (var obj in innerJoinResult2)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }

            //The most important point that you need to understand is while performing join you need the common property!!!!!
            //What are the Methods available in Linq to Perform the Join Operations?
            //Join: This operator is used to join two data sources or collection based on common property and return the data as a single result set.
            //GroupJoin: This operator is also used to join two data sources or collections based on a common key or property but return the result as a group of sequences.

            //What are the different types of Linq Joins available in C#?
            //We can perform different types of joins such as Inner Join, Left Join, Right Join, Full Join, and Cross Join in Linq.

            //Inner join
            /* As per the Microsoft documentation “An inner join produces a result set in which each element of the first collection appears one time for every matching
             * element in the second collection. If an element in the first collection does not have any matching element in the second collection, then it does not appear in the result set”.
             * In simple words, we can say that the Linq Inner join is used to return only the matching elements from both the data sources while the non-matching elements are removed from
             * the result set. So, if you have two data sources, when we perform the LINQ inner join, only the matching elements which exist in both the data sources will be included in the result set. 
             * 
             *  There are two overloaded versions available in Linq to perform inner join operations. The second overloaded version takes a comparer as an extra parameter.
             *  
             *  So, while working with Linq Join you need to understand the following five things.
             *  
             *  1.Outer data source
             *  2.Inner data source
             *  3.Outer Key selector (common key in the outer data source)
             *  4.Inner Key selector (Common key in the inner data source)
             *  5.Result selector (project the data into a result set)

             */

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            var innerJoinUsingMS = Employee.GetAllEmployees() //Outer Data Source
                .Join(
                    Address.GetAllAddresses(), //Inner Data Source
                    employee => employee.AddressId, //Inner Key Selector
                    address => address.ID, //Outer Key selector
                    (employee, address) => new //Projecting the data into a result set
                    {
                        EmployeeName = employee.Name,
                        address.AddressLine
                    }).ToList();
            foreach (var employee in innerJoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }

            Console.ReadLine();


            //The above example written in LINQ Query syntax:
            /*
              var JoinUsingQS = (from emp in Employee.GetAllEmployees()
                               join address in Address.GetAllAddresses()
                               on emp.AddressId equals address.ID
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();
            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            Console.ReadLine();
         
             */

            //LINQ Join with Multiple data sources
            //Note: If you want to fetch the data from two data sources then you can use either 
            //the Method syntax or Query Syntax. But if you want to fetch the data from more than two data sources then it is easier to use the Query syntax rather than the Method syntax.
        }
    }

}