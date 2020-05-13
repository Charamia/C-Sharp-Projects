namespace AnonymousTypes
{

    using System;
    using System.Collections.Generic;

    internal class AnyTypes
    {
        public static void Main()
        {
            var point = new
            {
                X = 10,
                Y = 100,
                Coordinates = new List<int> {100, 200}
            };

            var anotherPoint = new
            {
                X = 9,
                Y = 59
            };


            var list = point.Coordinates;
            list.Add(500);

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            var collection = new[]
            {
                4, 6, 10
            };

            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }

            var collectionOfObjects = new[]
            {
                new List<string> {"Pesho"},
                new List<string> {"Gosho"}
            };

            var collectionOfAnonymousTypes = new[]
            {
                new {X = 10, Y = 20},
                new {X = 100, Y = 200}
            };

            foreach (var obj in collectionOfAnonymousTypes)
            {
                Console.WriteLine(obj.X + " " + obj.Y);
            }
        }
    }

}