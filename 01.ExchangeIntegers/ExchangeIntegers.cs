namespace _01.ExchangeIntegers
{

    using System;

    /// <summary>
    ///     Defines the <see cref="ExchangeIntegers" />.
    /// </summary>
    internal class ExchangeIntegers
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                number2 = number1;
                Console.WriteLine("The first number was bigger therefore the second number has value of {0} now",
                    number1);
            }
            else
            {
                Console.WriteLine("The second number is bigger than the first number");
            }
        }
    }

}