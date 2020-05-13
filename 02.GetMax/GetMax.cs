namespace _02.GetMax
{

    using System;

    public class GetMax
    {
        public static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            return Math.Max(firstNumber, secondNumber);
        }

        public static void Main()
        {
            Console.Write("Please enter your first number: ");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            var secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter your third number: ");
            var thirdNumber = int.Parse(Console.ReadLine());


            //int result1 = GetMaxNumber(firstNumber, secondNumber);
            //int result2 = GetMaxNumber(firstNumber, thirdNumber);
            //int result3 = GetMaxNumber(secondNumber, thirdNumber);

            Console.WriteLine("The max number is {0}",
                GetMaxNumber(firstNumber, GetMaxNumber(secondNumber, thirdNumber)));


            //if (result1 >= result2 && result1 >= result3)
            //{

            //}
            //else if(result2 >= result3 && result2 >= result1)
            //{
            //    Console.WriteLine("The max number is {0}", thirdNumber);
            //}
            //else
            //{
            //    Console.WriteLine("The max number is {0}", secondNumber);
            //}
        }
    }

}