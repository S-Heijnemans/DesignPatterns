using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    internal abstract class DrinkShop
    {
        public virtual Beverage OrderDrink(string order, Size size)
        {
            Beverage beverage = CreateDrink(order);

            beverage.Size = size;

            PrintBeverage(beverage);

            return beverage;
        }
            
        protected abstract Beverage CreateDrink(string order);

        protected void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(
                beverage.GetDescription() + " $" +
                beverage.cost().ToString("#.##")
            );
        }
    }
}

