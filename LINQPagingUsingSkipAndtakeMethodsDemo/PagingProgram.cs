namespace LINQPagingUsingSkipAndtakeMethodsDemo
{

    using System;
    using System.Linq;

    internal class PagingProgram
    {
        private static void Main()
        {
            /* Why we need Paging in Real-time application?
             * Suppose we have a data source with lots of records and we need to display those records in a view. We can display all the records in a view at once. 
             * If we do so then we will get the following disadvantages.

                    1. Network issue (As huge data is traveled)
                    2. Memory Management (Due to heavy data showing in the view, it may cause memory issue and maybe the page becomes unresponsive)
                    3. Performance (we will get bad performance as it takes more time to travel in the network)
             * So, in order to solve the above problems, we need to go for Paging.
             * 
             * Paging is nothing but a process in which we will divide a large data source into multiple pages. At one page we need to display a 
             * certain number of records. And next records can be visible with next – previous buttons or scroll or using any other techniques.
             * 
             * Advantages of using Paging:
                We will get the following advantages

                    1. Faster data transfer. This is because fewer data will be traveled in the network.
                    2. Improve memory management. This is because we are not showing all the data in a view.
                    3. Better performance.
                    4. Drawback:

              In a client-server architecture, the number of requests between the client and server is increased. In such cases, you may get the data at once and
              store it locally and then implement the paging at the client-side.

              How to implement paging?
              We can implement the paging using the Linq Skip and Take method. Here we need to understand two things one is PageNumber and the other one is the number of records per page.

              Let say Page Number = PN and Number Of Records Per Page = NRP, then you need to use the following formula

              Result = DataSource.Skip((PN – 1) * NRP).Take(NRP)

            First, the program should prompt the user to enter the page number. The page number must be between 1 and 4. If the user does not enter a valid page number, 
            then the program should prompt the user to enter a valid page number. Once the user entered a valid page number, then the program should display the data.
                       
             */

            var RecordsPerPage = 4;
            var PageNumber = 0;
            do
            {
                Console.WriteLine("Enter the Page Number between 1 and 4");
                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {
                    if (PageNumber > 0 && PageNumber < 5)
                    {
                        var employees = Employee.GetAllEmployees()
                            .Skip((PageNumber - 1) * RecordsPerPage)
                            .Take(RecordsPerPage).ToList();
                        Console.WriteLine();
                        Console.WriteLine("Page Number : " + PageNumber);
                        foreach (var emp in employees)
                        {
                            Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Department : {emp.Department}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Page Number");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Page Number");
                }
            } while (true);
        }
    }

}