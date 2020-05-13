namespace Delegates
{

    using System;

    //These delegates will obtain 1 method
    public delegate void SomeDelegate(int number);

    /// <summary>
    ///     The SomeStringParamdelegate.
    /// </summary>
    /// <param name="text">The text<see cref="string" />.</param>
    public delegate void SomeStringParamdelegate(string text);

    /// <summary>
    ///     The ConvertStrings.
    /// </summary>
    /// <param name="text">The text<see cref="string" />.</param>
    /// <returns>The <see cref="int" />.</returns>
    public delegate int ConvertStrings(string text);

    //The delegate below will have more methods
    public delegate int Multicastdelegate(int frs, int scd);

    /// <summary>
    ///     Defines the <see cref="DLG" />.
    /// </summary>
    public class DLG
    {
        /// <summary>
        ///     The SomeMethod.
        /// </summary>
        /// <param name="nmb">The nmb<see cref="int" />.</param>
        public static void SomeMethod(int nmb)
        {
            Console.WriteLine(nmb);
        }

        /// <summary>
        ///     The AnotherMethod.
        /// </summary>
        /// <param name="text">The text<see cref="string" />.</param>
        public static void AnotherMethod(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        ///     The Sum.
        /// </summary>
        /// <param name="first">The first<see cref="int" />.</param>
        /// <param name="second">The second<see cref="int" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int Sum(int first, int second)
        {
            var result = first + second;

            Console.WriteLine(result);

            return result;
        }

        /// <summary>
        ///     The Product.
        /// </summary>
        /// <param name="first">The first<see cref="int" />.</param>
        /// <param name="second">The second<see cref="int" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int Product(int first, int second)
        {
            var result = first * second;
            Console.WriteLine(result);

            return result;
        }

        /// <summary>
        ///     The Remainder.
        /// </summary>
        /// <param name="first">The first<see cref="int" />.</param>
        /// <param name="second">The second<see cref="int" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int Remainder(int first, int second)
        {
            var result = first % second;

            Console.WriteLine(result);

            return result;
        }

        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            SomeDelegate dlg = SomeMethod;

            // dlg(10);

            //The code below does not compile because AnotherMethod has different signature (it takes string as parameter instead of int, like the delegate) 
            //dlg = new SomeDelegate(AnotherMethod);

            // dlg = new SomeDelegate(Console.WriteLine);
            //var textDlg = new SomeStringParamdelegate(Console.WriteLine);

            //dlg(100);
            //textDlg("1900");

            //ConvertStrings cnvrDlg = new ConvertStrings(int.Parse);

            //int someNumber = cnvrDlg("100");
            //Console.WriteLine(someNumber);

            //dlg = Console.WriteLine;

            Multicastdelegate multyFunctions = Sum;
            multyFunctions += Product;
            multyFunctions += Remainder;

            multyFunctions -= Remainder;


            var result = multyFunctions(10, 6);

            Console.WriteLine("Delegate result: " + result);

            SomeStringParamdelegate annDlg = delegate(string text)
            {
                text += " ";
                Console.WriteLine("Hello " + text);
            };
            annDlg("Eli!");
        }
    }

}