namespace LINQAllDemo
{

    using System;
    using System.Linq;

    internal class AllProgram
    {
        private static void Main()
        {
            /*The Linq All Operator in C# is used to check whether all the elements of a data source satisfy a given condition or not. If all the elements satisfy the condition,
             * then it returns true else return false. There is no overloaded version is available for the All method.
             */

            int[] IntArray = {11, 22, 33, 44, 55};
            var Result = IntArray.All(x => x > 10);
            Console.WriteLine("Are All Numbers are greater than 10 : " + Result);

            string[] stringArray = {"James", "Sachin", "Sourav", "Pam", "Sara"};
            var Result1 = stringArray.All(name => name.Length > 5);
            Console.WriteLine("Are All Names greater than 5 Characters : " + Result1);

            Console.WriteLine();

            var MSResult = Student.GetAllStudnets().All(std => std.TotalMarks > 250);

            Console.WriteLine(MSResult);

            // Using Method Syntax
            var MethodSResult = Student.GetAllStudnets()
                .Where(std => std.Subjects.All(x => x.Marks > 80)).ToList();

            foreach (var item in MethodSResult)
            {
                Console.WriteLine(item.Name + " " + item.TotalMarks);
            }
        }
    }

}