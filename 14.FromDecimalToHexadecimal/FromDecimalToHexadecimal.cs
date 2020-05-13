namespace _14.FromDecimalToHexadecimal
{

    using System;

    internal class FromDecimalToHexadecimal
    {
        private static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            var result = string.Empty;
            //string result = string.Empty;

            while (decimalNumber % 16 > 0)
            {
                var ostatuc = decimalNumber % 16;

                if (ostatuc < 10)
                {
                    result += ostatuc.ToString();
                }
                else
                {
                    switch (ostatuc)
                    {
                        case 10:
                            result += "A";
                            break;
                        case 11:
                            result += "B";
                            break;
                        case 12:
                            result += "C";
                            break;
                        case 13:
                            result += "D";
                            break;
                        case 14:
                            result += "E";
                            break;
                        case 15:
                            result += "F";
                            break;
                    }
                }


                decimalNumber /= 16;
            }

            var officialResult = string.Empty;

            for (var i = result.Length - 1; i >= 0; i--)
            {
                officialResult += result[i];
            }


            Console.WriteLine(officialResult);
        }
    }

}