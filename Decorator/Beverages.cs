﻿namespace Decorator
{
    /// <summary>
    /// Beverage acts as the Component base class (could be an interface)
    /// </summary>
    public abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract double Cost { get; }
    }

    class Decaf : Beverage
    {
        public override string Description
        {
            get { return "Decaf"; }
        }

        public override double Cost
        {
            get { return 2.5; }
        }
    }

    class Espresso : Beverage
    {
        public override string Description
        {
            get { return "Espresso"; }
        }

        public override double Cost
        {
            get { return 3.5; }
        }
    }

    class DarkRoast : Beverage
    {
        public override string Description
        {
            get { return "Dark Roast"; }
        }

        public override double Cost
        {
            get { return 3.0; }
        }
    }

    class HouseBlend : Beverage
    {
        public override string Description
        {
            get { return "House Blend"; }
        }

        public override double Cost
        {
            get { return 2.5; }
        }
    }
}