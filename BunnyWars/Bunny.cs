namespace BunnyWars
{

    /// <summary>
    ///     Defines the <see cref="Bunny" />.
    /// </summary>
    public class Bunny : Animal
    {
        /// <summary>
        ///     Defines the numberOfLegs.
        /// </summary>
        public const int numberOfLegs = 4;

        /// <summary>
        ///     Defines the InitialHealth.
        /// </summary>
        private const int InitialHealth = 200;

        /// <summary>
        ///     Defines the InitialCarrots.
        /// </summary>
        private const int InitialCarrots = 0;

        /// <summary>
        ///     Defines the carrotsCount.
        /// </summary>
        private ulong carrotsCount;

        /// <summary>
        ///     Defines the colour.
        /// </summary>
        private ColourType colour;

        //private bool isRetired;


        //List<int> ne6tosi;
        /// <summary>
        ///     Initializes a new instance of the <see cref="Bunny" /> class.
        /// </summary>
        /// <param name="bunnyName">The bunnyName<see cref="string" />.</param>
        public Bunny(string bunnyName)
        {
            Name = bunnyName;
            Health = InitialHealth;
            carrotsCount = InitialCarrots;
        }

        //reuse of Constructor
        /// <summary>
        ///     Initializes a new instance of the <see cref="Bunny" /> class.
        /// </summary>
        /// <param name="bunnyName">The bunnyName<see cref="string" />.</param>
        /// <param name="playerColour">The playerColour<see cref="ColourType" />.</param>
        public Bunny(string bunnyName, ColourType playerColour)
            : this(bunnyName)
        {
            colour = playerColour;
        }

        /// <summary>
        ///     Gets or sets the Colour.
        /// </summary>
        public ColourType Colour
        {
            get => colour;
            set => colour = value;
        }

        /// <summary>
        ///     Gets a value indicating whether IsRetired.
        /// </summary>
        public bool IsRetired { get; private set; }

        /// <summary>
        ///     Gets the Damage.
        /// </summary>
        public int Damage
        {
            get
            {
                if (Health < 0)
                {
                    return InitialHealth;
                }

                var damage = InitialHealth - Health;

                return damage;
            }
        }

        /// <summary>
        ///     The AddCarrots.
        /// </summary>
        /// <param name="carrots">The carrots<see cref="ulong" />.</param>
        /// <returns>The <see cref="ulong" />.</returns>
        public ulong AddCarrots(ulong carrots)
        {
            carrotsCount += carrots;
            return carrotsCount;
        }

        //we order the members of the class in the following order:
        //constants ->  fields ->  constructors ->  properties -> methods
        /// <summary>
        ///     The Retire.
        /// </summary>
        public void Retire()
        {
            if (Health < 0)
            {
                IsRetired = true;
            }
        }
    }

}