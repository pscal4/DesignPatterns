using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public abstract class PizzaStore
    {

        public abstract Pizza CreatePizza(string vsType);
        public Pizza OrderPizza(string vsType) {
            Pizza oPizza;
            oPizza = CreatePizza(vsType);
            oPizza.Prepare();
            oPizza.Bake();
            oPizza.Cut();
            oPizza.Box();
            return oPizza;

        }
    }
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string vsType)
        {
            Pizza oPizza = null;
            if (vsType == "cheese")
            {
                oPizza = new NYStyleCheesePizza();
            }
            else if (vsType == "pepperoni")
            {
                oPizza = new NYStylePepperoniPizza();
            }
            else if (vsType == "clam")
            {
                oPizza = new NYStyleClamPizza();
            }
            else if (vsType == "veggie")
            {
                oPizza = new NYStyleVeggiePizza();
            }
            else
            {
                // Should throw an exception
            }
            return oPizza;

        }
    }
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string vsType)
        {
            Pizza oPizza = null;
            if (vsType == "cheese")
            {
                oPizza = new ChicagoStyleCheesePizza();
            }
            else if (vsType == "pepperoni")
            {
                oPizza = new ChicagoStylePepperoniPizza();
            }
            else if (vsType == "clam")
            {
                oPizza = new ChicagoStyleClamPizza();
            }
            else if (vsType == "veggie")
            {
                oPizza = new ChicagoStyleVeggiePizza();
            }
            else
            {
                // Should throw an exception
            }
            return oPizza;

        }
    }
  
}
