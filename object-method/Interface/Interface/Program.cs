using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            products[0] = new Product("Kahvi", 1.20, 1);
            products[1] = new Product("Olut", 1.00, 2);
            products[2] = new Product("MiTu Long Drink", 5.30, 4);

            foreach (var product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine(product.CalculateTotalValue());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
