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

        public int Discount { get; set; }
        public Coffee()
        {

        }

        public virtual double GetPrice()
        {
            return 20;
        }

        public abstract string Strength();
        
    }
}
