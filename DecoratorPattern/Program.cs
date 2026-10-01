using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SvenCoffeeShop shop = new SvenCoffeeShop();

            Beverage espresso = shop.OrderDrink("espresso", Size.TALL);

            Beverage doppio = shop.OrderDrink("doppio", Size.VENDI);

            Beverage lungo = shop.OrderDrink("lungo", Size.GRANDE);

            Beverage americano = shop.OrderDrink("americano", Size.TALL);

            Beverage macchiato = shop.OrderDrink("macchiato", Size.TALL);

            Beverage corretta = shop.OrderDrink("corretta", Size.VENDI);

            Beverage conPanna = shop.OrderDrink("conPanna", Size.GRANDE);

            Beverage cappucinno = shop.OrderDrink("cappucinno", Size.GRANDE);

            Beverage cafféLatte = shop.OrderDrink("cafféLatte", Size.TALL);

            Beverage flatWhite = shop.OrderDrink("flatWhite", Size.TALL);

            Beverage romana = shop.OrderDrink("romana", Size.TALL);

            Beverage morocchino = shop.OrderDrink("morocchino", Size.TALL);

            Beverage mocha = shop.OrderDrink("mocha", Size.TALL);

            Beverage bicerin = shop.OrderDrink("bicerin", Size.TALL);

            Beverage breve = shop.OrderDrink("breve", Size.TALL);

            Beverage rafcoffee = shop.OrderDrink("rafcoffee", Size.TALL);

            Beverage meadraf = shop.OrderDrink("meadraf", Size.TALL);

            Beverage galao = shop.OrderDrink("galao", Size.TALL);

            Beverage cafféaffogato = shop.OrderDrink("cafféaffogato", Size.TALL);

            Beverage viennacoffee = shop.OrderDrink("viennacoffee", Size.TALL);

            Beverage glace = shop.OrderDrink("glace", Size.TALL);

            Beverage chocolatemilk = shop.OrderDrink("chocolatemilk", Size.TALL);

            Beverage demicréme = shop.OrderDrink("demicréme", Size.TALL);

            Beverage lattemacchiato = shop.OrderDrink("lattemacchiato", Size.TALL);

            Beverage freddo = shop.OrderDrink("freddo", Size.TALL);

            Beverage frappuccino = shop.OrderDrink("frappuccino", Size.TALL);

            Beverage caramelfrappuccino = shop.OrderDrink("caramelfrappuccino", Size.TALL);

            Beverage frappe = shop.OrderDrink("frappe", Size.TALL);

            Beverage irishCoffee = shop.OrderDrink("irishCoffee", Size.TALL);
        }
    }
}
