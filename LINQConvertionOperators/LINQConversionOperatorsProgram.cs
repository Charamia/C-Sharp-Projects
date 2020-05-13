namespace LINQConvertionOperators
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LINQConversionOperatorsProgram
    {
        private static void ReportTypeProperties<T>(T obj)
        {
            Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
            Console.WriteLine("Actual type: {0}", obj.GetType().Name);
        }

        private static void Main()
        {
            /* The Conversion operators in LINQ are useful in converting the type of the elements in a sequence (collection). There are three types of conversion operators:
             * As operators (AsEnumerable and AsQueryable), To operators (ToArray, ToDictionary, ToList and ToLookup), and Casting operators (Cast and OfType).
             * The following table lists all the conversion operators.
             * 
             * |----------------------------------------------------------------------------------------------------------------------|
             * |Method          |   Description                                                                                       |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |AsEnumerable    |Returns the input as IEnumerable<t>                                                                  |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |AsQueryable     |Converts IEnumerable to IQueryable, to simulate a remote query provider                              |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |Cast            |Converts a non-geeric collection to a generic collection  (IEnumerable to IEnumerable<T>)            |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |OfType          |Filters a collection based on a specified type                                                       |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |ToArray         |Converts a collection to array                                                                       |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |ToDictionary    |puts elementns into a Dictionary based on key selection function                                     |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |To List         |Converts collection to List                                                                          |
             * |----------------|-----------------------------------------------------------------------------------------------------|
             * |ToLookup        |Groups elements into Lookup<TKey, TElement>                                                          |
             * -----------------------------------------------------------------------------------------------------------------------|
             * 
             * AsEnumerable & AsQueryable
             * 
             * The AsEnumerable and AsQueryable methods cast or convert a source object to IEnumerable<T> or IQueryable<T> respectively.
             * As we can see in th eexample below AsEnumerable and ASQeryable methods convert compile time to IEnumerable and IQueryable respectively
             * 
             * 
             */


            Student[] studentArray =
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Steve", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 31}
            };

            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.AsEnumerable());
            ReportTypeProperties(studentArray.AsQueryable());

            //Cast
            //Cast does the same thing as AsEnumerable<T?. It casts the sourse object into IEnumerable<T>.

            Console.WriteLine();
            Console.WriteLine("Cast");
            Console.WriteLine();

            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.Cast<Student>());

            //student.Array.Cast<Student>() is the same thing as (IEnumerable<Student>)studentArray but Cast<Student>() is more readable
            /*
             * To Operators: ToArray(), ToList(), ToDictionary()
             * 
             * As the name suggests, ToArray(), ToList(), ToDictionary() method converts a source object into an array, List or Dictionary respectively.
             * To operators force the execution of the query. It forces the remote query provider to execute a query and get the result from the underlying data source e.g. SQL Server database.
             */
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            IList<string> strList = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Three"
            };

            Console.WriteLine("strList type: {0}", strList.GetType().Name);

            var strArray = strList.ToArray(); // converts List to Array

            Console.WriteLine("strArray type: {0}", strArray.GetType().Name);

            IList<string> newList = strArray.ToList(); // converts array into list

            Console.WriteLine("newList type: {0}", newList.GetType().Name);

            // ToDictionary converts a Generic list to a generic dictionary:

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Steve", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 21}
            };
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            //following converts list into dictionary where StudentId is a key
            IDictionary<int, Student> studentDict = studentList.ToDictionary(s => s.StudentID);

            foreach (var key in studentDict.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, studentDict[key].StudentName);
            }
        }
    }

}