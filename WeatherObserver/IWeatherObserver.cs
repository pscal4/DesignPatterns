using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    // Named this IWeahterObserver to avoid conflict with systen IObserver 
    public interface IWeatherObserver
    {
        void Update(float temp, float humidity, float pressure);

    }
}
