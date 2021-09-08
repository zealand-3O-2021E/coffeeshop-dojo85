using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {
        public FlatWhite(string blend) : base(blend)
        {
        }

        public FlatWhite(int discount) : base(discount)
        {
        }

        public FlatWhite()
        {
        }

        public override string TypeOfCoffee => "Flat White";

        public override int Price()
        {
            return 35 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 250;
        }

    }
}
