using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    public class DuckAdapter : ITurkey {
        private IDuck moDuck;
        private Random moRandom;
        public DuckAdapter(IDuck voDuck)
        {
            moDuck = voDuck;
            moRandom = new Random();
        }
        void Gobble()
        {
            moDuck.Quack();
        }
        void Fly()
        {
            if (moRandom.Next(1, 5) == 1)
            {
                moDuck.Fly();
            }

        }
    }
}
