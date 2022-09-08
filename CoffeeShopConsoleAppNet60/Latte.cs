using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(double discount) : base(discount)
        {
            Price = 40;

        }

        public override double GetPrice()
        {
            base.GetPrice();
            return Price - Discount;
        }

        public int MlMilk()
        {
            return 200;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
