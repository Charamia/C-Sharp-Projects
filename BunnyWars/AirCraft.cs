namespace BunnyWars
{

    using System;

    /// <summary>
    ///     Defines the <see cref="AirCraft" />.
    /// </summary>
    internal class AirCraft
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AirCraft" /> class.
        /// </summary>
        /// <param name="bunny">The bunny<see cref="Bunny" />.</param>
        /// <param name="damage">The damage<see cref="int" />.</param>
        public AirCraft(Bunny bunny, int damage)
        {
            Pilot = bunny;
            Damage = damage;
            Coordinates = new Coordinates();
        }

        /// <summary>
        ///     Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the Damage.
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        ///     Gets the Pilot.
        /// </summary>
        public Bunny Pilot { get; }

        /// <summary>
        ///     Gets the Coordinates.
        /// </summary>
        public Coordinates Coordinates { get; }

        /// <summary>
        ///     The calculateDistance.
        /// </summary>
        /// <param name="first">The first<see cref="AirCraft" />.</param>
        /// <param name="second">The second<see cref="AirCraft" />.</param>
        /// <returns>The <see cref="double" />.</returns>
        public static double calculateDistance(AirCraft first, AirCraft second)
        {
            double xDistance = (first.Coordinates.X - second.Coordinates.X) *
                               (first.Coordinates.X - second.Coordinates.X);
            double yDistance = (first.Coordinates.Y - second.Coordinates.Y) *
                               (first.Coordinates.Y - second.Coordinates.Y);

            return Math.Sqrt(xDistance + yDistance);
        }

        /// <summary>
        ///     The Attack.
        /// </summary>
        /// <param name="target">The target<see cref="AirCraft" />.</param>
        public void Attack(AirCraft target)
        {
            if (Pilot.Colour == target.Pilot.Colour)
            {
                return;
            }

            target.Pilot.Health -= Damage;
        }

        /// <summary>
        ///     The Move.
        /// </summary>
        /// <param name="coor">The coor<see cref="Coordinates" />.</param>
        public void Move(Coordinates coor)
        {
            Coordinates.X = coor.X;
            Coordinates.Y = coor.Y;
        }
    }

}