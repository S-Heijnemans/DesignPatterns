using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    internal class SvenCoffeeShop : DrinkShop
    {
        protected override Beverage CreateDrink(string order)
        {
            Beverage beverage = null;

            if (order.Equals("espresso"))
            {
                beverage = new Espresso();
            }
            else if (order.Equals("doppio"))
            {
                beverage = new Espresso();
            }
            else if (order.Equals("lungo"))
            {
                beverage = new Espresso();
                beverage = new Water(beverage);
            }
            else if (order.Equals("americano"))
            {
                beverage = new Espresso();
                beverage = new Water(beverage);
                beverage = new Water(beverage);
            }
            else if (order.Equals("macchiato"))
            {
                beverage = new Espresso();
                beverage = new MilkFoam(beverage);
            }
            else if (order.Equals("corretta"))
            {
                beverage = new Espresso();
                beverage = new Liqour(beverage);
            }
            else if (order.Equals("conPanna"))
            {
                beverage = new Espresso();
                beverage = new Whip(beverage);
            }
            else if (order.Equals("cappucinno"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (order.Equals("cafféLatte"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (order.Equals("flatWhite"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
            }
            else if (order.Equals("romana"))
            {
                beverage = new Espresso();
                beverage = new Lemon(beverage);
            }
            else if (order.Equals("morocchino"))
            {
                beverage = new Espresso();
                beverage = new ChocolateCondoment(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (order.Equals("mocha"))
            {
                beverage = new Espresso();
                beverage = new ChocolateCondoment(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Whip(beverage);
            }
            else if (order.Equals("bicerin"))
            {
                beverage = new Espresso();
                beverage = new BlackChocolate(beverage);
                beverage = new WhiteChocolate(beverage);
                beverage = new Whip(beverage);
            }
            else if (order.Equals("breve"))
            {
                beverage = new Espresso();
                beverage = new MilkFoam(beverage);
                beverage = new HalfMilk(beverage);
            }
            else if (order.Equals("rafcoffee"))
            {
                beverage = new Espresso();
                beverage = new VanillaSugar(beverage);
                beverage = new Cream(beverage);
            }
            else if (order.Equals("meadraf"))
            {
                beverage = new Espresso();
                beverage = new Honey(beverage);
                beverage = new Cream(beverage);
            }
            else if (order.Equals("galao"))
            {
                beverage = new Espresso();
                beverage = new MilkFoam(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (order.Equals("cafféaffogato"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new IceCream(beverage);
            }
            else if (order.Equals("viennacoffee"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new Whip(beverage);
                beverage = new Whip(beverage);
            }
            else if (order.Equals("glace"))
            {
                beverage = new Espresso();
                beverage = new IceCream(beverage);
            }
            else if (order.Equals("chocolatemilk"))
            {
                beverage = new Chocolate();
                beverage = new Milk(beverage);
                beverage = new Milk(beverage);
            }
            else if (order.Equals("demicréme"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new Cream(beverage);
                beverage = new Cream(beverage);
            }
            else if (order.Equals("lattemacchiato"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (order.Equals("freddo"))
            {
                beverage = new Espresso();
                beverage = new Liqour(beverage);
                beverage = new Ice(beverage);
            }
            else if (order.Equals("frappuccino"))
            {
                beverage = new Espresso();
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Whip(beverage);
            }
            else if (order.Equals("caramelfrappuccino"))
            {
                beverage = new Espresso();
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Cream(beverage);
                beverage = new Syrup(beverage);
            }
            else if (order.Equals("frappe"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new IceCream(beverage);
            }
            else if (order.Equals("irishCoffee"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new Whiskey(beverage);
                beverage = new Whip(beverage);
            }

            return beverage;
        }
    }
}
