namespace LINQSequenceEqualDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LINQ.Infrastructure;

    internal class LINQSecEqualProgram
    {
        private static void Main()
        {
            /*The SequenceEqual Operator in Linq is used to check whether two sequences are equal or not. If two sequences are equal then it returns true else it returns false.
             *Two sequences are considered to be equal when both the sequences have the same number of elements as well as the same values should be present in the same order.
             * There are two overloaded versions available for this SequenceEqual method 
             * The second overloaded versions take an extra IEqualityComparer parameter
             *  The following example demonstrates the SequenceEqual method with the collection of primitive data types.
             */

            IList<string> strList1 = new List<string> {"One", "Two", "Three", "Four", "Three"};

            IList<string> strList2 = new List<string> {"One", "Two", "Three", "Four", "Three"};

            IList<string> strList3 = new List<string> {"Two", "One", "Three", "Four", "Three"};

            var isEqual = strList1.SequenceEqual(strList2);

            Console.WriteLine(isEqual);

            //If the order of elements are not the same then SequenceEqual() method returns false

            var isEqual1 = strList1.SequenceEqual(strList3);

            Console.WriteLine(isEqual1);

            //The SequenceEqual extension method checks the references of two objects to determine whether two sequences are equal or not. This may give wrong result. Consider following example:

            var std = new Student {StudentID = 1, StudentName = "Bill"};

            IList<Student> studentList1 = new List<Student> {std};

            IList<Student> studentList2 = new List<Student> {std};

            var isStudentsEqual = studentList1.SequenceEqual(studentList2); // returns true

            Console.WriteLine(isStudentsEqual);

            var std1 = new Student {StudentID = 1, StudentName = "Bill"};

            var std2 = new Student {StudentID = 1, StudentName = "Bill"};

            IList<Student> studentList3 = new List<Student> {std1};

            IList<Student> studentList4 = new List<Student> {std2};

            isStudentsEqual = studentList3.SequenceEqual(studentList4); // returns false

            Console.WriteLine(isStudentsEqual);


            /*
             * In the above example, studentList1 and studentList2 contains the same student object, std. So studentList1.SequenceEqual(studentList2) returns true. But, stdList1 and stdList2 contains
             * two seperate student object, std1 and std2. So now, stdList1.SequenceEqual(stdList2) will return false even if std1 and std2 contain the same value.
             * 
             * To compare the values of two collection of complex type (reference type or object), you need to implement IEqualityComperar<T> interface as done in SudentComparere class
             * Now we can use StudentComparer class in SequenceEqual extension method as a second parameter to compare the values
             */

            IList<Student> studentList5 = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John"},
                new Student {StudentID = 2, StudentName = "Steve"},
                new Student {StudentID = 3, StudentName = "Bill"},
                new Student {StudentID = 4, StudentName = "Ram"},
                new Student {StudentID = 5, StudentName = "Ron"}
            };

            IList<Student> studentList6 = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John"},
                new Student {StudentID = 2, StudentName = "Steve"},
                new Student {StudentID = 3, StudentName = "Bill"},
                new Student {StudentID = 4, StudentName = "Ram"},
                new Student {StudentID = 5, StudentName = "Ron"}
            };

            var isEqual5and6 = studentList5.SequenceEqual(studentList6, new StudentComparer());

            Console.WriteLine(isEqual);

            /* The default comparer to the SequencesEqual method is case sensitive
             * The SequenceEqual method compares the number of items and their values for primitive data types.
             * The SequenceEqual method compares the reference of objects for complex data types.
             * Use IEqualityComparer class to compare two colection of complex type using SequenceEqual method.
             * Note: If you go the definition of StringComparer class, then you will see that this class implements the IEqualityComparer interface
             * 
             * 
             * When comparing the complex types, the default comparer which is used by the SequenceEqual method will only check if the object references are equal or not.
             * 
             * There are many ways to solve the above problem:
             *  1. We need to use the other overloaded version of the SequenceEqual method to which we can pass a custom class that implements the IEqualityComparer interface.
             *  2. Project the properties into a new anonymous type, which overrides Equals() and GetHashCode() methods.
             *  3. In the Student class override the Equals() and GetHashCode() methods.
             *  4. Using Anonymous Type:
             * 
             */
        }
    }

}