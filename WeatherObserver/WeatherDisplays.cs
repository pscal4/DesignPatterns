 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    public abstract class WeatherDisplay : IObserver<WeatherData>
    {
        // From the MSDN Observer pattern doc
        protected IDisposable unsubscriber;
        protected IObservable<WeatherData> moWeatherDataProvider;

        public WeatherDisplay(IObservable<WeatherData> voWeatherProvider)
        {
            moWeatherDataProvider = voWeatherProvider;
            Subscribe(moWeatherDataProvider);
        }
        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public abstract void OnCompleted();
        public abstract void OnNext(WeatherData value);

        public virtual void OnError(Exception error)
        {
            // Do Nothing
        }

    }
    public class CurrentConditionsDisplay : WeatherDisplay, IDisplayElement
    {

        private float mnTemperature;
        private float mnHumidity;
        public CurrentConditionsDisplay(IObservable<WeatherData> voWeatherProvider)  : base(voWeatherProvider) {

        }

        public void Display()
        {
            Console.WriteLine(String.Format("Current conditions: {0}F degreees and {1}% humidity", mnTemperature, mnHumidity));
        }


        public override void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Current Conditions display.");
        }


        public override void OnNext(WeatherData oWeatherData)
        {
            mnTemperature = oWeatherData.Temperature;
            mnHumidity = oWeatherData.Humidity;
            Display();
        }
    }
    public class StatisticsDisplay : IDisplayElement, IObserver<WeatherData>
    {
        // From the MSDN Observer pattern doc
        private IDisposable unsubscriber;
        private IObservable<WeatherData> moWeatherDataProvider;

        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        public StatisticsDisplay(IObservable<WeatherData> voWeatherProvider)
        {
            moWeatherDataProvider = voWeatherProvider;
            Subscribe(moWeatherDataProvider);
        }

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
            Console.WriteLine("Statistics display is shutting down.");
        }


        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
            + "/" + maxTemp + "/" + minTemp);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Statistics Display.");
        }

        public void OnError(Exception error)
        {
            // Do nothing 
        }

        public void OnNext(WeatherData voWeatherData)
        {
            tempSum += voWeatherData.Temperature;
            numReadings++;

            if (voWeatherData.Temperature > maxTemp)
            {
                maxTemp = voWeatherData.Temperature;
            }

            if (voWeatherData.Temperature < minTemp)
            {
                minTemp = voWeatherData.Temperature;
            }

            Display();
        }
    }
    public class ForecastDisplay : IDisplayElement, IObserver<WeatherData>
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private IDisposable unsubscriber;
        private WeatherProvider moWeatherProvider;

        public ForecastDisplay(WeatherProvider voWeatherProvider)
        {
            moWeatherProvider = voWeatherProvider;
            Subscribe(moWeatherProvider);
        }
        public virtual void Subscribe(WeatherProvider provider)
        {
            unsubscriber = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }


        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Forecast Display.");
        }

        public void OnError(Exception error)
        {
            // Do Nothing
        }

        public void OnNext(WeatherData voWeatherData)
        {
            lastPressure = currentPressure;
            currentPressure = voWeatherData.Pressure;

            Display();
        }
    }
    public class HeatIndexDisplay : IDisplayElement, IObserver<WeatherData>
        {
            private IDisposable unsubscriber;
            private WeatherProvider moWeatherProvider;

            private float heatIndex = 0.0f;
            private WeatherData weatherData;

        public HeatIndexDisplay(WeatherProvider voWeatherProvider)
        {
            moWeatherProvider = voWeatherProvider;
            Subscribe(moWeatherProvider);
        }
        public virtual void Subscribe(WeatherProvider provider)
        {
            unsubscriber = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
            Console.WriteLine("Statistics display is shutting down.");
        }

        private float ComputeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Heat index is {0}", heatIndex));

        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Heat Index Display.");
        }

        public void OnError(Exception error)
        {
            // Do Nothing
        }

        public void OnNext(WeatherData voWeatherData)
        {
            heatIndex = ComputeHeatIndex(voWeatherData.Temperature,voWeatherData.Humidity);
            Display();
        }
        }
}
