using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var oWeatherProvider = new WeatherProvider(new WeatherData(80, 65, 30.4f));
            var oCurrentConditionsDisplay = new CurrentConditionsDisplay(oWeatherProvider);
            var oStatisticsDisplay = new StatisticsDisplay(oWeatherProvider);
            var oForecastDisplay = new ForecastDisplay(oWeatherProvider);
            var oHeatIndexDisplay = new HeatIndexDisplay(oWeatherProvider);

            //oWeatherProvider.UpdateWeather(new WeatherData(80, 65, 30.4f));
            oWeatherProvider.UpdateWeather(new WeatherData(82, 70, 29.2f));

            oWeatherProvider.UpdateWeather(new WeatherData(78, 65, 29.2f));
            // Unsubscribing Statistics here
            oStatisticsDisplay.Unsubscribe();
            oWeatherProvider.UpdateWeather(new WeatherData(68, 87, 49.2f));
            oWeatherProvider.UpdateWeather(new WeatherData(68, 87, 49.2f)); // This is no change so observers should not be notified

            oWeatherProvider.UpdateWeather(new WeatherData(68, 87, 70.6877f));
            oWeatherProvider.ShutDown();

            Console.ReadLine();
        }
    }
}
