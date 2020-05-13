namespace LINQAnyDemo
{

    using System;
    using System.Linq;

    internal class AnyProgram
    {
        private static void Main()
        {
            int[] IntArray = {11, 22, 33, 44, 55};

            //Using Method Syntax

            var ResultMS = IntArray.Any();

            //Using Query Syntax
            var ResultQS = (from num in IntArray
                select num).Any();

            Console.WriteLine("Are there any elements in the collection : " + ResultMS);

            Console.WriteLine();

            var Result = IntArray.All(x => x > 10);

            Console.WriteLine("Are All Numbers are greater than 10 : " + Result);

            Console.WriteLine();

            string[] stringArray = {"James", "Sachin", "Sourav", "Pam", "Sara"};

            //Method Syntax
            var ResultMethodS = stringArray.Any(name => name.Length > 5);

            //Query Syntax
            var ResultQueryS = (from name in stringArray
                select name).Any(name => name.Length > 5);

            Console.WriteLine("Is Any name with length  greater than 5 Characters : " + ResultMethodS);

            Console.WriteLine();

            var MSResult = Student.GetAllStudnets().Any(std => std.TotalMarks > 250);

            //Using Query Syntax
            var QSResult = (from std in Student.GetAllStudnets()
                select std).Any(std => std.TotalMarks > 250);

            Console.WriteLine(MSResult);
            Console.WriteLine();

            var MethodSResult = Student.GetAllStudnets()
                .Where(std => std.Subjects.Any(x => x.Marks > 90)).ToList();

            foreach (var item in MethodSResult)
            {
                Console.WriteLine(item.Name + " " + item.TotalMarks);
            }
        }
    }

}