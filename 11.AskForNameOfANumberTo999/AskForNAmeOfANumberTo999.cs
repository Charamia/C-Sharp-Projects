namespace _11.AskForNameOfANumberTo999
{

    using System;

    internal class AskForNAmeOfANumberTo999
    {
        private static void PrintHundreds(int digit)
        {
            switch (digit)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("two hundred ");
                    break;
                case 3:
                    Console.Write("three hundred ");
                    break;
                case 4:
                    Console.Write("four hundred ");
                    break;
                case 5:
                    Console.Write("five hundred ");
                    break;
                case 6:
                    Console.Write("six hundred ");
                    break;
                case 7:
                    Console.Write("seven hundred ");
                    break;
                case 8:
                    Console.Write("eight hundred ");
                    break;
                case 9:
                    Console.Write("nine hundred ");
                    break;
                default:
                    Console.Write(" ");
                    break;
            }
        }

        private static void Print1To19(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 11:
                    Console.WriteLine("eleven");
                    break;
                case 12:
                    Console.WriteLine("twelve");
                    break;
                case 13:
                    Console.WriteLine("thirteen");
                    break;
                case 14:
                    Console.WriteLine("fourteen");
                    break;
                case 15:
                    Console.WriteLine("fifteen");
                    break;
                case 16:
                    Console.WriteLine("sexteen");
                    break;
                case 17:
                    Console.WriteLine("seventeen");
                    break;
                case 18:
                    Console.WriteLine("eitheen");
                    break;
                default:
                    Console.WriteLine("nineteen");
                    break;
            }
        }

        private static void Main()
        {
            ushort n;
            ushort.TryParse(Console.ReadLine(), out n);

            if (n >= 0 && n < 20)
            {
                Print1To19(n);
            }
            else if (n >= 20 && n < 100)
            {
                switch (n / 10)
                {
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eithy ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                    default:
                        Console.Write(" ");
                        break;
                }

                switch (n % 10)
                {
                    case 0:
                        Console.WriteLine(" ");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    default:
                        Console.WriteLine("nine");
                        break;
                }
            }
            else if (n > 99 && n < 1000)
            {
                if (n % 100 > 0 && n % 100 < 20)
                {
                    PrintHundreds(n / 100);

                    Console.Write("and ");
                    Print1To19(n % 100);
                }
                else
                {
                    PrintHundreds(n / 100);
                    switch (n / 10 % 10)
                    {
                        case 2:
                            Console.Write("twenty ");
                            break;
                        case 3:
                            Console.Write("thirty ");
                            break;
                        case 4:
                            Console.Write("fourty ");
                            break;
                        case 5:
                            Console.Write("fifty ");
                            break;
                        case 6:
                            Console.Write("sixty ");
                            break;
                        case 7:
                            Console.Write("seventy ");
                            break;
                        case 8:
                            Console.Write("eighty ");
                            break;
                        case 9:
                            Console.Write("ninety ");
                            break;
                        default:
                            Console.Write(" ");
                            break;
                    }

                    switch (n % 10)
                    {
                        case 0:
                            Console.WriteLine(" ");
                            break;
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                        default:
                            Console.WriteLine(" ");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("INSERT NUMBER BETWEEN 0 AND 999 !");
            }
        }
    }

}