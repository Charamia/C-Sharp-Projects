namespace Problem1_3_6_9
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            // You are given 3 sectret numbers A, B<C where B is acttually the secret code symbol
            // If the code is 3 - find the sum of A and C. Example A = 5, C= 3, A+C = 8
            //If the code is 6 - find the product of A and C. Example A = 5, C = 3 , A*C = 15
            //If the code is 9 - find the remaider after A is divided by C. Example A = 5, C = 3, A%C = 2
            //After you find the result R from the code transformation, ifR can be divided by 3 with remaider 0, find R divided by three. Otherwise find the remaider after R is devided by 3.
            //For example, if R is 15, it can be divided by 3 with no remainder, so the answer is 5. If R is 8, it cannot be divided by 3, so the answer is 2.
            //The input data should be read from the console
            //On the first input line you will recieve the positive integer A.
            //On the second input line you will receive the positive integer B.
            //On the third input line you will receive the positive integer C.
            //The input data will always be valid and in the format described. There is no need to check it explicitly.
            //Output: The output should be printed on the console.
            //If R can be devided by 3 with no remainder, on the first output line you should print R divide by 3.
            //Otherwise, on the first output line you should print the reaminder after R is divided by 3.
            //On the second output line, you should print R
            //Constraints: A, B and C will be positive integers between 1 and 999 999, inclusive.
            //Allowed working time for your program: 0.10 seconds. Allowed memory: 16MB

            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            var c = long.Parse(Console.ReadLine());

            long result = 0;
            long secondResult = 0;

            if (b == 3)
            {
                result = a + c;
            }
            else if (b == 6)
            {
                result = a * c;
            }
            else if (b == 9)
            {
                result = a % c;
            }

            if (result % 3 == 0)
            {
                secondResult = result / 3;
            }
            else
            {
                secondResult = result % 3;
            }

            Console.WriteLine(secondResult);
            Console.WriteLine(result);
        }
    }

}