/*Moving letters
 * Nakov is a keen fan of cryptography. When he was a child, he invented an encryption algorithm called "Moving Letters". It performs two steps: 1. extracts the letters from the input message
 * and 2. moves each letter a few positions on the right according to its alphabetical order. Your task is to write a program that reads an input message, encrypts it throgh the "Moving Letters"
 * algorythm and prints the result.
 * Extracting the letters
 * The input message is given as a sequence of words separated by a space. The words are converted into sequence of letters the following way:
 * until all words disappear, the last letter of each word (if exists) is removed from the word and is appended to the output sequence of letters.
 * Moving the Letters
 * The next step in the encryption algorithm is move each letter (from positions 0, 1, ..., n-1) in the right k times. the number k is taken from the number of the letter in the latin alphabet 
 * regardless of its casing  ('a' -> 1, 'b' -> 2, ..., 'z' -> 26). When a letter is moved to the right , if it is the last letter of the sequence, its next position is the firstposition in the
 * seqience, just before all the letters.
 * Example:
 * lets put is "Fun exam right". It is first split into 3 words: {"Fun", "exam", "right"}. Then the last letters are extracted: {"Fun", "exam", "right"} -> {"Fu", "exa", "righ"} -> "nmtuah" -> 
 * {"F" , "ex", "rig"} -> {"F", "ex", "rig"} -> "nmtuahFxg" -> {"e", "ri"} -> "nmtuaFxgei" -> {"r"} -> "nmtuahFxgeir".
 * The moving of letters starts from the input sequence "nmtuahFxgeir" and sequentially moves right its first letter9 at position 0), then its second letter (at position 1), and so on, and finnally
 * moves right its last letter(at position 11) . First the letter 'n' at position 0 is moved right 14 times:
 * "nmtuahFxgeir" -> "mtnuahFxgeir". Then the letter 't' at position 1 is moved 20 times right: "mtnuahFxgeir" -> "mnuahFxgetir". then the process continues: 
 * "mnuahFxgetir" -> "mnahFxgetiru" -> "mnaFxgetiruh" -> mnaFxgetiruh" -> gmnaFxetiruh" -> "gmnaFxtiruhe" -> "gmnaiFxtruhe" -> "gmrnaiFxtuhe" -> gmrnaiuFxthe" -> "gmrnaihuFxte" -> "gmrneaihuFxt". 
 * The result is "gmrneaihuFxt"
 */

namespace MovingLetters
{

    using System;
    using System.Text;

    internal class MovingLettersTask
    {
        private static StringBuilder ExtractLetters(string[] words)
        {
            var maxWordLength = 0;
            var result = new StringBuilder();

            for (var i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                if (maxWordLength < currentWord.Length
                ) //or we can do it without currentWord variable: (maxWordLength < words[i].Length)
                {
                    maxWordLength = currentWord.Length;
                }
            }

            for (var i = 0; i < maxWordLength; i++)
            for (var j = 0; j < words.Length; j++)
            {
                var currentWord = words[j];

                if (currentWord.Length > i)
                {
                    var lastLetter = currentWord.Length - 1 - i;

                    result.Append(currentWord[lastLetter]);
                }
            }

            return result;
        }

        private static string MoveLetters(StringBuilder strangePieceOfwords)
        {
            for (var i = 0; i < strangePieceOfwords.Length; i++)
            {
                var currentSymbol = strangePieceOfwords[i];
                var transition = char.ToLower(currentSymbol) - 'a' + 1;

                var nextPosition = (i + transition) % strangePieceOfwords.Length;
                strangePieceOfwords.Remove(i, 1);
                strangePieceOfwords.Insert(nextPosition, currentSymbol);
            }

            return strangePieceOfwords.ToString();
        }

        private static void Main()
        {
            var words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var strangeCombinationOfLetters = ExtractLetters(words);
            var finalResult = MoveLetters(strangeCombinationOfLetters);

            Console.WriteLine(finalResult);
        }
    }

}