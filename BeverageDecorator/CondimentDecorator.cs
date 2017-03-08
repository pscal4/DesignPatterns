using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    public abstract class CondimentDecorator : Beverage
    {
        // Making it abstract here forces 
        protected abstract override string GetDescription();

    }
}
