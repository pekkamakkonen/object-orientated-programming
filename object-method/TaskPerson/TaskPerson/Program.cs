using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personPekka = new Person();
            personPekka.Name = "Pekka M";
            personPekka.GrowOld();
            personPekka.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();
        }
    }
}
