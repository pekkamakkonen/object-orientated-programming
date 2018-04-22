using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Shop : IProducts, ICustomers
    {
        //Fields
        public string Name;
        public double Sales;
        List<Product> products = new List<Product>();
        List<Customer> customers = new List<Customer>();

        //Constructors
        public Shop(string name)
        {
            Name = name;
        }

        public Shop(string name, double sales, List<Product> products, List<Customer> customers)
        {
            Name = name;
            Sales = sales;
            this.products = products;
            this.customers = customers;
        }

        public override string ToString()
        {
            return ($"Kaupan nimi: {Name}\nLiikevaihto: {Sales}");
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteiden lukumäärä: {products.Count}");
            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine(product.CalculateTotalValue());
                Console.WriteLine();
            }
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"Asiakkaiden lukumäärä: {customers.Count}\n");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine($"Bonusta kertynyt: {customer.CalculateBonus()}");
                Console.WriteLine("---");
            }
        }
    }
}
