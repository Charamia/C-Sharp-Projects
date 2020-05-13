namespace DiffrentWaysToWriteLINQQuery
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///     Defines the <see cref="WaysToWriteLINQQuery" />.
    /// </summary>
    internal class WaysToWriteLINQQuery
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            //LINQ Query Syntax 

            //Data sourse
            var integerList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //LINQ Query using Query Syntax
            var QuerySyntax = from obj in integerList
                where obj > 5
                select obj;

            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            //LINQ Query using Method Synntax

            var methodSyntax = integerList.Where(obj => obj > 5).ToList();

            //Execution

            foreach (var item in methodSyntax)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //LINQ Query using Mixed Syntax
            var mixedSyntax = (from obj in integerList
                where obj > 5
                select obj).Sum();

            //Execution
            Console.Write("Sum is " + mixedSyntax);
            Console.WriteLine();
        }
    }

}