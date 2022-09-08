using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(double discount) : base(discount)
        {
            Price = 25;
        }

        public override double GetPrice()
        {
            base.GetPrice();
            return Price - Discount;
        }

        public int MlMilk()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
