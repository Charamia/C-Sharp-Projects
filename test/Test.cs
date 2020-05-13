using System;
using System.Collections.Generic;


namespace test
{
    class Test
    {
        static void Main()
        {
            string expression = Console.ReadLine();

            decimal result = 0;
            char currentOperator = '+';
            decimal currentBracketresult = 0;
            bool inBracket = false;
            char currentBracketOperator = '+';


            foreach (char symbol in expression)
            {
                if(symbol == '(')
                {
                    inBracket = true;
                    continue;
                }

                if(symbol == ')')
                {
                    inBracket = false;

                    switch (currentOperator)
                    {
                        case '+': result += currentBracketresult; break;
                        case '-': result -= currentBracketresult; break;
                        case '*': result *= currentBracketresult; break;
                        case '/': result /= currentBracketresult; break;
                    }
                    currentBracketresult = 0;
                    currentBracketOperator = '+';
                }

                if(symbol == '+' ||
                    symbol == '-' ||
                    symbol == '*' ||
                    symbol == '/')
                {
                    if(inBracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }

                if(symbol >= '0' && symbol <= '9')
                {
                    int currentNumber = symbol - '0';

                    if(inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': currentBracketresult += currentNumber; break;
                            case '-': currentBracketresult -= currentNumber; break;
                            case '*': currentBracketresult *= currentNumber; break;
                            case '/': currentBracketresult /= currentNumber; break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '/': result /= currentNumber; break;
                        }
                    }

                    
                }
            }
            Console.WriteLine("{0:F2}", result);
              
        }
    }
}
