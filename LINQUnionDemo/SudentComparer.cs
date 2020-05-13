namespace LINQUnionDemo
{

    using System.Collections.Generic;
    using LINQ.Infrastructure;

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower()
            ) // the shorter version of this code is return x.StudentId == y.StydentId && x.StudentName == y.StudentName;
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }

}