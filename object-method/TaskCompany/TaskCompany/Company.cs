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

        //Methods
        public void Profit()
        {
            double profit = (Outcome - Expense) / (Expense * 100);

            if (profit >= 200)
            {
                Console.WriteLine("Firmalla menee tyydyttävästi.");
            }
            else if (profit >= 300)
            {
                Console.WriteLine("Firmalla menee hyvin.");
            }
            else
            {
                Console.WriteLine("Firmalla menee kehnosti.");
            }
        }
    }
}
