namespace ALotOFFeatures
{

    using System;

    internal class ExtensiounsDemo
    {
        private static void Main()
        {
            var pesho = "Pesho";
            var agregatedPesho = pesho.AggregateWith(10);
            Console.WriteLine(agregatedPesho);

            var agrPesho = pesho.AggregateWith(10, ',');
            Console.WriteLine(agrPesho);
        }
    }

}