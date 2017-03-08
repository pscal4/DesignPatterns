using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    // This really should be an interface but in the example it was a refactor of an existing abstract class
    public abstract class Beverage
    {
        private string moDescription = "Unknown Beverage";

        public string Description
        {
            get { return GetDescription(); }
            protected set { moDescription = value; }
        }
        

        protected virtual string GetDescription()
        {
            return moDescription;  
        }        
        public abstract double cost();
    }
}
