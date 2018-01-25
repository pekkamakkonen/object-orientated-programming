using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Company companyDefault = new Company();
            companyDefault.Title = "Firma 1";
            companyDefault.Outcome = 200.00;
            companyDefault.Expense = 0.00;
            companyDefault.Profit();

            Console.ReadKey();
        }
    }
}
