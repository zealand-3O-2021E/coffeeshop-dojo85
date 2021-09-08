using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Americano : Coffee
    {
        public Americano(string blend, int discount) : base(blend, discount)
        {
        }

        public Americano(string blend) : base(blend)
        {
        }

        public Americano(int discount) :base(discount)
        {
        }
        public Americano()
        {
        }

        public override string TypeOfCoffee => "Americano";

        public override int Price()
        {
            return 30 - Discount;
        }

        public override string Strength()
        {
            return "Strong";
        }

    }
}
