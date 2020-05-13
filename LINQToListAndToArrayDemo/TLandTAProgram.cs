namespace LINQToListAndToArrayDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class TLandTAProgram
    {
        private static void Main()
        {
            /*
             * The ToList Method is used to create a System.Collections.Generic.List<T> collection from a System.Collections.Generic.IEnumerable<T>. 
             * This method causes the query to be executed immediately.

                The signature of the ToList method is given below.
                public static List<TSource>ToList<TSource>(this IEnumerable<TSource> source);

                Parameters:

                    TSource: The type of elements contained in the source sequence
                    Returns: It returns System.Collections.Generic.List<T> which contains elements from the source sequence
                    Exceptions: This method throws System.ArgumentNullException when the source sequence is null

            Example: Convert array to List<int> using ToList method
             */

            //Creating Integer Array

            int[] numbersArray = {10, 22, 30, 40, 50, 60};

            //Converting Integer Array to List using ToList method

            var numbersList = numbersArray.ToList();

            foreach (var num in numbersList)
            {
                Console.WriteLine(num);
            }

            /*
             * ToArray Method in Linq:
                The ToArray Method is used to copies the elements of System.Collections.Generic.List<T> to a new array. This method causes the query to be executed immediately.
                The signature of this method is given below.

                Linq ToArray Method

                Here T is the type of the array and this method converts a list into an array and returns that array containing copies of the elements of the System.Collections.Generic.List<T>.

                Example: Convert List<int> to integer array
             */

            var numbersInList = new List<int>
            {
                10, 22, 30, 40, 50, 60
            };

            //Converting List to Array
            var numbersInArray = numbersInList.ToArray();

            foreach (var num in numbersInArray)
            {
                Console.WriteLine(num);
            }
        }
    }

}