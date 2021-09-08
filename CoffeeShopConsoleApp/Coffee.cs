using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffee orders
    /// </summary>
    public abstract class Coffee
    {
        private int _discount;
        private string _blend;

        public Coffee(string blend)
        {
            _blend = blend;
        }

        public Coffee(int discount)
        {
            Discount = discount;
        }

        public Coffee()
        {
        }

        public int Discount
        {
            get => _discount;
            set
            {
                if (value > 5 || value < 0)
                {
                    throw new ArgumentException($"The discount must be between 0 and 5 kr. You entered: {value}");
                }
                _discount = value;
            }
        }

        public abstract string TypeOfCoffee { get; }
        
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, because it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int Price()
        {
            return 20 - Discount;
        }

        public abstract string Strength();

        public virtual string CoffeeType()
        {
            return !string.IsNullOrEmpty(_blend) ? $"{TypeOfCoffee}, {_blend}" : TypeOfCoffee;
        }

        public override string ToString()
        {
            return $"{CoffeeType()} - Price: {Price()} kr, Strength: {Strength()}";
        }
    }
}
