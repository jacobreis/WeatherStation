// Written by Jake Reis

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new weather station object
            WeatherData weatherData = new WeatherData();

            // Create new displays and attach them to the new station in the constructor
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            // Update the weather
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);

            // Detach ForecastDisplay
            weatherData.Detach(forecastDisplay);

            // Update should now exclude the forecast text
            weatherData.SetMeasurements(78, 90, 29.2f);


            Console.Read();
        }
    }
}
