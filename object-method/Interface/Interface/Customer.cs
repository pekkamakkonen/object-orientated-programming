using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Customer : ICustomer
    {
        //Fields
        public string Name;
        
        //Constructors
        public Customer(string name)
        {
            Name = name;
        }

        //Methods
        public override string ToString()
        {
            return ($"Asiakkaan nimi: {Name}\n");
        }

        public string GetCustomer(string name)
        {
            if(Name == name)
            {
                return ToString();
            }
            else
            {
                return null;
            }
        }

        public double CalculateBonus()
        {
            double bonus = 0.00;

            if (bonus <= 1000)
            {
                bonus = 0.02;
            }
            else if (bonus <= 2000)
            {
                bonus = 0.03;
            }
            else
            {
                bonus = 0.05;
            }
      
            return bonus;
        }
    }
}
