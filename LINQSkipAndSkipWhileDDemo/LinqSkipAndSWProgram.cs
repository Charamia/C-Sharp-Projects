namespace LINQSkipAndSkipWhileDDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqSkipAndSWProgram
    {
        private static void Main()
        {
            //Partitioning operators split the sequence (collection) into two parts and return one of the parts.
            /*The Skip Method in Linq is used to skip or bypass the first “n” number of elements from a data source 
             * or sequence and then returns the remaining elements from the data source as output. Here “n” is an integer value passed to the Skip method as a parameter. 
             * 
             */

            IList<string> strList = new List<string> {"One", "Two", "Three", "Four", "Five", "Six"};

            var result = strList.Skip(2);

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            //The Skip & SkipWhile operator are Not Supported in C# query syntax. However, we can use Skip/SkipWhile method on a query 
            //variable or wrap whole query into brackets and then call Skip/SkipWhile.


            // In the following example, SkipWhile() method skips all elements till it finds a string whose length is equal or more than 4 characters.


            var skipWhileResult = strList.SkipWhile(s => s.Length < 4);
            Console.WriteLine();
            foreach (var str in skipWhileResult)
            {
                Console.WriteLine(str);
            }

            //The second overload of SkipWhile passes an index of each element. 

            Console.WriteLine();

            var resultList = strList.SkipWhile((s, i) => s.Length > i);

            foreach (var str in resultList)
            {
                Console.WriteLine(str);
            }

            int[] amounts =
            {
                5000, 2500, 9000, 8000,
                6500, 4000, 1500, 5500
            };

            var query =
                amounts.SkipWhile((amount, index) => amount > index * 1000);

            foreach (var amount in query)
            {
                Console.WriteLine(amount);
            }

            //Skip & SkipWhile operator are NOT Supported in C# query syntax. However, we can use Skip/SkipWhile method on a query variable or wrap whole query into brackets 
            //then call Skip/SkipWhile().
            //This method is implemented by using deferred execution. The immediate return value is an object that stores all the information that is required to perform the action.
            //The query represented by this method is not executed until the object is enumerated either by calling its GetEnumerator method directly or by using foreach in Visual
            //C# or For Each in Visual Basic.
        }
    }

}