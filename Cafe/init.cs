using Cafe.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    internal class init
    {
        public static Tuple<List<Cook>, Dictionary<string, Ingredient>, Dictionary<string, Dish>> run() 
        {
            // Cook preparation
            List<Cook> cooks = new List<Cook>
            {
                new Cook("Juan"),
                new Cook("Donatello")
            };

            // Ingridients preparation
            Dictionary<string, Ingredient> ingredients = new Dictionary<string, Ingredient>
            {
                { "Salat", new Ingredient("Salat", 10) },
                { "Fish", new Ingredient("Fish", 25) },
                { "Steak", new Ingredient("Steak", 50) },
                { "Salt", new Ingredient("Salt", 1) },
                { "Pepper", new Ingredient("Pepper", 2) },
                { "Egg", new Ingredient("Egg", 5) },
                { "Potato", new Ingredient("Potato", 3) },
                { "Tomato", new Ingredient("Tomato", 4) },
                { "Olive oil", new Ingredient("Olive oil", 4) }
            };

            // Dish prepratation
            Dictionary<string, Dish> dishes = new Dictionary<string, Dish>
            {
                {
                    "Omlet",
                    new Dish(
                        "Omlet",
                        "Beaten together eggs with salt and pepper",
                        1000 * 60 * 15,
                        new List<Ingredient> { ingredients["Egg"], ingredients["Salt"], ingredients["Pepper"] }) // Corrected list initialization
                },
                {
                    "Meat Salad",
                    new Dish(
                        "Meat Salad",
                        "Generic Salad,tomatoes with steak and fish meat dressed with olive oil salt and pepper",
                        1000 * 60 * 25,
                        new List<Ingredient> { ingredients["Salat"], ingredients["Tomato"], ingredients["Steak"], ingredients["Fish"], ingredients["Olive oil"], ingredients["Salt"], ingredients["Pepper"] })
                },
                {
                    "Fish and chips",
                    new Dish(
                        "Fish and chips",
                        "Generic British food fish and chips dressed with oil and salt",
                        1000 * 60 * 10,
                        new List<Ingredient> { ingredients["Potato"],   ingredients["Fish"], ingredients["Olive oil"], ingredients["Salt"] })
                }
            };

            return new Tuple<List<Cook>, Dictionary<string,Ingredient>, Dictionary<string, Dish>> (cooks, ingredients, dishes);
        }
    }
}
