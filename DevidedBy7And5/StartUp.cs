namespace DevidedBy7And5
{

    using System;

    /// <summary>
    ///     Defines the <see cref="StartUp" />.
    /// </summary>
    internal class StartUp
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var firstDevidedBy5 = number % 5;
            var secondDevidedBy7 = number % 7;

            bool first;
            bool second;
            bool result;

            if (firstDevidedBy5 == 0 && secondDevidedBy7 == 0)
            {
                Console.WriteLine("{0} is devided by 5 and 7 without fraction and the result is true", number);
            }
            else if (firstDevidedBy5 != 0 || secondDevidedBy7 != 0)
            {
                first = false;
                second = false;
                result = first && second;
                Console.WriteLine("{0} is not divided by both 5 and 7 without fraction and the result is {1}", number,
                    result);
            }

            Console.WriteLine(number % 5 == 0 && number % 7 == 0 ? "Yes" : "No");
        }
    }

}