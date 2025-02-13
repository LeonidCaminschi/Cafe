using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Resources
{
    internal class Ingredient
    {
        private
            String name;
            float price;

        public Ingredient(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public float getPrice()
        {
            return price;
        }

        public String getName()
        {
            return name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
