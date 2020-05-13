namespace BunnyWars
{

    using System;

    /// <summary>
    ///     Defines the <see cref="Animal" />.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        ///     Defines the name.
        /// </summary>
        private string name;

        /// <summary>
        ///     Gets or sets the Name.
        /// </summary>
        public string Name
        {
            get => name;
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("name must be longer than 6 symbols");
                }

                name = value;
            }
        }

        /// <summary>
        ///     Gets or sets the Health.
        /// </summary>
        public int Health { get; set; }
    }

}