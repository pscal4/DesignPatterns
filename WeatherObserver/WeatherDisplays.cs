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

        public abstract void OnNext(WeatherData voWeatherData);

        // Default implementations for IObserver<WeatherData>
        public virtual void OnCompleted()
        {
            // Do Nothing
        }
        public virtual void OnError(Exception error)
        {
            // Do Nothing
        }

    }
    public class CurrentConditionsDisplay : WeatherDisplay, IDisplayElement
    {
        private float mnTemperature;
        private float mnHumidity;

        public CurrentConditionsDisplay(IObservable<WeatherData> voWeatherProvider)
            : base(voWeatherProvider)
        {

        }

        public void Display()
        {
            Console.WriteLine(String.Format("Current conditions: {0}F degreees and {1}% humidity", mnTemperature, mnHumidity));
        }

        // This will take the default implementation (do nothing)
        //public override void OnCompleted()
        //{
        //    Console.WriteLine("Additional weather data will not be transmitted to the Current Conditions display.");
        //}


        public override void OnNext(WeatherData oWeatherData)
        {
            mnTemperature = oWeatherData.Temperature;
            mnHumidity = oWeatherData.Humidity;
            Display();
        }
    }
    public class StatisticsDisplay : WeatherDisplay, IDisplayElement
    {

        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        public StatisticsDisplay(IObservable<WeatherData> voWeatherProvider)
            : base(voWeatherProvider)
        {

        }


        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
            + "/" + maxTemp + "/" + minTemp);
        }

        public override void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Statistics Display.");
        }

        public override void OnNext(WeatherData voWeatherData)
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
    public class ForecastDisplay : WeatherDisplay, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForecastDisplay(IObservable<WeatherData> voWeatherProvider)
            : base(voWeatherProvider)
        {
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

        public override void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Forecast Display.");
        }


        public override void OnNext(WeatherData voWeatherData)
        {
            lastPressure = currentPressure;
            currentPressure = voWeatherData.Pressure;

            Display();
        }
    }
    public class HeatIndexDisplay : WeatherDisplay, IDisplayElement
    {
        private float heatIndex = 0.0f;
        public HeatIndexDisplay(IObservable<WeatherData> voWeatherProvider)
            : base(voWeatherProvider) {}

        public void Display()
        {
            Console.WriteLine(String.Format("Heat index is {0}", heatIndex));

        }

        public override void OnCompleted()
        {
            Console.WriteLine("Additional weather data will not be transmitted to the Heat Index Display.");
        }


        public override void OnNext(WeatherData voWeatherData)
        {
            heatIndex = ComputeHeatIndex(voWeatherData.Temperature, voWeatherData.Humidity);
            Display();
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
    }
}
