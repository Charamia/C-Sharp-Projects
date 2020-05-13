namespace LINQDistinctDemo
{

    using System.Collections.Generic;
    using LINQ.Infrastructure;

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }

        //Now we can pass an object of the above StudentComparer class in th eDistinct() method as a parameter to compare the Student objects
    }

}