namespace SelectManyDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SMProgram
    {
        private static void Main()
        {
            //The SelectMany in LINQ is used to project each element of a sequence to an IEnumerable<T> and then flatten the resulting sequences into one sequence. 
            //That means the SelectMany operator combines the records from a sequence of results and then converts it into one result.

            var nameList = new List<string> {"Pranaya", "Kumur"};

            var methodSyntax = nameList.SelectMany(x => x);

            foreach (var c in methodSyntax)
            {
                Console.Write(c + " ");
            }

            //SelectMany operator using Syntax in c#.NET

            //The most important point is that there is no such SelectMany operator available in LINQ to write query syntax. But we can achieve this by writing multiple 
            //“from clause” in the query as shown in the below example.

            var nameList1 = new List<string> {"Pranaya", "Kumar"};

            var querySyntax = from str in nameList1
                from ch in str
                select ch;

            Console.WriteLine();
            //LINQ SelectMany Operator with Complex Type

            //Усинг Метход Сънтаь 
            var MethodSyntax = Student.Getstudents().SelectMany(std => std.Programming).ToList();

            //Using Query syntax

            var QuerySyntax = from std in Student.Getstudents()
                from program in std.Programming
                select program;

            foreach (var program in MethodSyntax)
            {
                Console.WriteLine(program);
            }

            //In our previous example, we get the output as expected but with the duplicate program names. If you want only the distinct program names then you need to apply the distinct method on the 
            //result set as shown in the below examples.

            var MethodSyntax1 = Student.Getstudents()
                .SelectMany(std => std.Programming)
                .Distinct()
                .ToList();

            //using Query syntax 
            IEnumerable<string> QuerySyntax1 = (from std in Student.Getstudents()
                from program in std.Programming
                select program).Distinct().ToList();

            //Retrive the srudent name along with the program language name

            var methodSyntax3 = Student.Getstudents()
                .SelectMany(std => std.Programming,
                    (student, program) => new
                    {
                        StudentName = student.Name,
                        ProgramName = program
                    }).ToList();

            //using query syntax

            var QuerySyntax2 = (from std in Student.Getstudents()
                from program in std.Programming
                select new
                {
                    StudentName = std.Name,
                    ProgramName = program
                }).ToList();

            foreach (var item in QuerySyntax2)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }
        }
    }

}