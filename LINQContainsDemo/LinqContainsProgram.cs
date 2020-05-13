namespace LINQContainsDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqContainsProgram
    {
        private static void Main()
        {
            //The Contains operator checks whether a specified element exists in the collection or not and returns a boolean. 
            //The Contains() extention method has two overloads. The first one requires a value to check in the collection
            //and the second overload meathod requires additional parameter of IEqualityComparer type for custom equality comparison

            IList<int> intList = new List<int> {1, 2, 3, 4, 5};

            // bool result = intList.Contains(10);

            //Console.WriteLine(result);

            // THe above example works well with primitive data types. however, it will not work with a custom class. Contains returnsfalse even if the variable exists. This is because the 
            //Contains extention method only compares reference of an object but not the actual values of the object. So to compare values of the student object, we need to create a
            //class by implementing IEqualityComparer interface, that compares the values of two Student objects and returns boolean.
            //The following is a StudentComparer class that implements IEqualityComparere<Student> interface to compare values of two Students objects:

            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18},
                new Student {StudentID = 2, StudentName = "Moin", Age = 15},
                new Student {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student {StudentID = 5, StudentName = "Ron", Age = 19}
            };

            var std = new Student {StudentID = 3, StudentName = "Bill"};

            var result = studentList.Contains(std, new StudentComparer());

            Console.WriteLine(result);

            // 1. All, Any & Contains are quantifier operators in LINQ
            // 2. All checks if all of the elements in a sequence satisfy the specified condition
            // 3. Any checks if any of the elements in a sequence satisfies the specified condition
            // 4. Contains operator checks whether specified element exists in the collection or not
            // 5. Use custom class that derives IEqualityOperator with Contains to check for the object in the collection
            // 6. All, Any and Contains are not supported in the query syntax in C# or VB.Net

            int[] IntArray = {11, 22, 33, 44, 55};

            //Using Method Syntax
            var IsExistsMS = IntArray.Contains(33);

            //Using Query Syntax
            var IsExistsQS = (from num in IntArray
                select num).Contains(33);

            Console.WriteLine(IsExistsMS);

            var namesList = new List<string> {"James", "Sachin", "Sourav", "Pam", "Sara"};
            //Using Method Syntax
            //This method belongs to System.Collections.Generic namespace

            var existsMS1 = namesList.Contains("Anurag");
            //This method belongs to System.Linq namespace

            var existsMS2 = namesList.AsEnumerable().Contains("Anurag");
            //Using Query Syntax

            var existsQS = (from num in namesList
                select num).Contains("Anurag");

            Console.WriteLine(existsMS2);


            var students = new List<Student>();

            var student1 = new Student {ID = 101, StudentName = "Priyanka", TotalMarks = 275};
            var student2 = new Student {ID = 102, StudentName = "Preety", TotalMarks = 375};

            students.Add(student1);
            students.Add(student1);
            //Using Method Syntax
            var existsMethodsyntax = students.Contains(student1);

            //Mixed
            var existsMixedySyntax = (from num in students
                select num).Contains(student1);

            Console.WriteLine(existsMethodsyntax);


            //The following example return false even though the values that we use are in th edata source. THe reson for that is that LINQ Contains Method in C# is checking 
            //the object refence rather than the actual values

            var methodSyntaxCheck =
                students.Contains(new Student {ID = 101, StudentName = "Priyanka", TotalMarks = 275});

            var student3 = new Student {ID = 101, StudentName = "Priyanka", TotalMarks = 275};

            //using query syntax
            var querysyntaxCheck = (from num in students
                select num).Contains(student3);

            Console.WriteLine(methodSyntaxCheck);

            // var IsExistsMS = students.Contains(new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 }, studentComparer);
        }
    }

}