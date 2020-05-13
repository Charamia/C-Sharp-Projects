namespace Lambda
{

    using System;

    public class Program
    {
        public static string convert(int x)
        {
            return x.ToString();
        }

        public static string SumOfInts(int x, int y)
        {
            return (x + y).ToString();
        }

        public static void Main()
        {
            Func<int, string> lambda = x => x.ToString();

            Func<string, int> convert = text => int.Parse(text);


            Func<int, int, string> labdaSumOfStrings = (x, y) =>
            {
                var result = (x + y).ToString();
                return result;
            };

            var resultFromDelegate = lambda(10);

            Action<int, int> voidDelegate = (x, y) =>
            {
                var sum = x + y;
                Console.WriteLine(sum);
            };

            voidDelegate(10, 50);

            // Lambda expression without parameters
            Action someAction = () => Console.WriteLine(100);

            Action someaction = () => { Console.WriteLine(100); };

            Func<string> returnPesho = () => "Pesho";

            Console.WriteLine(returnPesho);
        }
    }

}