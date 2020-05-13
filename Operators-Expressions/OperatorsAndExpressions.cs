namespace Operators_Expressions
{

    using System;

    /// <summary>
    ///     Defines the <see cref="OperatorsAndExpressions" />.
    /// </summary>
    internal class OperatorsAndExpressions
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var devider = 2;

            var number = int.Parse(Console.ReadLine());

            var result = number % devider;

            if (result == 0)
            {
                Console.WriteLine("{0} is even number", number);
            }

            else
            {
                Console.WriteLine("{0} is odd number", number);
            }
        }
    }

}