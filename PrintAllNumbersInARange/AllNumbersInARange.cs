namespace PrintAllNumbersInARange
{

    using System;

    /// <summary>
    ///     Defines the <see cref="AllNumbersInARange" />.
    /// </summary>
    internal class AllNumbersInARange
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var start = 0;

            for (var i = 0; i < n; i++)
            {
                start++;
                Console.WriteLine(start);
            }
        }
    }

}