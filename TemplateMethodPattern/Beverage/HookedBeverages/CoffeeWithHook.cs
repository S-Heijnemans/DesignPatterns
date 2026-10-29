namespace TemplateMethodPattern
{
    internal class ChocolateMilkWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Adding chocolate milk powder to hot water");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipcream");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like Whipcream with your chocolate milk (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
