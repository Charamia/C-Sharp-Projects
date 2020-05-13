namespace LINQMaxDemo
{

    using System;

    internal class Student : IComparable<Student>
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

        public int CompareTo(Student other)
        {
            if (StudentName.Length >= other.StudentName.Length)
            {
                return 1;
            }

            return 0;
        }
    }

}