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
            companyDefault.Outcome = 300.00;
            companyDefault.Expense = 100.00;
            companyDefault.ShowCompanyInfo();
            companyDefault.Profit();

            Console.WriteLine();

            Company company1 = new Company(companyDefault);

            //Vaihdetaan firman nimi ja asetetaan tuloiksi 350 euroa ja  menoiksi 200 euroa

            company1.Title = "Firma 2";
            company1.Outcome = 350.00;
            company1.Expense = 200.00;

            company1.ShowCompanyInfo();
            company1.Profit();

            Console.ReadKey();
        }
    }
}
