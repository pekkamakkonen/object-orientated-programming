using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Truck : Car
    {
        //fields
        protected double WeightOfCargo;
        protected double ConsumptionPerKg;

        //contructor
        public Truck(string type, string brand, int yearModel, double price, string engineSize, string model, int doors, double weightOfCargo, double consumptionPerKg) : base(type, brand, yearModel, price, engineSize, model, doors)
        {
            WeightOfCargo = weightOfCargo;
            ConsumptionPerKg = consumptionPerKg;
        }

        //methods
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Kuorman paino: {WeightOfCargo}\nKulutus per kg: {ConsumptionPerKg}");
        }

        protected double CalculateConsumption()
        {
            double consumption = WeightOfCargo / ConsumptionPerKg;
            return consumption;
        }


    }
}
