using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Person
    {
        //Fields
        public string Name;
        private int _age;

        //Constructor
        public Person()
        {
            Name = "unknown";
            _age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            _age = age;
        }

        // Methods
        public void GrowOld()
        {
            _age++;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi: {Name} \nIkä: {_age}\nAikuinen: {IsAdult()}");
        }

        public bool IsAdult()
        {

            return _age >= 18;

            /* 
            
            Sama toisella tavalla:
            
            if (_age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            */                
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
