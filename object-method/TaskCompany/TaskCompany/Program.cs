using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Company companyDefault = new Company();
            companyDefault.Title = "Firma 1";
            companyDefault.Address = "Puustellintie 6 B 17";
            companyDefault.Phone = "0505287631";
            companyDefault.Outcome = 400.00;
            companyDefault.Expense = 100.00;
            companyDefault.ShowCompanyInfo();
            companyDefault.Profit();

            Console.WriteLine();

            Company company1 = new Company(companyDefault);

            //Vaihdetaan firman nimi ja asetetaan menoiksi 150 euroa

            company1.Title = "Firma 2";
            company1.Expense = 150.00;

            company1.ShowCompanyInfo();
            company1.Profit();

            Console.ReadKey();
        }
    }
}
