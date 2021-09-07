using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(int discount) : base(discount)
        {
            ProductPrice = 25;
        }

        public Cortado()
        {
            ProductPrice = 25;
        }

        //public override int Price()
        //{
        //    return 25 - Discount;
        //}

        public override string Strength()
        {
            return "Medium";
        }

        public int MlMilk()
        {
            return 40;
        }
    }
}
