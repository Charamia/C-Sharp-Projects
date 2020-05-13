namespace LINQDistinctDemo2
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class DistinctProgram
    {
        private static void Main()
        {
            /*The Set Operators in LINQ are used to produce the result set based on the presence and absence of elements within the same or different data sources.
             * That means these operations are performed either on a single data source or on multiple data sources and in the output some of the data is present
             * and some of the data is absent. 
             * 
             * The LINQ Distinct Method in C# is used to return the distinct elements from a single data source. There are two overloaded versions available for the Distinct Method as shown below.
             * 
             * public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source);
             * 
             * public static IEnumerable<TSource> Distinct<TSource> (this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer);
             */

            //Example1: LINQ Distinct Method on Value Type
            //Here we have an integer collection that contains duplicate integer values. Our requirement is to fetch remove the duplicate values and return only the distinct values as shown below.

            var intCollection = new List<int>
            {
                1, 2, 3, 2, 3, 4, 4, 5, 6, 3, 4, 5
            };

            //Using Method Syntax

            var MS = intCollection.Distinct();

            //Using Query Syntax
            //Note: In query syntax, there is no such operator call distinct, so here we need to use both query and method syntax to achieve the same.

            var QS = (from num in intCollection
                select num).Distinct();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }

            string[] namesArray = {"Priyanka", "HINA", "hina", "Anurag", "Anurag", "ABC", "abc"};

            //If you want to make the comparison to be case-insensitive then you need to use the other overloaded version which takes IEqualityComparer as an argument.
            //So here we need to pass a class which must implement the IEqualityComparer interface.

            var distinctNames = namesArray.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
            }

            //LINQ Distinct Operation with Complex Type:
            //The LINQ Distinct Method works in a different manner with complex types like Employee, Product, Student, etc.

            //Using Method Syntax

            Console.WriteLine();

            var methodSyntax = Student.GetStudents()
                .Select(std => std.Name)
                .Distinct().ToList();

            //Using Query Syntax

            var querySyntax = (from std in Student.GetStudents()
                    select std.Name)
                .Distinct().ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            //Now we need to select distinct students from the collection. As you can see in our collection three students are identical and in our result set, they should appear only once.
            //If we run the code above it will select all the students rather than the distinct students only. This is because the default comparer which is used for comparison is only checked 
            //whether two object references are equal and not the individual property values of the complex object.
            //We can solve the above problem in four different ways. They are as follows
            /*
             * 1. We need to use the other overloaded version of Distinct() method which takes IEqualityComparer interface as an argument. So here we will create a class that implements IEqualityComparer
             * interface and then we need to pass that compare instance to the Distinct() method.
             * 
             * 2. In the second approach, we need to override the Equals() and GetHashCode() methods within the Student class itself.
             * 
             * 3. In the third approach, we need to project the required properties into a new anonymous type, which already overrides the Equals() and GetHashCode() methods
             * 
             * 4. By Implementing IEquatable<T> interface.
             */

            Console.WriteLine();

            //Creating an instance of StudentComparer
            var studentComparer = new StudentComparer();

            //Using Method Syntax

            var MSusingMethodSyntax = Student.GetStudents()
                .Distinct(studentComparer).ToList();

            //Using Query Syntax

            var usingQuarySyntax = (from std in Student.GetStudents()
                    select std)
                .Distinct(studentComparer).ToList();


            foreach (var item in usingQuarySyntax)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }

            //Approach3: Using Anonymous Type
            //Here we need to project the properties of Student class into a new anonymous type, which already overrides the Equals() and GetHashCode() methods.

            //Using Method Syntax

            var methodSyntaxUsingAnonymousType = Student.GetStudents()
                .Select(std => new {std.ID, std.Name})
                .Distinct().ToList();

            //Using Query Syntax

            var querySyntaxusingAnonymousType = (from std in Student.GetStudents()
                    select std)
                .Select(std => new {std.ID, std.Name})
                .Distinct().ToList();

            foreach (var item in methodSyntaxUsingAnonymousType)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }

            //In the above example, we project the ID and Name properties to IEnumeable<’a> means to anonymous type which already overrides the Equals and GetHashCode method.

            //Approach4: Implementing the IEquatble<T> interface in Student Class.
            /*Difference between IEqualityComparer<T> and IEquatable<T>:
             * 
             * The IEqualityComparer<T> is an interface for an object that performs the comparison on two objects of the type T whereas the IEquatable<T> is also an interface 
             * for an object of type T so that it can compare itself to another.
             * 
             */
        }
    }

}