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
            Beverage bevarage = new CreateDrink(order, size);


            //if (order.Equals("lungo"))
            //{
            //    bevarage = new Espresso();
            //    bevarage.Size = size;
            //    bevarage = new Water(bevarage);
            //}

            PrintBeverage(bevarage);

            return bevarage;
        }
        protected abstract Bevarage CreatePizza(string order, Size size);
    }
}
