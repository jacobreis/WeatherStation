using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class ForecastDisplay : IObserver, DisplayElement
    {
        // Class variables
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        // Public constructor
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }

        // Methods start here
        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if(currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if(currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same.");
            }
            else if(currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather.");
            }
        }
    }
}
