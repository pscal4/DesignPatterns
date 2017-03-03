using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStrategy
{
    public interface IFly
    {
        void fly();
    }
    public class FlyWithWings : IFly
    {

        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : IFly
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
