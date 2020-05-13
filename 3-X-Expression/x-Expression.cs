/*  An expression spell consists of set of simple mathematical expressions. Each mathematical expressioncan contain SUM, SUBTRACT, DIVIDE and/or MULTIPLY operations. 
*   The expression is solved like calculator would do(example follows) and can contain brackets. Everything inside a bracket is solved first. An expression can contain 
*    multiple brackets, but cannot contain nestted brackets(i.e. expression containing (...(...)...) is invalid, but expression conatining (...)...(...) is valid).
*    Given the expression: 4+6/5 +(4*9-8)/4*2 . It is solved as follow:
*     4+6/5+(4*9-8)/7*2=
*     10/5+(4*9-8)/7*2
*     2+(36-8)/7*2=
*     2+28/7*2=
*     30/7*2=
*     4.285714285714286*2=
*     8.571428571428571=
*     8.57
*    input : 3+(6/5)+(2*3/7)*7/2*(9/4+4*1) =Input: 110.63
*    The result should be rounded to the 2 second digit after the decimal poi*nt
*   Constraints:
*    The expression will contain no more than 2500 characters
*    The numbers in an expression will always be in the range [1-9]
*    THe operators in an expression will always be among + (SUM), - (SUBTRACK), 
*    The result will alaways be in the range [-100000.00, 100000.00]
*    Allow work time for your program: 0.1 seconds
*    Allow memory 4MB
*/


namespace _3_X_Expression
{

    using System;

    internal class Program
    {
        private static void Main()
        {
            var expression = Console.ReadLine();
            decimal result = 0;
            decimal currentBracketResult = 0;

            var currentOperator = '+';
            var inBracket = false;
            var currentBracketOperator = '+';


            foreach (var symbol in expression)
            {
                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }

                if (symbol == ')')
                {
                    inBracket = false;

                    switch (currentOperator)
                    {
                        case '+':
                            result += currentBracketResult;
                            break;
                        case '-':
                            result -= currentBracketResult;
                            break;
                        case '*':
                            result *= currentBracketResult;
                            break;
                        case '/':
                            result /= currentBracketResult;
                            break;
                    }

                    currentBracketResult = 0;
                    currentBracketOperator = '+';
                }

                if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '*' ||
                    symbol == '/')
                {
                    if (inBracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }

                if (symbol >= '0' && symbol <= '9')
                {
                    var currentNumber = symbol - '0';

                    if (inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+':
                                currentBracketResult += currentNumber;
                                break;
                            case '-':
                                currentBracketResult -= currentNumber;
                                break;
                            case '*':
                                currentBracketResult *= currentNumber;
                                break;
                            case '/':
                                currentBracketResult /= currentNumber;
                                break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+':
                                result += currentNumber;
                                break;
                            case '-':
                                result -= currentNumber;
                                break;
                            case '*':
                                result *= currentNumber;
                                break;
                            case '/':
                                result /= currentNumber;
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("{0:F2}", result);
        }
    }

}