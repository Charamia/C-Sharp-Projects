namespace TestGenerics
{

    internal class Program
    {
        private static void Main()
        {
            var generic = new GenericClass<Bunny, string>();

            var max = Max(new[] {5, 6, 7});
        }

        private static T Max<T>(T[] data) where T : struct
        {
            return data[0];
        }
    }

}