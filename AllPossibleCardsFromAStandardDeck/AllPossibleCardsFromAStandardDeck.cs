namespace AllPossibleCardsFromAStandardDeck
{

    using System;

    internal class AllPossibleCardsFromAStandardDeck
    {
        private static void Main()
        {
            for (var i = 0; i < 4; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine();
                }

                for (var j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write("Heart ");
                            break;
                        case 1:
                            Console.Write("Diamond ");
                            break;
                        case 2:
                            Console.Write("Spade ");
                            break;
                        case 3:
                            Console.Write("Club ");
                            break;
                    }

                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("2");
                            break;
                        case 1:
                            Console.WriteLine("3");
                            break;
                        case 2:
                            Console.WriteLine("4");
                            break;
                        case 3:
                            Console.WriteLine("5");
                            break;
                        case 4:
                            Console.WriteLine("6");
                            break;
                        case 5:
                            Console.WriteLine("7");
                            break;
                        case 6:
                            Console.WriteLine("8");
                            break;
                        case 7:
                            Console.WriteLine("9");
                            break;
                        case 8:
                            Console.WriteLine("10");
                            break;
                        case 9:
                            Console.WriteLine("J");
                            break;
                        case 10:
                            Console.WriteLine("Q");
                            break;
                        case 11:
                            Console.WriteLine("K");
                            break;
                        case 12:
                            Console.WriteLine("A");
                            break;
                    }
                }
            }

            Console.ReadLine();
        }
    }

}