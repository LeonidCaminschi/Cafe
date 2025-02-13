using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Resources
{
    internal class Dish
    {
        private
            String name;
            String description;
            float price;
            int cookingTime;
            List<Ingredient> ingredients;

        public Dish(String name, String description, int cookingTime, List<Ingredient> ingredients)
        {
            this.name = name;
            this.description = description;
            this.cookingTime = cookingTime;
            this.ingredients = ingredients;
        }

        public float calcPrice()
        {
            if (this.price != 0)
            {
                return this.price;
            }

            float intermidiaryPrice = 0;
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                intermidiaryPrice += ingredients[i].getPrice();
            }
            this.price = intermidiaryPrice * 1.2f;
            return this.price;
        }

        public int getCookingTime()
        {
            return cookingTime;
        }

        public void getInfo()
        {
            Console.WriteLine("Dish name: " + name);
            Console.WriteLine(description);
            Console.WriteLine("Ingredients: " + string.Join(", ", ingredients));
            Console.WriteLine("Price: " + calcPrice());
        }
    }
}
