namespace DynamicType
{

    using System;

    public class DynType
    {
        public static void Main()
        {
            var annType = new Student();


            dynamic dyn = 5;
            dyn = new Student();
            dyn.Name = "Pesho";
            Console.WriteLine(dyn.Name);
            //dynamic should never be returned as dynamic, as it causes many mistakes, it's unreadable and slower

            var result = Sum<int>(5, 10);
            var text = Sum<string>("Pesho", "Gosho");
            Console.WriteLine(text);

            object obj = new Student();
            //obj.Name = "Pesho"; does not compile
        }

        public static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }
    }

}