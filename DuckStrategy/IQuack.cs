using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckStrategy
{
    public interface IQuack
    {
        void quack();
    }
    public class Quack : IQuack
    {

        public void quack()
        {
            Console.WriteLine("Quack");
        }

    }

    public class MuteQuack : IQuack
    {
        public void quack()
        {
            Console.WriteLine("<<Sileance>>");
        }
    }
    public class Squeak : IQuack
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
