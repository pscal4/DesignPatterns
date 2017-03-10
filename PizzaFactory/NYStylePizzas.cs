using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    // Book did not have this abstract class
    public abstract class NYStylePizza : Pizza
    {
        public NYStylePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
       }

    }
    public class NYStyleCheesePizza : NYStylePizza
    {
    }
    public class NYStylePepperoniPizza : NYStylePizza
    {
        public NYStylePepperoniPizza() : base()
        {
            Toppings.Add("pepperoni");
        }
    }
    public class NYStyleClamPizza : NYStylePizza
    {
        public NYStyleClamPizza(): base()
        {
            Toppings.Add("clams");
        }
    }
    public class NYStyleVeggiePizza : NYStylePizza
    {
        public NYStyleVeggiePizza() : base()
        {
            Toppings.Add("veggies");
        }
    }

}
