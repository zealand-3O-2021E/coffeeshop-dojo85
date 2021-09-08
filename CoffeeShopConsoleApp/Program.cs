using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffee in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(),
                new Latte(),
                new Cortado(),
                new BlackCoffee(2),
                new Latte(3),
                new Americano(4),
                new FlatWhite("Arabica"),
                new Americano("Espresso Blend", 4)
                

            };

            // a list of products containing milk only
            // only objects of types that implement the IMilk interface
            List<IMilk> milkList = new List<IMilk>();

            foreach (var coffee in orderList)
            {
                if(coffee is IMilk) milkList.Add(coffee as IMilk);
            }

            Console.WriteLine("First list: all products");
            foreach (var coffee in orderList)
            {
                Console.WriteLine(coffee);
            }

            Console.WriteLine();
            Console.WriteLine("Products with milk");
            foreach (var drink in milkList)
            {
                Console.WriteLine(drink);
            }


        }
    }
}
