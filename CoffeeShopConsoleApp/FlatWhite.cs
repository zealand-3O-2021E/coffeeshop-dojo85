using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {

        public FlatWhite(int discount) : base(discount)
        {
            ProductPrice = 35;
        }

        public FlatWhite()
        {
            ProductPrice = 35;
        }

        //public override int Price()
        //{
        //    return 35 - Discount;
        //}

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
