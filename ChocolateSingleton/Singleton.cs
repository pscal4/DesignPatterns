using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateSingleton
{
    public class Singleton
    {
        private static Singleton moUniqueInstance;
        private Singleton()  { }
        public static Singleton GetInstance(){
            if (moUniqueInstance == null)
            {
                moUniqueInstance = new Singleton();
            }
            return moUniqueInstance;
        }
    }
}
