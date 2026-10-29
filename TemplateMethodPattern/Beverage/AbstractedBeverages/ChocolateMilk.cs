namespace TemplateMethodPattern
{
    public class ChocolateMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("adding choco milk powder to hot water");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipcream");
        }
    }
}
