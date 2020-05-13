namespace ExpressionInLINQDemo
{

    using System;
    using System.Linq.Expressions;

    internal class ExpressionInLinqProgram
    {
        private static void Main()
        {
            /* We have learned that the lambda Expression can be assigned to the Func or Action type delegates to process over in-memory collections. 
             * The .NET compiler converts the lambda expression assigned to Func or Action type delegate into executable code at compile time.
             * 
             * LINQ introduced the new type called Expression that represents strongly typed lambda expression. It means lambda expression can also be assigned to Expression<TDelegate> type.
             * The .NET compiler converts the lambda expression which is assigned to Expression<TDelegate> into an Expression tree instead of executable code. This expression tree is used by 
             * remote LINQ query providers as a data structure to build a runtime query out of it (such as LINQ-to-SQL, EntityFramework or any other LINQ query provider that implements 
             * IQueryable<T> interface).
             * 
             * Define an Expression
             * 
             * Take the reference of System.Linq.Expressions namespace and use an Expression<TDelegate> class to define an Expression. Expression<TDelegate>
             * requires delegate type Func or Action.
             * For example, we can assign lambda expression to the isTeenAger variable of Func type delegate, as shown below:
             */

            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            //compile Expression using Compile method to invoke it as Delegate
            var isTeenAger = isTeenAgerExpr.Compile();

            //Invoke
            var result = isTeenAger(new Student {StudentID = 1, StudentName = "Steve", Age = 20});

            Console.WriteLine(result);

            /* Invoke an Expression
             * We can invoke the delegate wrapped by an Expression the same way as a delegate, but first we need to compile it using the Compile() method. Compile() returns delegateof Func or
             * Action type so that we can invoke it like a delegate.
             * 
             */
        }
    }

}