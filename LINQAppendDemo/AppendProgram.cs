namespace LINQAppendDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class AppendProgram
    {
        private static void Main()
        {
            /*
             * The LINQ Append Method is used to append a value to the end of the sequence. This Append method does not modify the elements of the sequence. Instead, 
             * it creates a copy of the sequence with the new element. Following is the signature of the Append method.
             * 
             * public static IEnumerable<TSource>Append<TSource>(this IEnumerable<TSource> source, TSource element);
             * 
             * Type parameters: TSource: The data type of the elements contained in the sequence.
             * 
             * Parameters: 1. IEnumerable<TSource> source: A sequence of values.
             *             2. TSource element: The value to append at the end of the sequence.
             *
             * Returns: IEnumerable<TSource>: A new sequence that ends with the element.
             * 
             * Exceptions: When the source is null, it will throw ArgumentNullException.
             * 
             * Note: This method is support from Framework 4.7.1 or later.
             * 
             * The following example shows how to use the Append Method to append a value to the end of the sequence. 
             * The following example is self-explained. So, please go through the comment lines.
             */

            // Creating a list of integer
            var intSequence = new List<int> {10, 20, 30, 40};

            // Trying to append 50 at the end of the intSequence
            intSequence.Append(5);

            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));

            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ", intSequence.Append(5)));

            // Creating a new sequence explicitly
            var newintSequence = intSequence.Append(5).ToList();

            // Printing the new sequence in the console
            Console.WriteLine(string.Join(", ", newintSequence));
        }
    }

}