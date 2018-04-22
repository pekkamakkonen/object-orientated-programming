using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    abstract class Vehicle
    {
        //fieds
        protected string Type;
        protected string Brand;
        protected int YearModel;
        protected double Price;

        //constructor
        public Vehicle()
        {
            Type = null;
            Brand = null;
            YearModel = 0;
            Price = 0.00;
        }

        public Vehicle(string type, string brand, int yearModel, double price)
        {
            Type = type;
            Brand = brand;
            YearModel = yearModel;
            Price = price;
        }

        //methods
        abstract public void PrintInfo();
        
    }
}
