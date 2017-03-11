using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string vsType)
        {
            Pizza oPizza = null;
            if (vsType == "cheese")
            {
                oPizza = new CheesePizza();
            }
            else if (vsType == "pepperoni")
            {
                oPizza = new PepperoniPizza();
            }
            else if (vsType == "clam")
            {
                oPizza = new ClamPizza();
            }
            else if (vsType == "veggie")
            {
                oPizza = new VeggiePizza();
            }
            else
            {
                // Should throw an exception
            }
            return oPizza;
        }
    }
}
