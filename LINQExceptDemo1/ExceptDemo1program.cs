namespace LINQExceptDemo1
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ExceptDemo1program
    {
        private static void Main()
        {
            /* The LINQ Except Method in C# is used to return the elements which are present in the first data source but not in the second data source. 
             * There are two overloaded versions available for the LINQ Except Method as shown below.
             * 
             * public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
             * 
             * public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
             * 
             * The one and the only difference between the above two methods is the second overloaded version takes IEqualityComparer as an argument. That means the Except Method can also be used with Comparer too.
             */


            var dataSource1 = new List<int> {1, 2, 3, 4, 5, 6};
            var dataSource2 = new List<int> {1, 3, 5, 8, 9, 10};

            //Method Syntax

            var MS = dataSource1.Except(dataSource2).ToList();

            //Query Syntax

            var QS = (from num in dataSource1
                    select num)
                .Except(dataSource2).ToList();

            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }

            //Here we have a string array of countries and we need to return the countries from the first collection, those are not present in the second collection.

            Console.WriteLine();

            string[] stringDataSource1 = {"India", "USA", "UK", "Canada", "Srilanka"};
            string[] stringDataSource2 = {"India", "uk", "Canada", "France", "Japan"};

            //Method Syntax
            var methodsyntax = stringDataSource1.Except(stringDataSource2).ToList();

            //Query Syntax

            var querySyntax = (from country in stringDataSource1
                    select country)
                .Except(stringDataSource2).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            /*
             * In spite of having the country UK in the second collection, it still shows in the output. This is because the default comparer that is being used to filter the data is case-insensitive.
             * So if you want to ignore the case-sensitive then you need to use the other overloaded version of the Except() method which takes IEqualityComparer as an argument.
             * So, modify the program as shown where we pass StringComparer as an argument and this StringComparer class already implements the IEqualityComparer interface.
             * 
             */

            //Method Syntax

            var methodSyn = stringDataSource1.Except(stringDataSource2, StringComparer.OrdinalIgnoreCase).ToList();

            //Query Syntax

            var querySyn = (from country in stringDataSource1
                    select country)
                .Except(stringDataSource2, StringComparer.OrdinalIgnoreCase).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var AllStudents = new List<Student>
            {
                new Student {ID = 101, Name = "Preety"},
                new Student {ID = 102, Name = "Sambit"},
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
                new Student {ID = 106, Name = "Santosh"}
            };
            var Class6Students = new List<Student>
            {
                new Student {ID = 102, Name = "Sambit"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"}
            };

            Console.WriteLine();

            //Method Syntax

            var methodsyntaxOnComplextype =
                AllStudents.Select(x => x.Name).Except(Class6Students.Select(y => y.Name)).ToList();

            //Query Syntax

            var querySyntaxOnComplexType = (from std in AllStudents
                select std.Name).Except(Class6Students.Select(y => y.Name)).ToList();

            foreach (var name in methodsyntaxOnComplextype)
            {
                Console.WriteLine(name);
            }

            //All the information for the students from th efirst list, except the ones from the second

            //Method Syntax

            Console.WriteLine();

            var MSyntax = AllStudents.Select(x => new {x.ID, x.Name})
                .Except(Class6Students.Select(x => new {x.ID, x.Name})).ToList();


            //Query Syntax

            var QSyntax = (from std in AllStudents
                    select new {std.ID, std.Name})
                .Except(Class6Students.Select(x => new {x.ID, x.Name})).ToList();


            foreach (var student in MSyntax)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }
        }
    }

}