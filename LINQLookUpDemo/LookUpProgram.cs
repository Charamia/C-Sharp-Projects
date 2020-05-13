namespace LINQLookUpDemo
{

    using System;
    using System.Linq;

    internal class LookUpProgram
    {
        private static void Main()
        {
            //The Linq ToLookup Method in C# exactly does the same thing as the GroupBy Operator does in Linq. The only difference between these two methods is the GroupBy method 
            //uses deferred execution whereas the execution of the ToLookup method is immediate.

            //The following example uses the ToLookup Method to organize the students into groups based on Branch as the key. Here, the key will be branch and the collection 
            //will be the student belongs to that particular branch.

            //Using Method Syntax
            var ToLookupMS = Student.GetStudents().ToLookup(s => s.Barnch);

            //Using Query Syntax
            var ToLookupQS = (from std in Student.GetStudents()
                select std).ToLookup(x => x.Barnch);

            //It will iterate through each group
            foreach (var group in ToLookupMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group

                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" +
                                      student.Gender);
                }
            }

            Console.WriteLine("---------------------------------------------");
            //Using ToLookup with Multiple Keys in C#:
            //The following example uses ToLookup to group the students first by Branch and then by Gender. The student’s 
            //groups first sorted by Branch in descending order and then by Gender in ascending order. Finally, we sort the data in each group by the name in ascending order.

            var ToLookupwithMultipleKeys = Student.GetStudents()
                .ToLookup(x => new {x.Barnch, x.Gender})
                .OrderByDescending(g => g.Key.Barnch).ThenBy(g => g.Key.Gender)
                .Select(g => new
                {
                    Branch = g.Key.Barnch,
                    g.Key.Gender,
                    Students = g.OrderBy(x => x.Name)
                });

            foreach (var group in ToLookupwithMultipleKeys)
            {
                Console.WriteLine(
                    $"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");

                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }

                Console.WriteLine();
            }
        }
    }

}