using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    public class Mocha : CondimentDecorator
    {
        private Beverage moBeverage;
        public Mocha(Beverage voBeverage)
        {
            moBeverage = voBeverage;
        }
        protected override string GetDescription()
        {
            return moBeverage.Description + ", Mocha";
        }
        public override double cost()
        {
            return moBeverage.cost() + .20d;
        }
    }
    public class SteamedMilk : CondimentDecorator
    {
        private Beverage moBeverage;
        public SteamedMilk(Beverage voBeverage)
        {
            moBeverage = voBeverage;
        }
        protected override string GetDescription()
        {
            return moBeverage.Description + ", Steamed Milk";
        }
        public override double cost()
        {
            return moBeverage.cost() + .10d;
        }
    }
    public class Soy : CondimentDecorator
    {
        private Beverage moBeverage;
        public Soy(Beverage voBeverage)
        {
            moBeverage = voBeverage;
        }
        protected override string GetDescription()
        {
            return moBeverage.Description + ", Soy";
        }
        public override double cost()
        {
            return moBeverage.cost() + .15d;
        }
    }
    public class Whip : CondimentDecorator
    {
        private Beverage moBeverage;
        public Whip(Beverage voBeverage)
        {
            moBeverage = voBeverage;
        }
        protected override string GetDescription()
        {
            return moBeverage.Description + ", Whip";
        }
        public override double cost()
        {
            return moBeverage.cost() + .10d;
        }
    }
}
