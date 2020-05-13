namespace LINQZipDemo
{

    using System;
    using System.Linq;

    internal class ZipProgram
    {
        private static void Main()
        {
            /*The Linq Zip Method in C# is used to apply a specified function to the corresponding elements of two sequences and producing a sequence of the results. 
               The signature of this method is given below.
              
              public static IEnumerable<TResult>Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector>
             
              Type Parameters:
                    1. TFirst: The type of the elements of the first input sequence.
                    2. TSecond: The type of the elements of the second input sequence.
                    3. TResult: The type of the elements of the result sequence.
              Parameters:
                    1. IEnumerable<TFirst> first: The first sequence to merge.
                    2. IEnumerable<TSecond> second: The second sequence to merge.
                    3. Func<TFirst,TSecond,TResult> resultSelector: A function that specifies how to merge the elements from the two sequences.
              Returns: This method is going to return an IEnumerable<T> that contains merged elements of two input sequences.

              Exceptions: This method is going to throw ArgumentNullException when either the first or the second input sequence is null.

               Note: The Zip method merges each element of the first sequence with an element in the second sequence that has the same index position. If both the sequences do not have the same number of elements, then the Zip method merges sequences until it reaches the end of the sequence which contains fewer elements. For example, if one sequence has five elements and the other sequence has four elements, then the result sequence will have only four elements. 
             
             The following example shows how to merge two sequences using the Linq Zip method.
             */

            int[] numbersSequence = {10, 20, 30, 40, 50};

            string[] wordsSequence = {"Ten", "Twenty", "Thirty", "Fourty"};

            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);

            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }

            /*
             * The first sequence contains 5 elements whereas the second sequence contains 4 elements. So, for the fifth element of the first sequence, there
             * is no corresponding fifth element in the second sequence. As a result, the Zip method merges the four elements and that’s what we have seen in the output.

                Note:
                The Zip method is implemented by using the deferred execution. So, the immediate return value of this method is going to be an object which stores all the required 
                information which is required to perform the action. The query represented by this method is not executed until the object is enumerated either by calling 
                its GetEnumerator method directly or by using for each loop.
             */
        }
    }

}