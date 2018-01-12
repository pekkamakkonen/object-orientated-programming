using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;

        //Contructor
        public Car()
        {
            Brand = null;
            Speed = 0;
        }

        //Methods
        public void AskData()
        {
            Console.WriteLine("Anna auton merkki: ");
            Brand = Console.ReadLine();
            Console.WriteLine("Anna auton nopeus: ");
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki: {Brand}\nNopeus: {Speed}\n");
        }

        public void Accelerate()
        {
            double newSpeed = Speed + (Speed * 0.10);
            Console.WriteLine($"Uusi nopeus on: { newSpeed }");
        }
    }
}
