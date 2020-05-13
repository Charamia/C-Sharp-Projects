namespace FormattingStrings
{

    using System;
    using System.Globalization;
    using System.Threading;

    internal class FormattingStrings
    {
        private static void Main()
        {
            Console.Write("The current culture is: ");
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);

            var number = 42;
            var s = number.ToString("D5"); // 00042
            Console.WriteLine(s);

            s = number.ToString("X"); // 2A
            Console.WriteLine(s);


            s = number.ToString("x4"); // 002a
            Console.WriteLine(s);

            //Change the default culture to Bulgarian
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine("Bulgarian price: {0:C}", number); // 42.00 лв.

            //Print the currency as Canadian dollars
            var culture = new CultureInfo("fr-CA");
            s = number.ToString("C", culture); //42.00 $

            var d = 0.375;
            s = d.ToString("F2"); // 0.38
            Console.WriteLine(s);

            s = d.ToString("F10"); // 0.3750000000
            Console.WriteLine(s);

            var template = "If i were {0}, I would {1}.";
            var sentence1 = string.Format(template, "developer", "know C#");
            Console.WriteLine(sentence1); //If I were developer, I would know C#.

            var sentence2 = string.Format(template, "elephant", "weigh 4500 kg");
            Console.WriteLine(sentence2); // Id I were elephant I would weigh 4500 kg.

            //s = String.Format("{0,10:D", number); //"          42"
            //Console.WriteLine(s);

            //s = String.Format("{0,10:F5", d);  // "     0.37500"
            //Console.WriteLine(s);

            var now = DateTime.Now;
            Console.WriteLine("Now is {0:d.MM.yyyy HH:mm:ss}.", now);
            // Now is 09.10.2019 23:36:41

            //Print the date and time in English (Canada)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Console.WriteLine(now.ToString("dddd, MMMM dd, yyyy h:mm:ss tt"));

            //Print the date and time in Russian (Russia)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.WriteLine(now.ToString("dd MMMM yyyy (dddd), H:mm:ss"));


            Console.WriteLine(1.25); // 1.25 -> the separator will be "," (Russia)

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(1.25); // 1.25 -> the separator will be "." (Invariant)
        }
    }

}