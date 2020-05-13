namespace OLtherStringOperations
{

    using System;

    internal class OtherStringOperations
    {
        private static void Main()
        {
            //String.Replace() example
            var cocktail = "Vodka + Martini + Cherry";
            var replaced = cocktail.Replace("+", "and");
            Console.WriteLine(replaced);

            //String.remove() example
            var price = "$ 1234567";
            var lowPrice = price.Remove(2, 3);
            Console.WriteLine(lowPrice);

            //Uppercase and lowercase conversion examples 
            var alpha = "aBcDeFg";
            var lowerAlpha = alpha.ToLower();
            Console.WriteLine(lowerAlpha);
            var upperAlpha = alpha.ToUpper();
            Console.WriteLine(upperAlpha);

            //Trim() example
            var s = " example of white spaces ";
            var clean = s.Trim();
            Console.WriteLine(clean);

            //Trim(char) example
            s = " \t\nHello!!!! \n";
            clean = s.Trim(' ', ',', '!', '\n', '\t');
            Console.WriteLine(clean);


            //TrimStart() example 
            s = "     C#   ";
            clean = s.TrimStart();
            Console.WriteLine(clean);

            //TrimEnd() example
            s = "     C#   ";
            clean = s.TrimEnd();
            Console.WriteLine(clean);
        }
    }

}