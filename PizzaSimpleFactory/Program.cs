using System;

namespace PizzaSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory oFactory = new SimplePizzaFactory();
            PizzaStore oStore = new PizzaStore(oFactory);
            oStore.OrderPizza("cheese");
            oStore.OrderPizza("pepperoni");

            Console.ReadLine();
        }
    }
}
