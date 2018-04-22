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
            Console.ReadKey();
        }
    }
}
