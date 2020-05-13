namespace MethodsDemo3
{

    using System;

    internal class Program
    {
        private static void SayMonth(int month)
        {
            string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };

            Console.Write(months[month - 1]);
        }

        private static void PrintPeriod(int firstMonth, int secondMonth)
        {
            var period = secondMonth - firstMonth;
            if (period < 0)
            {
                period += 12;
            }

            Console.Write("From ");
            SayMonth(firstMonth);
            Console.Write(" to ");
            SayMonth(secondMonth);
            Console.WriteLine(" there are {0} months.", period);
        }

        private static void Main()
        {
            PrintPeriod(1, 3);
        }
    }

}