using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    public class WeatherData 
    {
        private float mnTemperature;
        private float mnHumidity;
        private float mnPressure;

        public float Temperature
        {
            get { return mnTemperature; }
        }
        public float Humidity
        {
            get { return mnHumidity; }
        }
        public float Pressure
        {
            get { return mnPressure; }
        }

        public WeatherData(float nTemperature, float nHumidity, float nPressure)
        {
            SetMeasurements(nTemperature, nHumidity, nPressure);

        }


        //public void RegisterObserver(IWeatherObserver observer)
        //{
        //    moObservers.Add(observer);
        //}

        //public void RemoveObserver(IWeatherObserver observer)
        //{
        //    moObservers.Remove(observer);
        //}

        //public void NotifyObservers()
        //{
        //    foreach (var oObserver in moObservers)
        //    {
        //        oObserver.Update(mnTemperature, mnHumidity, mnPressure);
        //    }
        //}
        //public void MeasurementsChanged()
        //{
        //    NotifyObservers();
        //}
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            mnTemperature = temperature;
            mnHumidity = humidity;
            mnPressure = pressure;
            //MeasurementsChanged();
        }
    }
}
