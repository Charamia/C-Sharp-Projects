namespace LINQExpressionTreeDemo
{

    using System;
    using System.Linq.Expressions;
    using LINQ.Infrastructure;

    internal class LINQExpressionTreeProgram
    {
        private static void Main()
        {
            /* Expression Tree
             * 
             * Expression tree as name suggests is nothing but expressions arranged in a tree-like data structure. Each node in an expression tree is an expression. For example, an 
             * expression tree can be used to represent mathematical formula x < y where x, < and y will be represented as an expression and arranged in the tree like structure.
             * Expression tree is an in-memory representation of a lambda expression. It holds the actual elements of the query, not the result of the query.
             * The expression tree makes the structure of the lambda expression transparent and explicit. You can interact with the data in the expression tree just as you can with
             * any other data structure.
             * 
             * Example: Expression in C#               
             */

            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            //The compiler will translate the above expression into the following expression 

            //Expression.Lambda<Func<Student, bool>>(
            //    Expression.AndAlso(
            //        Expression.GreaterThan(Expression.Property(pe, "Age"), Expression.Constant(12, typeof(int))),
            //        Expression.LessThan(Expression.Property(pe, "Age"), Expression.Constant(20, typeof(int)))),
            //            new[] { pe });

            // We can also build an expression tree manually. Let's build an expression tree for the following simple lambda expression:

            Func<Student, bool> isAdult = s => s.Age >= 18;

            //The Func delegate will be treated like the following method

            //To create the expression tree, first of all we have to create a parameter expression where Students is the type of the parameter and 's' is the name of the parameter as below:

            // Step 1: Create parameter Expression in C#

            var pe = Expression.Parameter(typeof(Student), "s");

            //Now, use the Expression.property() to create s.Age expression where s is the parameter and Age is the property name of Student. (Expression is an abstract class that contains
            //static helper method to create the Expression tree manually)

            // 2. Create Property Expression in C#
            var me = Expression.Property(pe, "Age");

            //Now create a constant expression for 18

            //Step 3: Create Constant Expression in C#

            var constant = Expression.Constant(18, typeof(int));

            /* Till now, we have built expression tree for s.Age(member expression) and 18( constant expression). We now need to check whether a member expression is greater than a constant
             * expression or not. For that, use the expression.GreaterThanOrEqual() method  and pass the member expression and constant expression as parameter:
             * Step 4: Create Binary Expression in C#
             */

            var body = Expression.GreaterThanOrEqual(me, constant);

            //Thus, we have built an expression tree for a lambda ecpression body s.Age >= 18. We now need to join the parameter and the body expressions. 
            // Use Expression.Lambda(body, parameters array) to join the body and parameter part of the lambda expression s => s.age >= 18.
            // Step 5: Create Lambda Expression in C#

            var isAdultExpTree = Expression.Lambda<Func<Student, bool>>(body, pe);

            //This way we can build an expression tree for simple Func delegate with a lambda expression

            var pe1 = Expression.Parameter(typeof(Student), "s");

            var me1 = Expression.Property(pe, "Age");

            var constant1 = Expression.Constant(18, typeof(int));

            var body1 = Expression.GreaterThanOrEqual(me1, constant1);

            var ExpressionTree = Expression.Lambda<Func<Student, bool>>(body1, pe1);


            Console.WriteLine("Expression Tree: {0}", ExpressionTree);

            Console.WriteLine("Expression Tree Body: {0}", ExpressionTree.Body);

            Console.WriteLine("Number of Parameters in Expression Tree: {0}", ExpressionTree.Parameters.Count);

            Console.WriteLine("Parameters in Expression Tree: {0}", ExpressionTree.Parameters[0]);

            /*Why Expression Tree?
             * 
             * We have seen in the previous section that the lambda expression assigned to Func<T> compiles 
             * into executable code and the lambda expression assigned to Expression<TDelegate> type compiles into Expression tree
             * 
             * Executable code executes in the same application domain to process over in-memory collection. Enumerable static classes
             * contain extenssion methods for in-memory collections that implements IEnumerable<T> interface e.g.
             * List<T>, Dictionary<T>, etc. The extenssion methods in an Enumerable class accept a predicate parameter of Func type delegate. For example, the Where extenssion
             * method accepts Func<TSource, bool> predicate.
             * It then compiles it into IL(Intermediate Language) to process over in-memory collections that are in the same AppDomain.
             * 
             * Func delegate is a raw executable code, so if we debug the code, we will find that the Func delegate will be represented as opaque code. You cannot see its parameters, return type or body
             * 
             * Func delegate is for in-memory collections because it will be processed in the same AppDomain , but what about remote LINQ query providers like LINQ-to-SQL, EntitFramework or other third party
             * products that provides LINQ capabilities? How would they parse lambda expression that has been compiled into raw executable code to know about the parameters, return typw of lambda expression and build
             * runtime query to process further? The answer is Expression tree.
             * An expression tree is transparent. We can retrieve a parameter, return type and body expression information from the expression, as below:
             * 
             */

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            Expression<Func<Student, bool>> isTeenAgerExpr1 = s => s.Age > 12 && s.Age < 20;

            var parameters = isTeenAgerExpr.Parameters;

            Console.WriteLine("Expression: {0}", isTeenAgerExpr1);

            Console.WriteLine("Expression Type: {0}", isTeenAgerExpr1.NodeType);

            foreach (var param in parameters)
            {
                Console.WriteLine("Parameter Name: {0}", param.Name);
                Console.WriteLine("Parameter Type: {0}", param.Type.Name);
            }

            var bodyExpr = isTeenAgerExpr1.Body as BinaryExpression;


            Console.WriteLine("Left side of body expression: {0}", bodyExpr.Left);
            Console.WriteLine("Binary Expression Type: {0}", bodyExpr.NodeType);
            Console.WriteLine("Right side of body expression: {0}", bodyExpr.Right);
            Console.WriteLine("Return Type: {0}", isTeenAgerExpr1.ReturnType);

            /*
             * LINQ and LINQ-to-SQL or Entity Framework is not executed in the same app domain. For example, the following LINQ query for Entity Framework is never actually executed 
             * inside your program:
             * 
             * var query = from s in dbContext.Students
                           where s.Age >= 18
                           select s;

             * It is first translated into an SQL statement and then executed on the database server.
             * 
             * The code found in a query expression has to be translated into an SQL query that can be sent to another process as a string. For LINQ-to-SQL or Entity Frameworks, 
             * that process happens to be an SQL server database. It is obviously going to be much easier to translate a data structure such as an expression tree into SQL than it 
             * is to translate raw IL or executable code into SQL because, as you have seen, it is easy to retrieve information from an expression.
             * 
             * Expression trees were created for the task of converting code such as query expression into a string that can be passed to some other process and ececuted there
             * 
             * Queryable static class includes extension methods that accept a predicate of Expression type. This predicate expression will be converted into an Expression Tree and
             * then will be passed to the remote LINQ provider as a data structure so that the provider can build an appropriate query from the expression tree and execute the query
             */
        }

        public bool function(Student s)
        {
            return s.Age > 18;
        }
    }

}