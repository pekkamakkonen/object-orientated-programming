using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Vehicle
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
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Ajoneuvon tyyppi: {Type}\nMerkki: {Brand}\nVuosimalli: {YearModel}\nHinta: {Price}");
        }
        
    }
    //inheritances class Car from class Vehicle

    class Car : Vehicle
    {
        //fields
        protected string EngineSize;
        protected string Model;
        protected int Doors;

        //constructor
        public Car()
        {
            EngineSize = null;
            Model = null;
            Doors = 0;
        }

        public Car(string engineSize, string model, int doors)
        {
            EngineSize = engineSize;
            Model = model;
            Doors = doors;
        }

        //overrides PrintInfo
        public override void PrintInfo()
        {
            Console.WriteLine($"Moottorin koko: {EngineSize}\nMalli: {Model}\nOvien lukumäärä: {Doors}");
        }
    }
}
