using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalDuck = new Duck(new FlyWithWings(), new Quack());
            normalDuck.PerformFly();
            normalDuck.PerformQuack();

            var rubberDuck = new Duck(new FlyNoWay(), new Squeak());
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            Console.ReadKey();
        }
    }
}
