namespace LINQGroupByDemo
{

    using System;
    using System.Linq;

    internal class GoupBYProgram
    {
        private static void Main()
        {
            /*
             * The Linq GroupBy Method in C# belongs to the Grouping Operators category and exactly does the same thing as the Group By clause does in SQL Query. This method takes
             * a flat sequence of elements and then organizes the elements into groups (i.e. IGrouping<TKey, TSource>) based on a given key.
             * 
             * The following example organizes the students into groups based on their branch (i.e. branch will act as the key). That means students with the same branch will be 
             * stored in the same group where each group having a key and an inner collection. Here, the key will be branch and the collection will be the student belongs to that particular branch.
             */

            // Using Method Syntax

            var GroupByMS = Student.GetStudents().GroupBy(s => s.Barnch);

            //Using Query Syntax

            var GroupByQS = from std in Student.GetStudents()
                group std by std.Barnch;
            //It will iterate through each groups

            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group

                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" +
                                      student.Gender);
                }
            }
            //Note: Each group has a key and you can access the key-value by using the key property. Along the same line, you can use the count property to check how many 
            //elements are there in that group.

            //In the following example, we get the employees by Gender. But here we first sort the data by Gender in descending order and then sort the student by their name in ascending order.

            var methodSyntaxGroupBy = Student.GetStudents().GroupBy(s => s.Gender)
                //First sorting the data based on key in Descending Order
                .OrderByDescending(c => c.Key)
                .Select(std => new
                {
                    std.Key,
                    //Sorting the data based on name in descending order
                    Students = std.OrderBy(x => x.Name)
                });

            //It will iterate through each groups

            foreach (var group in methodSyntaxGroupBy)
            {
                Console.WriteLine(group.Key + " : " + group.Students.Count());
                //Iterate through each student of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" +
                                      student.Barnch);
                }

                //In the above example the result is projected to an anonymous type
            }
        }
    }

}