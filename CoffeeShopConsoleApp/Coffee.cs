using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        protected int _discount;

        public int Discount
        {
            get => _discount;
            set
            {
                if (value > 5)
                {
                    throw new ArgumentException($"The discount can't be bigger than 5 kr. You entered: {value}");
                }
                _discount = value;
            }
        }

        public int ProductPrice { get; set; }

        public Coffee(int discount)
        {
            Discount = discount;
            ProductPrice = 20;
        }

        public Coffee()
        {
            ProductPrice = 20;
        }

        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int Price()
        {
            return ProductPrice - Discount;
        }

        public abstract string Strength();

        public override string ToString()
        {
            return $"{this.GetType().Name} - Price: {Price()} kr, Strength: {Strength()}";
        }
    }
}
