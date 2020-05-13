namespace LINQOrderBydecendingDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class OrderByDecendingProgram
    {
        private static void Main()
        {
            //The LINQ OrderByDescending method in C# is used to sort the data in descending order. The point that you need to remember is, the OrderByDescending method is not going to 
            //change the data, it is just changing the order of the data.

            var intList = new List<int> {10, 45, 35, 29, 100, 69, 58, 50};

            Console.WriteLine("Before Sorting the Data: ");

            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }

            //Sorting the data in Descending Order

            //Using Method Syntax

            var MS = intList.OrderByDescending(num => num);

            //Using Query Syntax

            var QS = (from num in intList
                orderby num descending
                select num).ToList();

            Console.WriteLine();

            Console.WriteLine("After Sorting the Data in Descending Order: ");

            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            var stringList = new List<string>
                {"Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan", "Hina", "Kumar", "Manoj", "Rout", "James"};

            //Using Method Syntax

            var methodSyntax = stringList.OrderByDescending(name => name);

            //Using Query Syntax

            var querySytax = (from name in stringList
                orderby name descending
                select name).ToList();


            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();

            var methodSyntaxWithComplexType = Student.GetAllStudents().OrderByDescending(x => x.Branch).ToList();

            var qyerysyntaxWithComplexType = from std in Student.GetAllStudents()
                orderby std.Branch descending
                select std;

            foreach (var student in methodSyntaxWithComplexType)
            {
                Console.WriteLine(" Branch " + student.Branch + " Name " + student.FirstName + " " + student.LastName);
            }

            //Linq OrderByDescending with Filtering Operator.
            //Now we need to fetch only the ETC branch students and then we need to sort the students based on their FirstName in descending order.

            Console.WriteLine();

            var mS = Student.GetAllStudents()
                .Where(x => x.Branch == "ECT")
                .OrderByDescending(x => x.FirstName)
                .ToList();


            var qS = from std in Student.GetAllStudents()
                where std.Branch.ToUpper() == "ETC"
                orderby std.FirstName descending
                select std;

            foreach (var student in qS)
            {
                Console.WriteLine(
                    " Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }
        }
    }

}