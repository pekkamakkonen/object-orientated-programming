using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Product
    {
        //fields
        public string ProductName;
        public double UnitPrice;
        public int Count;

        //constructor
        public Product(string productName, double unitPrice, int count)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            Count = count;
        }

        //methods
        public override string ToString()
        {
            return ($"Tuotteen nimi: {ProductName}\nYksikköhinta: {UnitPrice}\nMäärä: {Count}");
        }

        public string GetProduct(string productName)
        {
            if(ProductName == productName)
            {
                return ToString();
            }
            else
            {
                return null;
            }
        }

        public string CalculateTotalValue()
        {
            double totalValue = UnitPrice * Count;
            return ($"Yhteishinta: {totalValue}");
        }
    }
}
