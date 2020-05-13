namespace ExceptionsProperties
{

    using System;

    internal class ExceptionProperties
    {
        private static void Main()
        {
            try
            {
                CausedFormatException();
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Exception caught: " + fe);
                Console.Error.WriteLine("\nMessage: " + fe.Message);
                Console.Error.WriteLine("\nStack Trace: " + fe.StackTrace);
            }
        }

        public static void CausedFormatException()
        {
            var s = "an invalid number";
            //Int32.Parse(s);
            InnerMethod(s);
        }

        public static void InnerMethod(string input)
        {
            int.Parse(input);
        }
    }

}