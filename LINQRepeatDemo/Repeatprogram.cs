namespace LINQRepeatDemo
{

    using System;
    using System.Linq;

    internal class Repeatprogram
    {
        private static void Main()
        {
            /*
             * The LINQ Repeat Method is used to generate a sequence or collection that with a specified number of elements and each element contains the same value. 
             * The following is the signature of this method.
             * 
             * public static IEnumerable<TResult>Repeat<TResult<(Tresult element, int count)
             * 
             * The Repeat method has 2 integer parameters. The first parameter (i.e. TResult element) specifies the value to be repeated. The second parameter 
             * (i.e. int count) specifies the number of times to repeat the value. The return type of this method is IEnumerable<int> which is going to contain
             * the repeated values. Here TResult specifies the data type of the value that is going to be repeated in the result sequence.
             * 
             * Note: When the count value is less than 0 then it will through ArgumentOutOfRangeException.
             * 
             * The following example shows how to use the Repeat method to generate a sequence of a repeated value.
             * 
             * Note: The LINQ Repeat method is implemented using the deferred execution. So, the immediate return value is an object which stores all the required
             * information to perform an action. The query represented by this method is not executed until the object is enumerated either by calling its GetEnumerator
             * method directly or by using a for each loop.
             */

            var repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);
            foreach (var str in repeatStrings)
            {
                Console.WriteLine(str);
            }
        }
    }

}