using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateSingleton
{
    class ChocolateBoiler
    {
        private bool mbEmpty;
        private bool mbBoiled;
        private static ChocolateBoiler moChocolateBoilerSingleton;
        // This is eager creation
        //private static ChocolateBoiler moChocolateBoilerSingleton = new ChocolateBoiler();

        // From MSDN
        // The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time. 
        // Fields that are declared volatile are not subject to compiler optimizations that assume access by a single thread. 
        // This ensures that the most up-to-date value is present in the field at all times.
        // The volatile modifier is usually used for a field that is accessed by multiple threads without using the lock statement 
        //  to serialize access.
        //private volatile static ChocolateBoiler moChocolateBoilerSingleton;

        // This attribute makes the method synchronized - every thread is forced to 
        // wait its turn before it can enter the method
        //[MethodImpl(MethodImplOptions.Synchronized)]
        public static ChocolateBoiler GetInstance()
        {
            if (moChocolateBoilerSingleton == null)
            {
                // The lock keyword marks a statement block as a critical section by obtaining the mutual-exclusion 
                // lock for a given object, executing a statement, and then releasing the lock. 
                lock (moChocolateBoilerSingleton);
                moChocolateBoilerSingleton = new ChocolateBoiler();
            }
            return moChocolateBoilerSingleton;
        }

        private ChocolateBoiler()
        {
            mbEmpty = true;
            mbBoiled = false;
        }
        public void Fill()
        {
            if (IsEmpty())
            {
                mbEmpty = false;
                mbBoiled = false;
                // Fill the boiler with milk/chocolate mixture
            }
        }
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // drain the boiled milk and chocolate
                mbEmpty = true;
            }
        }
        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // bring the contents to a boil
                mbBoiled = true;
            }
        }

        private bool IsBoiled()
        {
            return mbBoiled;
        }

        private bool IsEmpty()
        {
            return mbEmpty;
        }
    }
}
