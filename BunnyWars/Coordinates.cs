namespace BunnyWars
{

    /// <summary>
    ///     Defines the <see cref="Coordinates" />.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Coordinates" /> class.
        /// </summary>
        public Coordinates()
            : this(0, 0)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Coordinates" /> class.
        /// </summary>
        /// <param name="x">The x<see cref="int" />.</param>
        /// <param name="y">The y<see cref="int" />.</param>
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        ///     Gets or sets the X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///     Gets or sets the Y.
        /// </summary>
        public int Y { get; set; }
    }

}