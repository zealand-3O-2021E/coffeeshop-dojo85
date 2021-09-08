using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(string blend, int discount) : base(blend, discount)
        {
        }

        public Cortado(string blend) : base(blend)
        {
        }

        public Cortado(int discount) : base(discount)
        {
        }

        public Cortado()
        {
        }

        public override int Price()
        {
            return 25 - Discount;
        }

        public override string TypeOfCoffee => "Cortado";

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
