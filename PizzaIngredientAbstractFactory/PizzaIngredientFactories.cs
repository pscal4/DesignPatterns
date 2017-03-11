using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredientAbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        //IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClam CreateClam();
    }

    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {

        public IDough CreateDough()
        {
            IDough oDough = new ThinCrustDough();
            Console.WriteLine(String.Format("Tossing {0}", oDough.Name));
            return oDough;
            //return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        //public IVeggies[] CreateVeggies()
        //{
        //    IVeggies[] oVeggies;// need to initialize here Garlic, Onion, Mushroom, RedPepper
        //    return oVeggies;
        //}

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClam CreateClam()
        {
            return new FreshClams();
        }
    }
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {

        public IDough CreateDough()
        {
            IDough oDough = new ThickCrustDough();
            Console.WriteLine(String.Format("Tossing {0}", oDough.Name));
            return oDough;
            //return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        //public IVeggies[] CreateVeggies()
        //{
        //    IVeggies[] oVeggies;// need to initialize here Spinach, Eggplant, BlackOlive
        //    return oVeggies;
        //}

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClam CreateClam()
        {
            return new FrozenClams();
        }
    }
}
