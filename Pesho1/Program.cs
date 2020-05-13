namespace Pesho1
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var records = new List<Pesho>
            {
                new Pesho {Period = 1, Year = 2019},
                new Pesho {Period = 2, Year = 2019},
                new Pesho {Period = 3, Year = 2019},
                new Pesho {Period = 4, Year = 2019},
                new Pesho {Period = 5, Year = 2019},
                new Pesho {Period = 6, Year = 2019},
                new Pesho {Period = 7, Year = 2019},
                new Pesho {Period = 8, Year = 2019},
                new Pesho {Period = 9, Year = 2019},
                new Pesho {Period = 10, Year = 2019},
                new Pesho {Period = 11, Year = 2019},
                new Pesho {Period = 12, Year = 2019},
                new Pesho {Period = 1, Year = 2020},
                new Pesho {Period = 2, Year = 2020},
                new Pesho {Period = 3, Year = 2020}
            };

            var result = records.Where(x => x.Period > 5);

            foreach (var res in result)
            {
                Console.WriteLine(res.Period + " " + res.Year);
            }
        }

        private class Pesho
        {
            public int Period { get; set; }
            public int Year { get; set; }
        }
    }

}