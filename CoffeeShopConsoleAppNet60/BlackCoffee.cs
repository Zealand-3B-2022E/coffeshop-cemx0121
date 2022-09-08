using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(double discount) : base(discount)
        {
            Price = 20;
        }

        public override string Strength()
        {
            return "Strong";
        }

        public override double GetPrice()
        {
            base.GetPrice();
            return Price - Discount;

        }
    }
}
