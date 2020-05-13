namespace LINQConcatDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqConcatProgram
    {
        private static void Main()
        {
            //The Concat() method appends two sequences of the same type and returns a new sequence (collection).

            IList<string> collection1 = new List<string> {"One", "Two", "Three"};
            IList<string> collection2 = new List<string> {"Five", "Six"};

            var concateResult = collection1.Concat(collection2);

            foreach (var str in concateResult)
            {
                Console.WriteLine(str);
            }

            IList<int> collection4 = new List<int> {1, 2, 3};
            IList<int> collection5 = new List<int> {4, 5, 6};

            var collection6 = collection4.Concat(collection5);

            foreach (var i in collection6)
            {
                Console.WriteLine(i);
            }

            //Note: While working with the Concat operator if any of the sequences is null then it will throw an exception.
            //Concat operator is not supported in query syntax in C# or VB.Net.
        }
    }

}