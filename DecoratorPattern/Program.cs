using System.ComponentModel;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            Beverage doppio = new Espresso();
            doppio.Size = Size.VENDI;
            PrintBeverage(doppio);

            Beverage lungo = new Espresso();
            lungo.Size = Size.GRANDE;
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage americano = new Espresso();
            americano.Size = Size.TALL;
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage macchiato = new Espresso();
            macchiato.Size = Size.TALL;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new Espresso();
            corretta.Size = Size.VENDI;
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage conPanna = new Espresso();
            conPanna.Size = Size.GRANDE;
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            Beverage cappucinno = new Espresso();
            cappucinno.Size = Size.GRANDE;
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage(cappucinno);

            Beverage cafféLatte = new Espresso();
            cafféLatte.Size = Size.TALL;
            cafféLatte = new SteamedMilk(cafféLatte);
            cafféLatte = new SteamedMilk(cafféLatte);
            cafféLatte = new MilkFoam(cafféLatte);
            PrintBeverage(cafféLatte);

            Beverage flatWhite = new Espresso();
            flatWhite.Size = Size.TALL;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            Beverage romana = new Espresso();
            romana.Size = Size.TALL;
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new Espresso();
            morocchino.Size = Size.TALL;
            morocchino = new ChocolateCondoment(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new Espresso();
            mocha.Size = Size.TALL;
            mocha = new ChocolateCondoment(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Espresso();
            bicerin.Size = Size.TALL;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Espresso();
            breve.Size = Size.TALL;
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            Beverage rafcoffee = new Espresso();
            rafcoffee.Size = Size.TALL;
            rafcoffee = new VanillaSugar(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage(rafcoffee);

            Beverage meadraf = new Espresso();
            meadraf.Size = Size.TALL;
            meadraf = new Honey(meadraf);
            meadraf = new Cream(meadraf);
            PrintBeverage(meadraf);

            Beverage galao = new Espresso();
            galao.Size = Size.TALL;
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage cafféaffogato = new Espresso();
            cafféaffogato.Size = Size.TALL;
            cafféaffogato = new Espresso(cafféaffogato);
            cafféaffogato = new IceCream(cafféaffogato);
            PrintBeverage(cafféaffogato);

            Beverage viennacoffee = new Espresso();
            viennacoffee.Size = Size.TALL;
            viennacoffee = new Espresso(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            PrintBeverage(viennacoffee);

            Beverage glace = new Espresso();
            glace.Size = Size.TALL;
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolatemilk = new Chocolate();
            chocolatemilk.Size = Size.TALL;
            chocolatemilk = new Milk(chocolatemilk);
            chocolatemilk = new Milk(chocolatemilk);
            PrintBeverage(chocolatemilk);

            Beverage demicréme = new Espresso();
            demicréme.Size = Size.TALL;
            demicréme = new Espresso(demicréme);
            demicréme = new Cream(demicréme);
            demicréme = new Cream(demicréme);
            PrintBeverage(demicréme);

            Beverage lattemacchiato = new Espresso();
            lattemacchiato.Size = Size.TALL;
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new MilkFoam(lattemacchiato);
            PrintBeverage(lattemacchiato);

            Beverage freddo = new Espresso();
            freddo.Size = Size.TALL;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frappuccino = new Espresso();
            frappuccino.Size = Size.TALL;
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            Beverage caramelfrappuccino = new Espresso();
            caramelfrappuccino.Size = Size.TALL;
            caramelfrappuccino = new Ice(caramelfrappuccino);
            caramelfrappuccino = new SteamedMilk(caramelfrappuccino);
            caramelfrappuccino = new Cream(caramelfrappuccino);
            caramelfrappuccino = new Syrup(caramelfrappuccino);
            PrintBeverage(caramelfrappuccino);

            Beverage frappe = new Espresso();
            frappe.Size = Size.TALL;
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishCoffee = new Espresso();
            irishCoffee.Size = Size.TALL;
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}