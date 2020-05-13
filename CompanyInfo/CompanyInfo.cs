namespace CompanyInfo
{

    using System;

    internal class CompanyInfo
    {
        private static void Main()
        {
            Console.Write("Please enter company name: ");
            var companyName = Console.ReadLine();
            Console.Write("Please enter company address: ");
            var companyAddress = Console.ReadLine();
            Console.Write("Please enter company phone number: ");
            var companyPnoneNumber = Console.ReadLine();
            Console.Write("Please enter company's fax number :");
            var companyFax = Console.ReadLine();
            Console.Write("Please enter company's website: ");
            var companyWebSite = Console.ReadLine();
            Console.Write("Please enter company's manager first name: ");
            var managerFirstName = Console.ReadLine();
            Console.Write("Please enter company's manager surname: ");
            var managerSurname = Console.ReadLine();
            Console.Write("Please enter company's manager phone number: ");
            var managerNumber = Console.ReadLine();
            Console.WriteLine();
            var companyManager = managerFirstName + " " + managerSurname;


            Console.WriteLine("The company is called {0,50}", companyName);
            Console.WriteLine("Address: {0,50}", companyAddress);
            Console.WriteLine("Company's phone number: {0,50}", companyPnoneNumber);
            Console.WriteLine("Company's fax number {0,50}", companyFax);
            Console.WriteLine("Website: {0,50}", companyWebSite);
            Console.WriteLine();
            Console.Write("{0} is the company manager, and his phone number is {1}", companyManager, managerNumber);
        }
    }

}