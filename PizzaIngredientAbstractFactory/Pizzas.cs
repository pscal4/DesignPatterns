using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredientAbstractFactory
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory moIngredientFactory;
        public CheesePizza(IPizzaIngredientFactory voIngredientFactory)
        {
            moIngredientFactory = voIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine(String.Format("Preparing {0}", Name));
            Dough = moIngredientFactory.CreateDough();
            Sauce = moIngredientFactory.CreateSauce();
            Cheese = moIngredientFactory.CreateCheese();
        }
    }
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory moIngredientFactory;
        public ClamPizza(IPizzaIngredientFactory voIngredientFactory)
        {
            moIngredientFactory = voIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine(String.Format("Preparing {0}", Name));
            Dough = moIngredientFactory.CreateDough();
            Sauce = moIngredientFactory.CreateSauce();
            Cheese = moIngredientFactory.CreateCheese();
            Clam = moIngredientFactory.CreateClam();
        }
    }
    public class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory moIngredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory voIngredientFactory)
        {
            moIngredientFactory = voIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine(String.Format("Preparing {0}", Name));
            Dough = moIngredientFactory.CreateDough();
            Sauce = moIngredientFactory.CreateSauce();
            Cheese = moIngredientFactory.CreateCheese();
            Pepperoni = moIngredientFactory.CreatePepperoni();
        }
    }
}
