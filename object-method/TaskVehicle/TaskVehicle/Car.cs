using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
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

        public Car(string type, string brand, int yearModel, double price, string engineSize, string model, int doors) : base(type, brand, yearModel, price)
        {
            EngineSize = engineSize;
            Model = model;
            Doors = doors;
        }

        //overrides PrintInfo
        public override void PrintInfo()
        {
            Console.WriteLine($"Tyyppi: {Type}\nMerkki: {Brand}\nVuosimalli: {YearModel}\nHinta: {Price}\nMoottorin koko: {EngineSize}\nMalli: {Model}\nOvien lukumäärä: {Doors}");
        }
    }
}
