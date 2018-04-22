using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan kauppa
            Shop shop1 = new Shop("Ravintola Skinnarila");

            //Lisätään tuotteita
            shop1.AddProduct(new Product("Kahvi", 1.20, 1));
            shop1.AddProduct(new Product("Ruoka 1", 2.20, 2));
            shop1.AddProduct(new Product("Ruoka 2", 2.60, 3));

            //Lisätään asiakkaita
            shop1.AddCustomer(new Customer("Pekka Makkonen"));
            shop1.AddCustomer(new Customer("Antti Karjalainen"));
            shop1.AddCustomer(new Customer("Tuomas Käyhty"));

            //Tulostetaan tuotteet ja asiakkaat
            shop1.PrintCustomers();
            shop1.PrintProducts();

            Console.ReadKey();
        }
    }
}
