using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car("Auto", "Ferrari", 2018, 5000000.00, "V10", "5-sarja E60", 4);
            vehicle1.PrintInfo();

            Console.WriteLine();
            Vehicle vehicle2 = new Truck("Kuorma-auto", "Iveco EuroCargo", 2004, 13500.00, "5.9 l", "", 2, 11990.00, 20);
            vehicle1.PrintInfo();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
