using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class CurrentConditionDisplay : IObserver, DisplayElement
    {
        // Class variables
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        // Public constructor
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }

        // Methods start here
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
            
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degreed and " + humidity + "% humidity");
        }
    }

    


}
