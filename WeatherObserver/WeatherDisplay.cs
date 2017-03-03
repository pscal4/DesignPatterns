using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    class CurrentConditionsDisplay : IWeatherObserver, IDisplayElement
    {
        private float mnTemperature;
        private float mnHumidity;
        private ISubject moWeatherData;

        public CurrentConditionsDisplay(ISubject weatherData) 
        {
            moWeatherData = weatherData;
            moWeatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            mnTemperature = temp;
            mnHumidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Current conditions: {0}F degreees and {1}% humidity", mnTemperature, mnHumidity));
        }

     }
    class StatisticsDisplay : IWeatherObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private ISubject weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
    		Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
			+ "/" + maxTemp + "/" + minTemp);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }
    }
    class ForecastDisplay : IWeatherObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }


        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
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
    }
    class HeatIndexDisplay : IWeatherObserver, IDisplayElement
    {
        private float heatIndex = 0.0f;
        private WeatherData weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }


        public void Update(float temp, float humidity, float pressure)
        {
            heatIndex = ComputeHeatIndex(temp, humidity);

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

        public void Display()
        {
            Console.WriteLine(String.Format("Heat index is {0}",heatIndex));
            
        }
    }
}
