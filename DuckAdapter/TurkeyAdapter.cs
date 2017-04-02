using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    class TurkeyAdapter : IDuck
    {
        ITurkey moTurkey;
        public TurkeyAdapter( ITurkey voTurkey)
        {
            moTurkey = voTurkey;           
        }
        public void Quack()
        {
            moTurkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                moTurkey.Fly();                
            }
        }
    }
}
