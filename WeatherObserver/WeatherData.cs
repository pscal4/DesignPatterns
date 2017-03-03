using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    class WeatherData : ISubject
    {
        private List<IWeatherObserver> moObservers;
        private float mnTemperature;
        private float mnHumidity;
        private float mnPressure;
        public WeatherData()
        {
            moObservers = new List<IWeatherObserver>();
        }


        public void RegisterObserver(IWeatherObserver observer)
        {
            moObservers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            moObservers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var oObserver in moObservers)
            {
                oObserver.Update(mnTemperature, mnHumidity, mnPressure);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            mnTemperature = temperature;
            mnHumidity = humidity;
            mnPressure = pressure;
            MeasurementsChanged();
        }
    }
}
