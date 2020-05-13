namespace BunnyWars
{

    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Defines the <see cref="BunnyWarsStart" />.
    /// </summary>
    internal class BunnyWarsStart
    {
        /// <summary>
        ///     The Main.
        /// </summary>
        internal static void Main()
        {
            var vankataBunny = new Bunny("Vankata");

            var currentVankataCarrots = vankataBunny.AddCarrots(100);


            var peshoBunny = new Bunny("Peshooo", ColourType.Blue);
            // ulong currentPeshoCarrots = peshoBunny.AddCarrots(2000);

            var vankataName = vankataBunny.Name;
            vankataBunny.Colour = ColourType.Red;
            var colour = vankataBunny.Colour;


            Console.WriteLine(vankataBunny.IsRetired);
            vankataBunny.Retire();

            vankataBunny.Health -= 250;
            vankataBunny.Retire();


            // Console.WriteLine(vankataBunny.IsRetired);

            var bunnies = new List<Bunny>();

            var random = new Random();

            for (var i = 0; i < 100; i++)
            {
                var currentBunny = new Bunny(new string((char) i, 10));
                currentBunny.Health = random.Next(0, 100);
                bunnies.Add(currentBunny);
            }


            var vankataAndPesho = new List<Bunny>
            {
                vankataBunny,
                peshoBunny
            };

            //foreach(var bunny in vankataAndPesho)
            //{
            //    Console.WriteLine(bunny.Name);
            //}


            var firstAirCraft = new AirCraft(vankataBunny, 50);
            var secondAirCraft = new AirCraft(peshoBunny, 100);

            firstAirCraft.Attack(secondAirCraft);

            Console.WriteLine(secondAirCraft.Pilot.Health);

            firstAirCraft.Move(new Coordinates(15, 20));
            secondAirCraft.Move(new Coordinates(25, 40));

            var distance = AirCraft.calculateDistance(firstAirCraft, secondAirCraft);

            Console.WriteLine(distance);

            Console.WriteLine(vankataBunny.Damage);

            var colourType = ColourType.Red;

            Console.WriteLine((int) colourType);
        }
    }

}