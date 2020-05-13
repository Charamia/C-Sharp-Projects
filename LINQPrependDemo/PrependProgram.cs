namespace LINQPrependDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class PrependProgram
    {
        private static void Main()
        {
            /* The Linq Prepend Method is used to add one value to the beginning of a sequence. This Prepend method like the Append method does not modify the elements of the sequence. 
             * Instead, it creates a copy of the sequence with the new element. The signature of this is given below.
             * public static IEnumerable<TSource>Prepend<TSource>(this IEnumerable<TSource> source, TSource element)
             * 
             * Type Parameters: TSource: The data type of the elements contained in the sequence.
               Parameters:
                    1. IEnumerable<TSource> source: A sequence of values.
                    2. TSource element: The value to prepend at the beginning of the sequence.
               Returns: IEnumerable<TSource>: A new sequence that begins with the element.
               Exceptions: When the source is null, it will throw ArgumentNullException.

               Note: This method is support from Framework 4.7.1 or later.

               The following example shows how to prepend a value to the beginning of the sequence using the Prepend method.
             */

            // Creating a list of numbers

            var numberSequence = new List<int> {10, 20, 30, 40};

            // Trying to prepend 50
            numberSequence.Prepend(50);

            // It will not work because the original sequence has not been changed
            Console.WriteLine(string.Join(", ", numberSequence));

            // It works now because we are using a changed copy of the original list
            Console.WriteLine(string.Join(", ", numberSequence.Prepend(50)));

            // If you prefer, you can create a new list explicitly

            var newnumberSequence = numberSequence.Prepend(50).ToList();

            // And then write to the console output
            Console.WriteLine(string.Join(", ", newnumberSequence));
        }
    }

}