namespace LINQReversDemo
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ReversDemoProgram
    {
        private static void Main()
        {
            //The LINQ Reverse method is used to reverse the data stored in a data source. That means this method will not change the data rather it simple reverse the data stored in 
            //the data source. So, as a result, we will get the output in reverse order.

            int[] intArray = {10, 30, 50, 40, 60, 20, 70, 100};

            Console.WriteLine("Before Reverse the Data");

            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            var ArrayReversedData = intArray.Reverse();

            Console.WriteLine("After Reverse the Data");

            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }

            var stringList = new List<string> {"Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan"};

            Console.WriteLine("Before Reverse the Data");

            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();

            //You cannot store the data like below as this method belongs to
            //System.Collections.Generic namespace whose return type is void
            //IEnumerable<int> ArrayReversedData = stringList.Reverse();

            stringList.Reverse();

            Console.WriteLine("After Reverse the Data");

            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }


            //How to apply the Linq Reverse method on a collection of List<T> type?
            //If you want to apply the Reverse method which belongs to System.Linq namespace on a collection of type List<T>, 
            //then first you need to convert to the List<T> collection to as IEnumerable or IQueryable collection by using the AsEnumerable() or AsQueryable() method on the data source.
            //If you use the AsEnumerable() method then it will convert the collection to IEnumerable whereas if you use AsQueryable() method then it will convert the collection to IQueryable.
            Console.WriteLine();

            Console.WriteLine("Before Reverse the Data");

            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();

            var ReverseData1 = stringList.AsEnumerable().Reverse();

            var ReverseData2 = stringList.AsQueryable().Reverse();
            Console.WriteLine();
            Console.WriteLine("After Reverse the Data");

            foreach (var name in ReverseData1)
            {
                Console.Write(name + " ");
            }
        }
    }

}