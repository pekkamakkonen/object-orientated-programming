using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Auto", "Ferrari", 2018, 5000000.00);
            vehicle1.PrintInfo();

            Console.WriteLine();

            Car car1 = new Car("V10", "5-sarja E60", 4);
            car1.PrintInfo();
            Console.ReadKey();
        }
    }
}
