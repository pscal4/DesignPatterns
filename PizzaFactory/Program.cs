using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore myStore = new NYPizzaStore();
            myStore.OrderPizza("cheese");

            Console.WriteLine("");
            Console.WriteLine("==== NEW ORDER ====");
            Console.WriteLine("");

            PizzaStore myChicagoStore = new ChicagoPizzaStore();
            myChicagoStore.OrderPizza("clam");

            Console.ReadLine();
        }
    }
}
