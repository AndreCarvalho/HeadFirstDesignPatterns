using System;

namespace Strategy
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    #region Implementations

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly ;(");
        }
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flyiiiiing :)");
        }
    }

    #endregion

}