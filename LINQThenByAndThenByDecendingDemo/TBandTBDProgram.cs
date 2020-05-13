namespace LINQThenByAndThenByDecendingDemo
{

    using System;
    using System.Linq;

    internal class TBandTBDProgram
    {
        private static void Main()
        {
            //The LINQ OrderBy or OrderByDescending method works fine when you want to sort the data based on a single value or a single expression. But if you want to sort the data based
            //on multiple values or multiple expressions then you need to use the LINQ ThenBy and ThenByDescending Method along with OrderBy or OrderByDescending Method.
            //The Linq ThenBy Method in C# is used to sort the data in ascending order from the second level onwards. On the other hand, the  Linq ThenByDescending Method in C# is used to
            //sort the data in descending order also from the second level onwards.
            //These two methods are used along with OrderBy or OrderByDescending method. You can use the ThenBy or ThenByDescending method more than once in the same LINQ query.
            //The OrderBy or OrderByDescending method is generally used for primary sorting. ThenBy or ThenByDescending are used for secondary sorting and so on. For example, first, 
            //sort the student by First Name and then sort the student by the Last Name.

            //Method Syntax
            var MS = Student.GetAllStudents()
                .OrderBy(x => x.FirstName)
                .ThenBy(y => y.LastName)
                .ToList();

            //foreach (var student in MS)
            //{
            //    Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            //}

            var mS = Student.GetAllStudents()
                .OrderBy(x => x.Branch)
                .ThenByDescending(y => y.FirstName)
                .ThenBy(z => z.LastName)
                .ToList();

            foreach (var student in mS)
            {
                Console.WriteLine("Barnch " + student.Branch + ", First Name :" + student.FirstName + ", Last Name : " +
                                  student.LastName);
            }

            Console.WriteLine();

            var methodSyntax = Student.GetAllStudents()
                .Where(x => x.Branch == "CSE")
                .OrderBy(y => y.FirstName)
                .ThenByDescending(z => z.LastName)
                .ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine("Barnch " + student.Branch + ", First Name :" + student.FirstName + ", Last Name : " +
                                  student.LastName);
            }
        }
    }

}