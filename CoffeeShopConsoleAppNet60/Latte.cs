using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public override double GetPrice()
        {
            return 40;
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
