using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    public interface ISubject
    {
        void RegisterObserver( IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }
}
