namespace LINQTakeAndTakeWhileDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LINQTakeAndTW
    {
        private static void Main()
        {
            /*
             * The Partitioning Operations in Linq are used to divide a sequence or you can say data source into two parts and then return one of them as output without changing the 
             * positions of the elements.
             * 
             * We need to use Partitioning operators when we want to perform the following operations.
             *      1.  When you want to select the top n number of records from a data source.
             *      2. If you want to select records from a data source until a specified condition is true.
             *      3. Select records from a data source except for the first n number of records.
             *      4. Skip records from a data source until a specified condition is true and then select all records.
             *      5. It can be used to implement pagination for a data source.
             *  
             *  The following four methods are provided by LINQ to perform Partitioning Operations
             *      1.Take
             *      2. Skip
             *      3. TakeWhile
             *      4. SkipWhile
             *      
             *   The Take Operator in Linq is used to fetch the first “n” number of elements from the data source where “n” is an integer which is passed as a parameter to the Take method. 
             *   Take method will not make any changes to the positions of the elements
             *   
             */

            IList<string> strList = new List<string> {"One", "Two", "Three", "Four", "Five"};

            var newList = strList.Take(2);

            foreach (var str in newList)
            {
                Console.WriteLine(str);
            }
            //Take and TakeWhile operators are not suported in C# query syntax. However, we can use them on query variable or wrap the whole query into brackets and then call Take/TakeWhile()


            Console.WriteLine("------------------------------------------------------------------");
            IList<string> strList1 = new List<string> {"Three", "Four", "Five", "Hundred"};

            var newList1 = strList1.TakeWhile(s => s.Length > 4);

            foreach (var str1 in newList1)
            {
                Console.WriteLine(str1);
            }

            /* In the above example, TakeWhile() includes only first element because the second string element doesn't satisfy the condition.
             * TakeWhile() also passes an index of current element in predicate function. The following example of TakeWhile() method takes elements 
             * till the length of the string element is greater than it's index:
             * 
             */
            Console.WriteLine("------------------------------------------------------------------");

            IList<string> strList3 = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six"
            };

            var resultList = strList3.TakeWhile((s, i) => s.Length > i);

            foreach (var str in resultList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("------------------------------------------------------------------");


            //Our requirement is to take four elements from the collection but the condition is that the elements should be greater than 3. In such cases, first, we need to 
            //filter the data using Where operator and then we need to take the data using Take operator as shown in the below example.
            //If you apply the Filtering Operator after the Take method then you will not get the result as expected
            //When we are applying the Take operator on a data source which is null, then we will get an exception i.e. ArgumentNullException


            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Using Method Syntax

            var ResultMS = numbers.Where(num => num > 3).Take(4).ToArray();
            //Using Mixed Syntax

            var ResultQS = (from num in numbers
                where num > 3
                select num).Take(4).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            //The TakeWhile Method in Linq is used to fetch all the elements from a data source or sequence until a specified condition is true. Once the condition is
            //failed, then the TakeWhile method will not check the rest of the elements presents in the data source even though the condition is true for the remaining elements.
            //The TakeWhile method will not make any changes to the positions of the elements. There are two overloaded versions available
            //The First version of the TakeWhile method returns elements from a sequence as long as the specified condition is true.

            //The second overloaded version of this method returns elements from a sequence as long as the given condition is true.The second parameter of the function 
            //represents the index of the source elements. The element’s index can be used in the logic of the predicate function.
            //What is the difference between where and TakeWhile method in Linq?

            var numbers1 = new List<int> {1, 2, 3, 6, 7, 8, 9, 10, 4, 5};

            //Using takeWhile method
            var Result1 = numbers1.TakeWhile(num => num < 6).ToList();

            Console.WriteLine("Result Of TakeWhile Method: ");
            foreach (var num in Result1)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            //Using Where Method

            var Result2 = numbers1.Where(num => num < 6).ToList();
            Console.WriteLine("Result Of Where Method: ");
            foreach (var num in Result2)
            {
                Console.Write($"{num} ");
            }

            //The difference is that the TakeWhile method checks the conditions from the beginning of the data source. As long as the condition is true it fetches the data.
            //So, in the above example, for the first three elements, the condition is true so it fetches them. Then it checks the fourth elements and condition
            //becomes false. From that point, it will not check the rest of the elements in the data source even though some of the elements (i.e. 4 and 5 present at the end 
            //of the collections) satisfying the condition.

            // On the other hand, the Where method checks each and every element present in the collection. The elements which satisfy the condition will be returned.It does not matter the position
            //of the elements in the sequence.
            //
            //In the following example, we will check the length of the name should be greater than its index position.

            Console.WriteLine();
            Console.WriteLine();
            var names = new List<string> {"Sara", "Rahul", "John", "Pam", "Priyanka"};
            var namesResult = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var name in namesResult)
            {
                Console.Write($"{name} ");
            }

            //In the sequence the fourth element i.e. Pam has length 3 and its index position is 3. So, here the condition is false and hence it will not check the next element.
            //As a result, it only fetches the first three elements from the sequence.
        }
    }

}