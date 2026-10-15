using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate(Beverage beverage = null)
        {
            description = "Chocolate";
            this.baseBeverage = beverage;
        
        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            double price = 0;

            switch (Size)
            {
                case Size.TALL:
                    price = 1.99;
                    break;

                case Size.GRANDE:
                    price = 2.99;
                    break;

                case Size.VENDI:
                    price = 3.99;
                    break;
            }

            if (baseBeverage != null)
            {
                price += baseBeverage.cost();
            }

            return price;
        }
    }
}
