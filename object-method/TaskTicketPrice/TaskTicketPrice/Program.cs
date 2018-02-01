using System;

namespace TaskTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Pekka", 26, true, false, true);
            customer1.PrintCustomerInfo();
            Console.WriteLine();
            customer1.TicketPrice();
            Console.ReadKey();
        }
    }
}
