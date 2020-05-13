namespace LINQMaxDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LINQMaxProgram
    {
        private static void Main()
        {
            //The Max operator returns the largest numeric element from a collection 
            //The following example demonstrates Max() on primitive collection

            IList<int> intList = new List<int> {10, 21, 30, 45, 50, 87};

            var largest = intList.Max();

            Console.WriteLine("Largest Element: {0}", largest);

            var largestEvenElements = intList.Max(i =>
            {
                if (i % 2 == 0)
                {
                    return i;
                }

                return 0;
            });

            Console.WriteLine("Largest Even Element: {0}", largestEvenElements);

            //The following example demonstrates Max() method on the complex type collection

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 13},
                new Student {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 15}
            };

            var oldest = studentList.Max(s => s.Age);

            // Console.WriteLine("Oldest Student Age: {0}", oldest);

            //Max returns a result of any data type. The following example shows how you can find a student with the longest name in the collection

            var studentWithLongName = studentList.Max();

            Console.WriteLine("Student ID: {0}, Student Name: {1}", studentWithLongName.StudentID,
                studentWithLongName.StudentName);

            //We can use Min extension method /operator the same way as Max
            //As per the above example, to find the student with the longest name, we need to implement IComparable<T> interface and compare student names's length in CompareTo method. 
            //So now, we can use MAx() method which will use ComapreTo method in order to return appropriate result
            //Max operator IS NOT SuPPORTED in C# Query syntax. However, it is supported in VB.Net 
        }
    }

}