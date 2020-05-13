namespace TheHorror
{

    using System;

    internal class TheHorror
    {
        private static void Main()
        {
            // You are given a text with some digits. Your task is to find all digits in every even positio( starting from zero) throughtout the text and calculate their sum.
            //Input: The input data should be read from the console
            //The input data will always be valid and in the format described. There is no need to check it explicitly.
            //The output should be printed on the console.
            //On the only input line you should print the total amount odf digits in even pisitions and their sum separated by space
            //Constraints
            //The text's length  will be a valid integer number.
            //Allowed working time for yoiur program: 0.10seconds. Allowed memory: 16MB
            //Examples: input: 123 output: 2 4; input 10000 output:3 1; input 987654 output 3 21; input 5005005 output 4 10. input 200000000 output 5 2

            var someNumber = '1';
            var theNumber = someNumber - '0'; // the same can be done int.Parse(someNumber.ToString());
            var letter = 'c';
            var letterAsNumber = letter - 'a' + 1;

            var text = Console.ReadLine();
            var counter = 0;
            var evenCounter = 0;
            var sum = 0;


            foreach (var symbol in text)
            {
                if (counter % 2 == 0)
                {
                    if (char.IsDigit(symbol))
                    {
                        evenCounter++;
                        sum += symbol - '0';
                    }
                }

                counter++;
            }

            Console.WriteLine("{0} {1}", evenCounter, sum);
        }
    }

}