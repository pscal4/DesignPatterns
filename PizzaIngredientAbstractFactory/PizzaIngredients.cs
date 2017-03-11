using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredientAbstractFactory
{
    public interface IDough
    {
        string Name{ get; }
    }
    public class ThickCrustDough : IDough
    {
        public string Name { get; private set; }
        public ThickCrustDough()
        {
            Name = "Thick Crust Dough";
        }
    }
    public class ThinCrustDough : IDough
    {
        public string Name { get; private set; }
        public ThinCrustDough()
        {
            Name = "Thin Crust Dough";
        }
    }
    public interface ISauce
    {
        string Name { get; }
    }
    public class PlumTomatoSauce : ISauce
    {
        public string Name { get; private set; }
        public PlumTomatoSauce()
        {
            Name = "Plum Tomato Sauce";
        }
    }
    public class MarinaraSauce : ISauce
    {
        public string Name { get; private set; }
        public MarinaraSauce()
        {
            Name = "Marinara Sauce";
        }
    }
    public interface ICheese
    {
        string Name { get;  }
    }
    public class MozzarellaCheese : ICheese
    {
        public string Name { get; private set; }
        public MozzarellaCheese()
        {
            Name = "Mozzarella";
        }
    }
    public class ReggianoCheese : ICheese
    {
        public string Name { get; private set; }
        public ReggianoCheese()
        {
            Name = "Reggiano Cheese";
        }
    }
    public interface IClam
    {
        string Name { get;  }
    }
    public class FreshClams : IClam
    {
        public string Name { get; private set; }
        public FreshClams()
        {
            Name = "Fresh Clams";
        }
    }
    public class FrozenClams : IClam
    {
        public string Name { get; private set; }
        public FrozenClams()
        {
            Name = "Frozen Clams";
        }
    }
    public interface IPepperoni
    {
        string Name { get; }
    }
    public class SlicedPepperoni : IPepperoni
    {
        public string Name { get; private set; }
        public SlicedPepperoni()
        {
            Name = "Sliced Pepperoni";
        }
    }
}
