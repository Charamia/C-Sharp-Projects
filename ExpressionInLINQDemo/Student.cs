namespace ExpressionInLINQDemo
{

    using System;
    using System.Linq.Expressions;

    public class Student
    {
        private readonly Func<Student, bool> isTeenAger = s => s.Age > 12 && s.Age < 20;
        private readonly Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

        //In the same way , we can also wrap an Action<t> type delegate with Expression if we don't return a value from the delegate
        private readonly Expression<Action<Student>> printStudentName = s => Console.WriteLine(s.StudentName);
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

}