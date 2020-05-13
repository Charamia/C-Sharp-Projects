namespace _01.RecursiveMethodLoops
{

    using System;

    internal class TestDemo
    {
        private static void Loops(int n)
        {
            Console.WriteLine(n);

            if (n == 0)
            {
                return;
            }


            Loops(n - 1);
        }

        //private static void Pesho(int i)
        //{
        //    Console.WriteLine("Kogato n  = " + i);
        //}

        private static void Main()
        {
            Loops(4);
            // FirstMethod();
        }

        //static void FirstMethod()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine("I'm printing from FirstMethod for loop and my i = " + i);
        //        SecoundMethod(i);
        //    }

        //    //Goes back to Main()
        //    Console.WriteLine("Going back to Main");
        //    Console.WriteLine();
        //    return;
        //}

        //static void SecoundMethod(int passedValueFromFirstMethod)
        //{
        //    Console.WriteLine("Secound Method is called vith value " + passedValueFromFirstMethod );

        //    for (int i = 0; i < passedValueFromFirstMethod; i++)
        //    {
        //        Console.WriteLine("I'm printing from SecondMethod for loop and my i = " + i);
        //        Console.WriteLine("and I've been called from FirstMethod with i = " +passedValueFromFirstMethod);
        //        ThirdMethod(i);
        //    }

        //    Console.WriteLine("Going back to FirstMethod");
        //    Console.WriteLine();
        //    //Goes back to FirstMethod()
        //    return;
        //}

        //static void ThirdMethod(int passedValueFromSecoundMethod)
        //{
        //    Console.WriteLine("Third Method is called vith value " + passedValueFromSecoundMethod);

        //    for (int i = 0; i < passedValueFromSecoundMethod; i++)
        //    {
        //        Console.WriteLine("I'm printing from ThirdMethodMethod for loop and my i = " + i);
        //        Console.WriteLine("and I've been called from SecoundMethod with i = " + passedValueFromSecoundMethod);

        //    }

        //    //Goes back to SecoundMethod
        //    Console.WriteLine("Going back to SecoundMethod");
        //    Console.WriteLine();
        //    return;
        //}
    }

}