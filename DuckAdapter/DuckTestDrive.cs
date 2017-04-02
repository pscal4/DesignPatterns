using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    class DuckTestDrive
    {
        public static void main(String[] args)
        {
            var oDuck = new MallardDuck();

            var oTurkey = new WildTurkey();
            IDuck oTurkeyAdapter = new TurkeyAdapter(oTurkey);

            Console.WriteLine("The turkey says");
            oTurkey.Gobble();
            oTurkey.Fly();

            Console.WriteLine("\nThe Duck says");
            TestDuck(oDuck);

            Console.WriteLine("\nThe TurkeyAdapter says");
            TestDuck(oTurkeyAdapter);
        }
        public static void TestDuck(IDuck voDuck) {
            voDuck.Quack();
            voDuck.Fly();
        }
    }
}
