using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public double Price { get; set; }

        public double Discount { get; set; }
        public Coffee(double discount)
        {
            Discount = discount;
        }

        public virtual double GetPrice()
        {
            if (Discount > 5)
            {
                throw new ArgumentException("For stor discount!");
            }
            else
            {
                return Price - Discount;
            }
        }

        public abstract string Strength();
        
    }
}
