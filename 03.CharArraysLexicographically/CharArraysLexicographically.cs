namespace _03.CharArraysLexicographically
{

    using System;

    internal class CharArraysLexicographically
    {
        private static void Main()
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();


            var arrayEqual = true;

            if (firstWord.Length > secondWord.Length)
            {
                Console.WriteLine("Second array is lexicographicaly first.");
            }
            else if (firstWord.Length < secondWord.Length)
            {
                Console.WriteLine("First array is lexicographicaly first.");
            }
            else
            {
                for (var i = 0; i < firstWord.Length; i++)
                {
                    if (firstWord[i] < secondWord[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }

                    if (firstWord[i] > secondWord[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual)
                {
                    Console.WriteLine("Arrays are lexicographicaly equal.");
                }
            }
        }
    }

}