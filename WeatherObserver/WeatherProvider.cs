using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    public class WeatherProvider : IObservable<WeatherData> 
    {
        private List<IObserver<WeatherData>> observers;
        private WeatherData moCurrentWeatherData;

        public WeatherProvider(WeatherData oWeatherData)
        {
            observers = new List<IObserver<WeatherData>>();
            moCurrentWeatherData = oWeatherData;
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                observer.OnNext(moCurrentWeatherData);
            }
            return new Unsubscriber<WeatherData>(observers, observer);
        }
        public void UpdateWeather(WeatherData oWeatherData) {
            // Only notify if something has changed
            if (Changed(oWeatherData))
            {
                moCurrentWeatherData = oWeatherData;

                foreach (var observer in observers)
                {
                    observer.OnNext(moCurrentWeatherData);
                }
                // This isn't right - just for readability
                Console.WriteLine("====");
                Console.WriteLine("");                
            }
        }
        public bool Changed(WeatherData oNewWeatherData)
        {
            if (oNewWeatherData.Humidity == moCurrentWeatherData.Humidity &&
                oNewWeatherData.Pressure == moCurrentWeatherData.Pressure &&
                oNewWeatherData.Temperature == moCurrentWeatherData.Temperature)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void ShutDown()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }

        }
    }
    internal class Unsubscriber<WeatherData> : IDisposable
    {
        private List<IObserver<WeatherData>> _observers;
        private IObserver<WeatherData> _observer;

        internal Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
