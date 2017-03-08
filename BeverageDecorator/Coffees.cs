using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    public class Espresso : Beverage 
    {
        public Espresso()
        {
            Description = "Expresso";
        }
        public override double cost()
        {
            return 1.99d;
        }
    }
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public override double cost()
        {
            return .89d;
        }
    }
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }
        public override double cost()
        {
            return .99;
        }
    }
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double cost()
        {
            return 1.05d;
        }
    }
}
