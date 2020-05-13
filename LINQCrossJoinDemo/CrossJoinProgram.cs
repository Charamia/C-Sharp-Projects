namespace LINQCrossJoinDemo
{

    using System;
    using System.Linq;

    internal class CrossJoinProgram
    {
        private static void Main()
        {
            /* When combining two data sources (or two collections) using Linq Cross Join, then each element in the first data source (i.e. first collection)
             * will be mapped with each and every element in the second data source (i.e. second collection). So, in simple words, we can say that the Cross Join produces
             * the Cartesian Products of the collections or data sources involved in the join.
             * 
             * In Cross Join we don’t require the common key or property as the “on” keyword which is used to specify the Join Key. Moreover, there is no
             * filtering of the data. So, the total number of elements in the result sequence will be the product of the two data sources involved in the join. If the first
             * data source contains 5 elements and the second data source contains 3 elements then the resultant sequence will contain (5*3) 15 elements.
             * 
             */

            //In order to implement the Cross Join using method syntax, we need to use either the SelectMany() method or the Join() method as shown in the below example.

            //Cross Join using SelectMany Method
            var CrossJoinResult = Student.GetAllStudnets()
                .SelectMany(sub => Subject.GetAllSubjects(),
                    (std, sub) => new
                    {
                        std.Name,
                        sub.SubjectName
                    });
            //Cross Join using Join Method
            var CrossJoinResult2 = Student.GetAllStudnets()
                .Join(Subject.GetAllSubjects(),
                    std => true,
                    sub => true,
                    (std, sub) => new
                    {
                        std.Name,
                        sub.SubjectName
                    }
                );
            foreach (var item in CrossJoinResult2)
            {
                Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
            }

            //Cross Join Using Query Syntax

            var CrossJoinResultQS = from employee in Student.GetAllStudnets()
                from subject in Subject.GetAllSubjects()
                select new
                {
                    employee.Name,
                    subject.SubjectName
                };
            foreach (var item in CrossJoinResultQS)
            {
                Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
            }
        }
    }

}