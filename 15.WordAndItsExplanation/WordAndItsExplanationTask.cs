namespace _15.WordAndItsExplanation
{

    using System;

    internal class WordAndItsExplanationTask
    {
        private static void Main()
        {
            var text = @".NET – platform for applications from 
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";

            var words = text.Split(new[] {"\\n"}, StringSplitOptions.None).ToString();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }


            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add(".NET", "platform for applications from Microsoft");
            //dict.Add("CLR", "managed execution environment for .NET");
            //dict.Add("NAMESPACE", "hierarchical organization of classes");

            //Console.WriteLine("Dictionary words: {0}\n", string.Join(", ", dict.Keys));

            //Console.Write("Enter a word to see its explanation: ");
            //string word = Console.ReadLine().ToUpper();

            //Console.WriteLine(dict.ContainsKey(word) ? string.Format("\n{0} -> {1}\n", word, dict[word])
            //                  : string.Format("\nDictionary does not contain word \"{0}\".\n", word));
        }
    }

}