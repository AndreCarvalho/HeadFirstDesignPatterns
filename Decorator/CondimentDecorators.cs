namespace Decorator
{
    /// <summary>
    /// CondimentDecorator is a base decorator for Beverage components. Each class that extends it can choose how
    /// to implement the decorated component functionality
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        private readonly Beverage beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        protected Beverage Beverage
        {
            get { return beverage; }
        }
    }

    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override string Description
        {
            get { return Beverage.Description + " Mocha"; }
        }

        public override double Cost
        {
            get { return Beverage.Cost + 1.15; }
        }
    }

    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override string Description
        {
            get { return Beverage.Description + " with Milk"; }
        }

        public override double Cost
        {
            get { return Beverage.Cost + 0.5; }
        }
    }
}