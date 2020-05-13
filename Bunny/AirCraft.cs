namespace Bunny
{

    public class AirCraft
    {
        public AirCraft()
        {
            Fuel = 200M;
        }

        public static int Weight => 250;

        public decimal Fuel { get; set; }

        public void Move()
        {
            Fuel -= 10M;
        }
    }

}