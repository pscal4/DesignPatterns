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
            var oWeatherData = new WeatherData();
            var oCurrentConditionsDisplay = new CurrentConditionsDisplay(oWeatherData);
            var oStatisticsDisplay = new StatisticsDisplay(oWeatherData);
            var oForecastDisplay = new ForecastDisplay(oWeatherData);
            var oHeatIndexDisplay = new HeatIndexDisplay(oWeatherData);

            oWeatherData.SetMeasurements(80, 65, 30.4f);
            oWeatherData.SetMeasurements(82, 70, 29.2f);
            oWeatherData.SetMeasurements(78, 65, 29.2f);
            Console.ReadLine();
        }
    }
}
