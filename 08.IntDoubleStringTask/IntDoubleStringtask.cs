namespace _08.IntDoubleStringTask
{

    using System;

    internal class IntDoubleStringtask
    {
        private static void Main()
        {
            Console.WriteLine(
                "Please choose your input data type:\n 0 --> int\n 1 --> double\n 2 --> string\n ... and hit ENTER");
            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Please enter your Integer number: ");
                    var a = int.Parse(Console.ReadLine());
                    Console.WriteLine("The result is {0}", a + 1);
                    break;
                case 1:
                    Console.WriteLine("Please enter your Double number: ");
                    var b = double.Parse(Console.ReadLine());
                    Console.WriteLine("The result is {0}", b + 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter your String number: ");
                    var c = Console.ReadLine();
                    Console.WriteLine("The result is {0}", c + "*");
                    break;
                default:
                    Console.WriteLine("You have entered Invalid variable");
                    break;
            }
        }
    }

}