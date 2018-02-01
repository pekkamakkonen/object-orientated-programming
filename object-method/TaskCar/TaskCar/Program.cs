using System;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.AskData();
            newCar.ShowCarInfo();
            newCar.Accelerate(20);
            newCar.Brake();

            Console.WriteLine();

            Car newCar2 = new Car();
            newCar2.AskData();
            newCar2.ShowCarInfo();
            newCar2.Accelerate(-5);
            newCar2.Brake();

            Console.ReadKey();
        }
    }
}
