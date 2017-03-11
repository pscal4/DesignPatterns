using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredientAbstractFactory
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
            IPizzaIngredientFactory oIngredientFactory = new NYPizzaIngredientFactory();
            if (vsType == "cheese")
            {
                oPizza = new CheesePizza(oIngredientFactory);
                oPizza.Name = "New York Style Cheese Pizza";
            }
            else if (vsType == "pepperoni")
            {
                oPizza = new PepperoniPizza(oIngredientFactory);
                oPizza.Name = "New York Style Pepperoni Pizza";
            }
            else if (vsType == "clam")
            {
                oPizza = new ClamPizza(oIngredientFactory);
                oPizza.Name = "New York Style Clam Pizza";
            }
            //else if (vsType == "veggie")
            //{
            //    oPizza = new VeggiePizza(oIngredientFactory);
            //    oPizza.Name = "New York Style Veggie Pizza";
            //}
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
            IPizzaIngredientFactory oIngredientFactory = new ChicagoPizzaIngredientFactory();
            if (vsType == "cheese")
            {
                oPizza = new CheesePizza(oIngredientFactory);
                oPizza.Name = "Chicago Style Cheese Pizza";
            }
            else if (vsType == "pepperoni")
            {
                oPizza = new PepperoniPizza(oIngredientFactory);
                oPizza.Name = "Chicago Style Pepperoni Pizza";
            }
            else if (vsType == "clam")
            {
                oPizza = new ClamPizza(oIngredientFactory);
                oPizza.Name = "Chicago Style Clam Pizza";
            }
            //else if (vsType == "veggie")
            //{
            //    oPizza = new VeggiePizza(oIngredientFactory);
            //    oPizza.Name = "Chicago Style Veggie Pizza";
            //}
            else
            {
                // Should throw an exception
            }
            return oPizza;

        }
    }
  
}
