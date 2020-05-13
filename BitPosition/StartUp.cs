namespace BitPosition
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
            var bitPosition = int.Parse(Console.ReadLine());
            var i = 1;

            var mask = i << bitPosition;
            var numberAndMask = number & mask;


            Console.WriteLine((number & mask) != 0 ? 1 : 0);
        }
    }

}