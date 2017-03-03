using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStrategy
{
    public abstract class Duck
    {
        protected IFly flyBehavior;
        protected IQuack quackBehavior;
        public Duck()
        {
        }
        public abstract void display();
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack() {
            quackBehavior.quack();
        }
        public void swim()
        {
            Console.WriteLine("All ducks float even decoys!");
        }
    }
}
