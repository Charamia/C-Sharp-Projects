using System;
using System.Collections.Generic;
using LINQ.ICompar;

namespace LINQ.IComparerInfrastructure
{

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}    
