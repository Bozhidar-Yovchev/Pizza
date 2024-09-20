using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Dough
    {
        private string flour;
        private string bakingTechnique;
        private short mass;
        private const double white = 1.5;
        private const double wholegrain = 1;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1;
        public string Flour
        {
            get { return flour; }
            private set
            {
                if (flour == string.Empty || (value.ToLower() != ("white") && value.ToLower() != ("wholegrain")))
                throw new ArgumentException("There is no such dough");
                flour = value;
            }
        }



        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (bakingTechnique == string.Empty || (value.ToLower() != "chewy" && value.ToLower() != "crispy" && value.ToLower() != "homemade"))
                throw new ArgumentException("There is no such technique");
                bakingTechnique = value;
            }
        }



        public short Mass
        {
            get { return mass; }
            set
            {
                if (value < 0 || value > 200)
                throw new ArgumentException("It must be between 1 and 200 grams");
                mass = value;
            }
        }



        public Dough(string flour, string technique, short mass)
        {
            this.Flour = flour;
            this.BakingTechnique = technique;
            this.Mass = mass;
        }



        public double GetCallories()
        {
            double result = 2 * Mass;
            switch (this.Flour.ToLower())
            {
                case "white": result *= white; break;
                case "wholegrain": result *= wholegrain; break;
            }



            switch (this.BakingTechnique.ToLower())
            {
                case "crispy": result *= crispy; break;
                case "chewy": result *= chewy; break;
                case "homemade": result *= homemade; break;
            }
            return result;
        }

    }
}
