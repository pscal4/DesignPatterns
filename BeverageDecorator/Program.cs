using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage myBeverage = new Espresso();
            Console.WriteLine( String.Format("{0} ${1}", myBeverage.Description, myBeverage.cost()));

            // Note:  The Factory Pattern and the Builder Pattern provide better ways of creating decorated objects
            Beverage myDecoratedBeverage = new DarkRoast();
            myDecoratedBeverage = new Mocha(myDecoratedBeverage);
            myDecoratedBeverage = new Mocha(myDecoratedBeverage);
            myDecoratedBeverage = new Whip(myDecoratedBeverage);
            Console.WriteLine(String.Format("{0} ${1}", myDecoratedBeverage.Description, myDecoratedBeverage.cost()));

            Beverage myLastBeverage = new HouseBlend();
            myLastBeverage = new Soy(myLastBeverage);
            myLastBeverage = new Mocha(myLastBeverage);
            myLastBeverage = new Whip(myLastBeverage);
            Console.WriteLine(String.Format("{0} ${1}", myLastBeverage.Description, myLastBeverage.cost()));

            Console.ReadLine();
        }
    }
}
