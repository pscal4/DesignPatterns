using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{
    class PizzaStore
    {
        private SimplePizzaFactory moFactory;
        public PizzaStore(SimplePizzaFactory voFactory)
        {
            moFactory = voFactory;
        }
        public Pizza OrderPizza(string vsType)
        {
            Pizza oPizza;
            oPizza = moFactory.CreatePizza(vsType);
            oPizza.Prepare();
            oPizza.Bake();
            oPizza.Cut();
            oPizza.Box();
            return oPizza;
        }
    }
}
