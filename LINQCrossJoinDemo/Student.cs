namespace LINQCrossJoinDemo
{

    using System.Collections.Generic;

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Student> GetAllStudnets()
        {
            return new List<Student>
            {
                new Student {ID = 1, Name = "Preety"},
                new Student {ID = 2, Name = "Priyanka"},
                new Student {ID = 3, Name = "Anurag"},
                new Student {ID = 4, Name = "Pranaya"},
                new Student {ID = 5, Name = "Hina"}
            };
        }
    }

}