using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte(int discount) : base(discount)
        {
            ProductPrice = 40;
        }

        public Latte()
        {
            ProductPrice = 40;
        }
        //public override int Price()
        //{
        //    return 40 - Discount;
        //}

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
