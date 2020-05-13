namespace MegaCollections
{

    using System;

    [Required]
    [Author("Elena Shumanova")]
    [Author("Misho Petrov")]
    public class Deque<T>
    {
        private const int InitialSize = 16;
        private int backIndex;

        private T[] data;
        private int frontIndex;


        public Deque()
            : this(InitialSize)
        {
        }

        public Deque(uint initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial of Deque must be bigger than 2");
            }

            data = new T[initialSize];
            frontIndex = Capacity / 2 - 1;
            backIndex = Capacity / 2;
        }

        public int Count => backIndex - frontIndex - 1;

        public int Capacity => data.Length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                return data[frontIndex + index + 1];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                data[frontIndex + index + 1] = value;
            }
        }

        public void AddFront(T element)
        {
            if (frontIndex < 0)
            {
                ResizeData();
            }

            data[frontIndex] = element;
            frontIndex--;
        }


        public void AddBack(T element)
        {
            if (backIndex == Capacity)
            {
                ResizeData();
            }

            data[backIndex] = element;
            backIndex++;
        }

        public T RemoveFront()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            frontIndex++;
            return data[frontIndex];
        }

        public T RemoveBack()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            backIndex--;
            return data[backIndex];
        }

        public T PeekFront()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            return data[frontIndex + 1];
        }

        public T PeekBack()
        {
            return data[backIndex - 1];
        }

        public static Deque<T> operator +(Deque<T> first, Deque<T> second)
        {
            var result = new Deque<T>();

            for (var i = 0; i < first.Count; i++)
            {
                result.AddBack(first[i]);
            }

            for (var i = 0; i < second.Count; i++)
            {
                result.AddBack(second[i]);
            }

            return result;
        }

        private void ResizeData()
        {
            var newSize = Capacity * 2;
            var newData = new T[newSize];

            var currentFrontIndex = Capacity / 2;
            var currentBackIndex = Capacity / 2;

            var newFrontIndex = newSize / 2 - 1;
            var newBackIndex = newSize / 2;

            while (true)
            {
                if (currentFrontIndex <= frontIndex && currentBackIndex >= backIndex)
                {
                    break;
                }

                if (currentFrontIndex > frontIndex)
                {
                    newData[newFrontIndex] = data[currentFrontIndex];
                    newFrontIndex--;
                    currentFrontIndex--;
                }

                if (currentBackIndex < backIndex)
                {
                    newData[newBackIndex] = data[currentBackIndex];
                    newBackIndex++;
                }

                currentBackIndex++;
                currentFrontIndex--;
            }

            data = newData;
            frontIndex = newFrontIndex;
            backIndex = newBackIndex;
        }
    }

}