using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    // Book did not have this abstract class
    public abstract class ChicagoStylePizza : Pizza
    {
        public ChicagoStylePizza()
        {
            Name = "Chicago Style Sauce and Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
        }
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    public class ChicagoStyleCheesePizza : ChicagoStylePizza
    {
    }
    public class ChicagoStylePepperoniPizza : ChicagoStylePizza
    {
        public ChicagoStylePepperoniPizza() : base()
        {
            Toppings.Add("pepperoni");
        }
    }
    public class ChicagoStyleClamPizza : ChicagoStylePizza
    {
        public ChicagoStyleClamPizza()
            : base()
        {
            Toppings.Add("clams");
        }
    }
    public class ChicagoStyleVeggiePizza : ChicagoStylePizza
    {
        public ChicagoStyleVeggiePizza()
            : base()
        {
            Toppings.Add("veggies");
        }
    }

}
