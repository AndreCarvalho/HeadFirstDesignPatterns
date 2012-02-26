using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var caffeLatte = new Milk(new HouseBlend());
            DescribeBeverage(caffeLatte);
            var espressoMocha = new Mocha(new Espresso());
            DescribeBeverage(espressoMocha);
            Console.ReadKey();
        }

        private static void DescribeBeverage(Beverage caffeLatte)
        {
            Console.WriteLine("Beverage: {0}, Cost: {1}", caffeLatte.Description, caffeLatte.Cost);
        }
    }
}
