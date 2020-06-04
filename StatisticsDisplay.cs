using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class StatisticsDisplay : IObserver, DisplayElement
    {
        // Class variables
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        // Public constructor
        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }

        // Methods start here
        public void Update(float temperature, float humidity, float pressure)
        {
            float temp = temperature;
            tempSum += temp;
            numReadings++;

            if(temp > maxTemp)
            {
                maxTemp = temp;
            }
            if(temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings) + "/" + maxTemp + "/" + minTemp);
        }
    }
}
