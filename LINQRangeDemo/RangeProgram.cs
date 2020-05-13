namespace LINQRangeDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class RangeProgram
    {
        private static void Main()
        {
            /*Range() Repeat<T>() and Empty() methods are provided from the Enumerable class. These methods allow us to create some specific type of array, 
            sequence, or collection using a single expression instead of creating them manually and populating them using some kind of loops. That means 
            these methods return a new sequence or collection that implements the IEnumerable<T> interface.
            
             Linq Range Method in C#:
             This method is used to Generates a sequence of integral (integer) numbers within a specified range. The following is the signature of this method.
             public static IEnumerable<int> Range(int start, int count);

            This method has 2 integer parameters. The first parameter (i.e. int start) specifies the value of the first integer in the sequence. The second parameter 
            (i.e. int count) specifies the number of sequential integers to be generated. The return type of this method is IEnumerable<int> which going to contain a range of sequential integer numbers.

            Note: When the count value is less than 0 or when the start + count – 1 value larger than the MaxValue then it will through ArgumentOutOfRangeException.
             * 
             * The following example generates a sequence of integers from 1 to 10 using the Linq Range method.
             */

            var numberSequence = Enumerable.Range(1, 10);
            foreach (var i in numberSequence)
            {
                Console.WriteLine(i);
            }

            //Range with filter

            var EvenNumbers = Enumerable.Range(10, 30).Where(x => x % 2 == 0);
            foreach (var num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }

            //The following example shows how to generate a sequence of integers from 1 to 5 and then return the square of each number.
            Console.WriteLine();
            Console.WriteLine();

            var EvenNumbers1 = Enumerable.Range(1, 5).Select(x => x * x);
            foreach (var num in EvenNumbers1)
            {
                Console.Write($"{num} ");
            }

            //Range with string
            //In the following example first, we generate a sequence and then we pass the sequence to our CustomLogic method and
            //then merge the sequence with the return value from the CustomLogic method and return the result as IEnumerable<string>.

            Console.WriteLine();
            Console.WriteLine();

            IEnumerable<string> rangewithString =
                Enumerable.Range(1, 5).Select(x => x * x + " " + CustomLogic(x)).ToArray();
            foreach (var item in rangewithString)
            {
                Console.WriteLine(item);
            }
        }

        private static string CustomLogic(int x)
        {
            var result = string.Empty;
            switch (x)
            {
                case 1:
                    result = "1st";
                    break;
                case 2:
                    result = "2nd";
                    break;
                case 3:
                    result = "3rd";
                    break;
                case 4:
                    result = "4th";
                    break;
                case 5:
                    result = "5th";
                    break;
            }

            return result;
            //Note: This method is implemented by using the deferred execution. The immediate return value is an object that stores all the information that is required to
            //perform the action. The query represented by this method is not executed until the object is enumerated either by calling its GetEnumerator method directly 
            //or by using a for each loop.
        }
    }

}