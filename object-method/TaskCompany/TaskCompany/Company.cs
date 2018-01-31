using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class Company
    {
        //Fields
        public string Title;
        public string Address;
        public string Phone;
        public double Outcome;
        public double Expense;

        //Contructor
        public Company()
        {
            Title = null;
            Address = null;
            Phone = null;
            Outcome = 0.00;
            Expense = 0.00;
        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }

        // Copy constructor.
        public Company(Company previousCompany)
        {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            Phone = previousCompany.Phone;
            Outcome = previousCompany.Outcome;
            Expense = previousCompany.Expense;
        }

        //Methods

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Yrityksen nimi: { Title }");
            Console.WriteLine($"Osoite: { Address }");
            Console.WriteLine($"Puhelin: { Phone }");
            Console.WriteLine($"Tulot: { Outcome }");
            Console.WriteLine($"Menot: { Expense }");
        }

        public void Profit()
        {
            double profit = ((Outcome - Expense) / Expense * 100);

            if (profit >= 300)
            {
                Console.WriteLine($"Firman voitto on { Math.Round(profit) } prosenttia suurempi kuin menot eli firmalla menee hyvin.");
            }
            else if (profit >= 200)
            {
                Console.WriteLine($"Firman voitto on { Math.Round(profit) } prosenttia suurempi kuin menot eli firmalla menee tyydyttävästi.");
            }
            else if (profit < 100)
            {
                Console.WriteLine($"Firman voitto on { Math.Round(profit) } prosenttia suurempi kuin menot eli firmalla menee kehnosti.");
            }
        }
    }
}
