namespace ReadWrite
{

    using System;

    internal class ReadWrite
    {
        private static void Main()
        {
            // string firstName = "Napitka 1";
            //string secondName = "Napitka, koqto e mnogo vkusna";
            //string thirdName = "oOshete edna napitka";

            //int firstPrice = 12;
            //int secondPrice = 15;
            //int thirdPrice = 17;
            //int symbol = Console.Read();
            //int anotherSymbol = Console.Read();
            //ConsoleKeyInfo key = Console.ReadKey();

            //string formatedText = "{0, -30} - {1, 10:c}";


            //Console.WriteLine("{0, -30} - {1}", firstName, firstPrice);
            //Console.WriteLine("{0, -30} - {1}", secondName, secondPrice);
            //Console.WriteLine("{0, -30} - {1}", thirdName, thirdPrice);

            // the code below is better practice

            //Console.WriteLine("Symbol: " + symbol + " " + anotherSymbol);
            //Console.WriteLine(formatedText, firstName, firstPrice);
            //Console.WriteLine(formatedText, secondName, secondPrice);
            //Console.WriteLine(formatedText, thirdName, thirdPrice);

            //Console.WriteLine("Key was: " + key.Key);
            //Console.WriteLine("Modifiers " + key.Modifiers);
            //Console.WriteLine("keyChar was: " + key.KeyChar);


            Console.Write("Please enter your first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            var surname = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("your name is {0} {1}!", firstName, surname);
        }
    }

}