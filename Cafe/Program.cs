using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cafe.Resources;

namespace Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (cooks, ingredients, dishes) = init.run();

            foreach (var dish in dishes)
            {
                dish.Value.getInfo();
                Console.WriteLine();
            }
            
            Console.WriteLine("Please input your choice of dish you would like to be served:");

            Manager manager = new Manager(cooks);

            while (true)
            {
                bool isError = true;
                String order = null;
                while (isError)
                {
                    try
                    {
                        order = Console.ReadLine();
                        isError = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please insert a valid dish name :)");
                        isError = true;
                    }
                }

                if (!dishes.ContainsKey(order))
                {
                    Console.WriteLine("Please insert a dish from the menu");
                }
                else
                {
                    manager.DelegateOrder(dishes[order]);
                }

            }
        }
    }
}
