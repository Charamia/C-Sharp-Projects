namespace LINQOfTypeDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class OfTypeProgram
    {
        private static void Main()
        {
            /*
             * The OfType Operator in LINQ is used to filter specific type data from a data source based on the data type we passed to this operator. For example, if we have a collection 
             * that stores both integer and string values and if we need to fetch either only the integer values or only the string values from that collection then we need to use the 
             * OfType operator.
             * 
             * Following is the signature of the OfType method. It is implemented as a generic type, so there are no overloaded versions available for this method. This method can take 
             * any type of data type and then fetch the specified data type values from the collection.
             */

            var dataSource = new List<object>
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };

            var intData = dataSource.OfType<int>().ToList();

            foreach (var number in intData)
            {
                Console.Write(number + " ");
            }


            //OfType Operator Using Query Syntax in C#.NET:
            //There is no such OfType operator available in query syntax. Instead “is” operator is available which we can use to filter data based on a type from a data source. In the following
            //example, the collection contains both string and integer values and we need to fetch only the string values.

            var dataSource1 = new List<object>
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
            var stringData = (from name in dataSource1
                where name is string
                select name).ToList();
            Console.WriteLine();
            foreach (string name in stringData)
            {
                Console.Write(name + " ");
            }

            //OfType and is Operator with a condition in C#.NET:
            //Let say, we want to retrieve all the names whose length is greater than 3 and all the integer number which is greater than 30. Here we will use OfType operator to retrieve all 
            //the names and “is” operator to retrieve all the integers along with the required conditions.

            var dataSource3 = new List<object>
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };

            Console.WriteLine();

            //Using Method Syntax
            var intData1 = dataSource3.OfType<int>().Where(num => num > 30).ToList();
            foreach (var number in intData1)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            //Using Qyery Syntax
            var stringData3 = (from name in dataSource
                where name is string && name.ToString().Length > 3
                select name).ToList();

            foreach (string name in stringData3)
            {
                Console.Write(name + " ");
            }
        }
    }

}