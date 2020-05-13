namespace LINQOrderByDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class OrderByProgram
    {
        private static void Main()
        {
            /*The Linq OrderBy method in C# is used to sort the data in ascending order. The most important point that you need to keep in mind is this method is not going to change
             * the data rather it is just changing the order of the data.
             * 
             * Example1: Working with integer data
             */

            var intList = new List<int> {10, 45, 35, 29, 100, 69, 58, 50};

            Console.WriteLine("Before Sorting : ");

            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }

            //Sorting the data in Ascending Order
            //Using Method Syntax

            var MS = intList.OrderBy(num => num);

            //Using Query Syntax

            var QS = (from num in intList
                orderby num
                select num).ToList();

            Console.WriteLine();

            Console.WriteLine("After Sorting : ");

            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            var stringList = new List<string>
                {"Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan", "Hina", "Kumar", "Manoj", "Rout", "James"};

            //Using Method Syntax

            var methodSyntax = stringList.OrderBy(name => name);

            //Using Query Syntax

            var querySyntax = (from name in stringList
                orderby name
                select name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item + " ");
            }

            //Using OredBy with complex type of data
            Console.WriteLine();

            var orderByMethodSyntax = Student.GetAllStudents().OrderBy(x => x.Branch).ToList();

            var orderByQuerySyntax = from std in Student.GetAllStudents()
                orderby std.Branch
                select std;

            foreach (var student in orderByMethodSyntax)
            {
                Console.WriteLine("Branch " + student.Branch + " Name " + student.FirstName + " " + student.LastName);
            }
            //Example sorting with filters

            Console.WriteLine();

            var mSWithFilters = Student.GetAllStudents()
                .Where(std => std.Branch.ToUpper() == "CSE")
                .OrderBy(x => x.FirstName).ToList();

            var qSWithFilters = from std in Student.GetAllStudents()
                where std.Branch.ToUpper() == "CSE"
                orderby std.FirstName
                select std;

            foreach (var std in mSWithFilters)
            {
                Console.WriteLine("Branch " + std.Branch + " Name " + std.FirstName + " " + std.LastName);
            }
        }
    }

}