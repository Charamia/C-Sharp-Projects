namespace SelectManyDemo
{

    using System.Collections.Generic;

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<string> Programming { get; set; }

        public static List<Student> Getstudents()
        {
            return new List<Student>
            {
                new Student
                {
                    ID = 1, Name = "James", Email = "james@j.com", Programming = new List<string> {"C#", "Java", "C++"}
                },
                new Student
                {
                    ID = 2, Name = "Sam", Email = "sara@j.com",
                    Programming = new List<string> {"WCF", "SQL Server", "C#"}
                },
                new Student
                {
                    ID = 3, Name = "Patrik", Email = "Patrik@j.com",
                    Programming = new List<string> {"MVC", "Java", "LINQ"}
                },
                new Student
                {
                    ID = 4, Name = "Sara", Email = "Sara@j.com",
                    Programming = new List<string> {"ADo.Net", "C#", "LINQ"}
                }
            };
        }
    }

}