namespace FromHexadecimalToDecimalNotation
{

    using System;

    internal class FromHexadecimalTodDecimal
    {
        private static void Main()
        {
            var hexadecimalNumber = Console.ReadLine();
            double individualResult = 0;

            var count = 0;

            for (var i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                double decimalNumber = 0;

                var numb = 0;

                if (int.TryParse(hexadecimalNumber[i].ToString(), out numb))
                {
                    if (numb < 10)
                    {
                        decimalNumber = numb;
                    }
                }
                else
                {
                    switch (hexadecimalNumber[i])
                    {
                        case 'A':
                            decimalNumber = 10;
                            break;
                        case 'B':
                            decimalNumber = 11;
                            break;
                        case 'C':
                            decimalNumber = 12;
                            break;
                        case 'D':
                            decimalNumber = 13;
                            break;
                        case 'E':
                            decimalNumber = 14;
                            break;
                        case 'F':
                            decimalNumber = 15;
                            break;
                    }
                }

                individualResult += decimalNumber * Math.Pow(16, count);

                count++;
            }

            Console.WriteLine(individualResult);
        }
    }

}