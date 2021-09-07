using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Americano : Coffee
    {
        public Americano(int discount) :base(discount)
        {
            ProductPrice = 30;
        }
        public Americano()
        {
            ProductPrice = 30;
        }

        //public override int Price()
        //{
        //    return 30 - Discount;
        //}

        public override string Strength()
        {
            return "Strong";
        }
    }
}
