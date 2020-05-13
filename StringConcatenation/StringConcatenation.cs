namespace StringConcatenation
{

    using System;

    internal class StringConcatenation
    {
        private static void Main()
        {
            var firstName = "Svetlin";
            var lastName = "Nakov";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var age = 25;

            var nameAndAge =
                "Name: " + fullName +
                "\nAge: " + age;
            Console.WriteLine(nameAndAge);
        }
    }

}