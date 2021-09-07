using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee
    {
        public override int Price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
