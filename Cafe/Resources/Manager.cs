using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Resources
{
    internal class Manager
    {
        private
            List<Cook> cooks;

        public Manager(List<Cook> cooks) 
        {
            this.cooks = cooks;
        }

        public void DelegateOrder(Dish dish)
        {
            Tuple<int,int> minDishes = new Tuple<int, int>(-1, 6);
            for (int i = 0; i < cooks.Count; i++)
            {
                if (cooks[i].getNrofOrders() < minDishes.Item2)
                {
                    minDishes = new Tuple<int, int>(i, cooks[i].getNrofOrders());
                }
            }
            
            if (minDishes.Item2 == 5) 
            {
                long minTimeRemaining = 1 << 16;
                foreach (var cook in cooks)
                {
                    if (cook.tillNextOrder() < minTimeRemaining)
                    {
                        minTimeRemaining = cook.tillNextOrder();
                    }
                }
                Console.WriteLine("Sorry but the staff at the moment are busy the closest to finishing is " + minTimeRemaining / 60 + " minutes");
                return;
            }

            Console.WriteLine("Estimated time of preparation of the dish is around " + dish.getCookingTime() / (1000 * 60) + " minutes.");
            cooks[minDishes.Item1].Order(dish);
        }
    }
}
