namespace MethodsDemo5
{

    using System;

    internal class MethodsDemo5
    {
        private static void PrintSum(int a, int b, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }

        private static void Main()
        {
            //PrintSum(2, 5);
            //PrintSum(5, 6, 7);

            //Name("Pesho", lastName: "Peshovski");
            var fullName = FullName("Pesho", "Peshovski");
            Console.WriteLine(fullName);
            Console.WriteLine(fullName + "Pesho");
        }

        //static void Name(string firstName, string middleName = " ", string lastName = " ")
        //{
        //    Console.WriteLine(firstName + " " + middleName + " " + lastName);
        //}

        private static string FullName(string firstName, string middleName = " ", string lastName = " ")
        {
            //return firstName + " " + middleName + " " + lastName; or

            var fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }

}