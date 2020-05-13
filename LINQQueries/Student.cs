namespace LINQQueries
{

    using System;
    using System.Collections.Generic;

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + DateOfBirth.Year + "." + DateOfBirth.Month + "." + DateOfBirth.Date + " " +
                   Courses.Count;
        }
    }

}