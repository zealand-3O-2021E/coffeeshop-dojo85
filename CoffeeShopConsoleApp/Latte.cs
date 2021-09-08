using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte(string blend) : base(blend)
        {
        }

        public Latte(int discount) : base(discount)
        {
        }

        public Latte()
        {
        }

        public override string TypeOfCoffee => "Latte";

        public override int Price()
        {
            return 40 - Discount;
        }


        public override string Strength()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 200;
        }

    }
}
