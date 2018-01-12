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
            newCar.Accelerate();

            Car newCar2 = new Car();
            newCar2.AskData();
            newCar2.ShowCarInfo();
            newCar2.Accelerate();

            Console.ReadKey();
        }
    }
}
