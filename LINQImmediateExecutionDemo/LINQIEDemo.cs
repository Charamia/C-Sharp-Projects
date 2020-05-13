namespace LINQImmediateExecutionDemo
{

    internal class LINQIEDemo
    {
        private static void Main()
        {
            /* Immediate Execution of LINQ Query
             * 
             * Immediate execution is the reverse of deferred execution. It forces the LINQ query to execute and gets the result immediately. 
             * The 'To' conversion operators execute the given query and give the result immediately.
             * 
             * Method Syntax
             * 
             * In the following example, ToList() extension method executes the query immediately and returns the result.
             * 
             * IList<Student> teenAgerStudents = tudentList.Where(s => s.age > 12 && s.age < 20).ToList();
             * 
             * Query Syntax
             * 
             * Query Syntax doesn't support 'To' operators but can use ToList(), ToArray() or ToDictionary() for immediate execution as below:
             * 
             * IList<Student> teenAgerStudents = (from s in studentList
                where s.age > 12 && s.age < 20
                select s).ToList();

             */
        }
    }

}