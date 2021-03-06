using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(string blend, int discount) : base(blend, discount)
        {
        }

        public BlackCoffee(string blend) : base(blend)
        {
        }

        public BlackCoffee(int discount) : base(discount)
        {
        }

        public BlackCoffee()
        {

        }

        public override string TypeOfCoffee => "Black Coffee";

        public override string Strength()
        {
            return "Strong";
        }
    }
}
