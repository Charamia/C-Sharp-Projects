namespace ThirdDigit
{

    using System;

    /// <summary>
    ///     Defines the <see cref="StartUp" />.
    /// </summary>
    internal class StartUp
    {
        /// <summary>
        ///     Defines the searchedNumber.
        /// </summary>
        private const int searchedNumber = 7;

        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var devidedByHundredNumber = number / 100;
            var devidedBy10 = devidedByHundredNumber % 10;

            if (devidedBy10 == searchedNumber)
            {
                Console.WriteLine("The third digit from right to left of {0}  is {1}", number, devidedBy10);
            }
            else
            {
                Console.WriteLine("There isn't a third edigit from left to right in {0} or it is diffrent from {1}",
                    number, searchedNumber);
            }
        }
    }

}