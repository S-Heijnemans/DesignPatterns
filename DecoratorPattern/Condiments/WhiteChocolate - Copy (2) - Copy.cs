using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class WhiteChocolate : CondimentDecorator
    {
        public WhiteChocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double price = 0;

            switch (baseBeverage.Size)
            {
                case Size.TALL:
                    price = 0.20;
                    break;

                case Size.GRANDE:
                    price = 0.30;
                    break;

                case Size.VENDI:
                    price = 0.40;
                    break;
            }

            return price + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", White Chocolate";
        }
    }
}
