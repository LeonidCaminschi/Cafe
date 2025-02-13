using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cafe.Resources
{
    internal class Cook
    {
        private
            String name;
            Dictionary<int, Tuple<long, long, Thread>> orders = new Dictionary<int, Tuple<long, long, Thread>>();
            int totalCookTime;
            static Mutex mut = new Mutex();
            int orderIndex = 1;

        public Cook(string name)
        {
            this.name = name;
        }

        public void Order(Dish dish)
        {
            long time = DateTimeOffset.Now.ToUnixTimeSeconds();
            Thread order = new Thread(() => cook(orderIndex, dish.getCookingTime()));
            totalCookTime += dish.getCookingTime();
            orders.Add(orderIndex, new Tuple<long, long, Thread>(time, dish.getCookingTime(), order));
            if (orderIndex == 100)
            {
                orderIndex = 1;
            }
            else
            {
                orderIndex++;
            }
            order.Start();
        }

        public int getNrofOrders()
        {
            return orders.Count;
        }

        private void cook(int id, int time)
        {
            Thread.Sleep(time);
            mut.WaitOne();
            orders[id].Item3.Join();
            orders.Remove(id);
            mut.ReleaseMutex();
        }

        public long tillNextOrder()
        {
            long minTime = 1000 * 60 * 300; // setting biggest value of time compared to other dishes
            foreach (var order in orders)
            {
                long timeRemaining = (order.Value.Item2 / 1000) - (DateTimeOffset.Now.ToUnixTimeSeconds() - order.Value.Item1);
                //Console.WriteLine((order.Key.Item2 / 1000) - (DateTimeOffset.Now.ToUnixTimeSeconds() - order.Key.Item1));
                if (timeRemaining < minTime)
                {
                    minTime = timeRemaining;
                }
            }
            //Console.WriteLine(minTime);
            return minTime;
        }
    }
}
