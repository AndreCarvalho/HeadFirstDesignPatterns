namespace Strategy
{
    public class Duck
    {
        private readonly IFlyBehavior flyBehavior;
        private readonly IQuackBehavior quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }

        public void PerformQuack()
        {
            this.quackBehavior.DoQuack();
        }

        public void PerformFly()
        {
            this.flyBehavior.Fly();
        }
    }
}