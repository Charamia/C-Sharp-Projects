namespace _09.NnumbersAndTheirSum
{

    using System;

    /// <summary>
    ///     Defines the <see cref="NNumbers" />.
    /// </summary>
    internal class NNumbers
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            int number;

            for (var i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }

}