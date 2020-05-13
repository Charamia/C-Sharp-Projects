namespace MegaCollections.Test
{

    public class Program
    {
        private static void Main()

        {
            var deque = new Deque<int>(40);

            deque.AddFront(10);
            deque.AddBack(50);
            // 10 50


            var anotherDeque = new Deque<int>();

            anotherDeque.AddFront(5);
            anotherDeque.AddFront(10);

            var result = deque + anotherDeque; // 10 50 10 5
        }
    }

}