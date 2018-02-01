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
            Console.WriteLine($"Auton merkki: {Brand}\nNopeus: {Speed} km/h");
        }

        public void Accelerate()
        {
            Speed = Speed + 0;
        }

        public void Accelerate(int addSpeed)
        {
            if (addSpeed > 0)
            {
                Speed = Speed + addSpeed;
                Console.WriteLine($"Auto kiihdyttää. Nopeus kiihdytyksen jälkeen on: { Speed } km/h");
            }
            else
            {
                Console.WriteLine($"Negatiivinen muutos ei ole sallittu!");
            }
        }

        public void Brake()
        {
            Console.WriteLine($"Auto jarruttaa. Nopeus jarrutuksen jälkeen on: { Speed * 0.9 } km/h");
        }
    }
}
