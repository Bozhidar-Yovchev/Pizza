using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Topping
    {
        private const double meat = 1.2;
        private const double veggies = 0.8;
        private const double cheese = 1.1;
        private const double sauce = 0.9;
        private string type;
        private double mass;

        public string Type
        {
            get { return type; }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "cheese" && value.ToLower() != "veggies" && value.ToLower() != "sauce")
                    throw new ArgumentException($"Няма такава добавка");
                type = value;
            }

        }
        public double Mass
        {
            get { return mass; }
            set
            {
                if (value > 1 || value < 50)
                    throw new ArgumentException($"Теглото трябва да бъде между 1 и 50 г.");
                mass = value;
            }
        }
        public Topping(string type, double mass)
        {
            this.Type = type;
            this.Mass = mass;
        }
        public double Calories()
        {
            double calories = 0;
            switch (type)
            {
                case "meat": calories = meat * 2 * mass; break;
                case "veggies": calories = veggies * 2 * mass; break;
                case "cheese": calories = cheese * 2 * mass; break;
                case "sauce": calories = sauce * 2 * mass; break;
            }
            return calories;
        }


    }

}
    

