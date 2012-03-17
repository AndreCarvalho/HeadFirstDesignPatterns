using System;

namespace Strategy
{
    public interface IQuackBehavior
    {
        void DoQuack();
    }

    #region Implementations

    public class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Silence...");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak squeak");
        }
    }

    public class Quack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack quack");
        }
    }

    #endregion

}