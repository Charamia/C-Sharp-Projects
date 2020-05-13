namespace TestGenerics
{

    public class GenericClass<T, K>
        where T : Animal, new()
    {
        private readonly T someData;
        private readonly K someOtherData;

        public GenericClass()
        {
            someData = new T();
        }

        public GenericClass(T data, K otherData)
        {
            someData = data;
            someOtherData = otherData;
        }
    }

}