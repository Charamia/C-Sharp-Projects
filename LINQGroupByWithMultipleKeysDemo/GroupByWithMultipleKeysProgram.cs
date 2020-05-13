namespace LINQGroupByWithMultipleKeysDemo
{

    using System;
    using System.Linq;

    internal class GroupByWithMultipleKeysProgram
    {
        private static void Main()
        {
            //Using Method Syntax
            var GroupByMultipleKeysMS = Student.GetStudents()
                .GroupBy(x => new {x.Barnch, x.Gender})
                .OrderByDescending(g => g.Key.Barnch).ThenBy(g => g.Key.Gender)
                .Select(g => new
                {
                    Branch = g.Key.Barnch,
                    g.Key.Gender,
                    Students = g.OrderBy(x => x.Name)
                });
            //Using Query Syntax
            var GroupByMultipleKeysQS = from student in Student.GetStudents()
                group student by new
                {
                    student.Barnch,
                    student.Gender
                }
                into stdGroup
                orderby stdGroup.Key.Barnch descending,
                    stdGroup.Key.Gender
                select new
                {
                    Branch = stdGroup.Key.Barnch,
                    stdGroup.Key.Gender,
                    Students = stdGroup.OrderBy(x => x.Name)
                };
            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysQS)
            {
                Console.WriteLine(
                    $"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                //It will iterate through each item of a group

                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }

                Console.WriteLine();

                //In the example above the students are grouped first by Branche in decending order and then by Gender in a
                //scending order, finally the students in each group are sorted by their names in ascending order
            }
        }
    }

}