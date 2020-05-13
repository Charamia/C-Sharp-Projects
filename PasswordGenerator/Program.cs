namespace PasswordGenerator
{

    using System;
    using System.Text;

    internal class Program
    {
        private static readonly Random rndGenerator = new Random();

        private static void InsertRandomSymbols(int count, StringBuilder password, string symbols)
        {
            for (var i = 0; i < count; i++)
            {
                var symbol = symbols[rndGenerator.Next(0, symbols.Length)];
                var randomPosition = rndGenerator.Next(0, password.Length);
                password.Insert(randomPosition, symbol);
            }
        }


        private static void Main()
        {
            var capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var lowerLetters = "abcdefghijklmnopqrstuvwxyz";
            var digits = "0123456789";
            var specialSymbols = "!£$%^&*@~?|";

            var rndGenerator = new Random();
            var password = new StringBuilder();

            InsertRandomSymbols(2, password, capitalLetters);
            InsertRandomSymbols(2, password, lowerLetters);
            InsertRandomSymbols(1, password, digits);
            InsertRandomSymbols(3, password, specialSymbols);
            InsertRandomSymbols(rndGenerator.Next(0, 7), password,
                capitalLetters + lowerLetters + digits + specialSymbols);

            Console.WriteLine(password.ToString());

            // BAD PRACTICE!!!!!!!!! Reuse code!!!
            //for (int i = 0; i < 2; i++)
            //{
            //    char symbol = capitalLetters[rndGenerator.Next(0, capitalLetters.Length)];
            //    int randomPosition = rndGenerator.Next(0, password.Length);
            //    password.Insert(randomPosition, symbol);
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    char symbol = lowerLetters[rndGenerator.Next(0, lowerLetters.Length)];
            //    int randomPosition = rndGenerator.Next(0, password.Length);
            //    password.Insert(randomPosition,symbol);
            //}

            //for (int i = 0; i < 1; i++)
            //{
            //    char symbol = digits[rndGenerator.Next(0, digits.Length)];
            //    int randomPosition = rndGenerator.Next(0, password.Length);
            //    password.Insert(randomPosition, symbol);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    char symbol = specialSymbols[rndGenerator.Next(0, specialSymbols.Length)];
            //    int randomPosition = rndGenerator.Next(0, password.Length);
            //    password.Insert(randomPosition, symbol);
            //}
        }
    }

}