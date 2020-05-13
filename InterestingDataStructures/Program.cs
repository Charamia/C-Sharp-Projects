namespace InterestingDataStructures
{

    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            //List has indexer
            var words = new List<string>();

            words.Add("pesho");
            words.Add("gosho");
            words.Add("Strahil");
            words.Add("Dragan");

            words.Remove("gosho"); // Тhis is very slow, when we have long list
            words.RemoveAt(0); // This is slow too

            Console.WriteLine(words.Count);
            Console.WriteLine(words[1]);

            var numbersSet = new HashSet<int>();
            // HashSet doesn't have indexer, and it contains only unique elements. It's easy to remove elements and it's very fast compaired with List and array.
            numbersSet.Add(1);
            numbersSet.Add(1);
            numbersSet.Add(1);
            numbersSet.Add(5);
            numbersSet.Add(7);
            numbersSet.Add(9);

            numbersSet.Remove(5);
            numbersSet.Contains(7);

            Console.WriteLine(numbersSet.Count);


            //SortedSet also doesn't have index and it's really fast, keeps only unique elements., sorts automatically. SortedSet has Min and Max, unlike HashSet
            var sortedNumbers = new SortedSet<int>();

            sortedNumbers.Add(5);
            sortedNumbers.Add(2);
            sortedNumbers.Add(8);
            sortedNumbers.Add(4);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("the minimum number is {0}.", sortedNumbers.Min);

            var dict = new Dictionary<string, string>();

            //Dictionary is collection of key value pairs, custom indexars, keys are unique
            //When using foreach with dictionaries we can iterate throuth the keys and also throuth the elements, which is making the use of foreach a bit diffrent compared with arrays for example
            dict.Add("pesho", "550");

            dict["pesho"] = "gosho";

            var peshoResult = dict["pesho"];

            dict.ContainsKey("gosho");

            Console.WriteLine(peshoResult);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }


            //If we foreach SortedDistionary the collection will be sorted by the keys
            var sortedDict = new SortedDictionary<string, string>();

            sortedDict["gosho"] = "550";
            sortedDict["abc"] = "600";
            sortedDict["aaa"] = "1000";


            foreach (var name in sortedDict.Keys)
            {
                var value = sortedDict[name];
                Console.WriteLine(value);
            }


            //Stack LIFO (First In Last Out)
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(5);
            stack.Push(10);

            Console.WriteLine(stack.Count);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            var nextnumber =
                stack.Pop(); // It is showing the last element, in the case above it will give us , or it gives us the elements in the Stack backwards

            Console.WriteLine(stack.Pop());

            //Stack.Pop is used to remove and return the object at the top of the Stack. This method is similar to the Peek method, but Peek does not modify the Stack.

            //Queue -FIFO(First In First Out)

            var queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(15);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());


            while (true)
            {
                if (queue.Count == 0)
                {
                    break;
                }

                Console.WriteLine(queue.Dequeue());
            }

            //or the same thing above can be done as below

            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }

}