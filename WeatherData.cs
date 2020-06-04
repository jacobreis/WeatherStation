using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    // Subject
    class WeatherData : ISubject
    {
        // Class variables
        private List<IObserver> displays;
        private float temperature;
        private float humidity;
        private float pressure;


        // Gets and sets
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }

        // Public constructor
        public WeatherData()
        {
            displays = new List<IObserver>();
        }

        // Methods start here
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer");
            displays.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer");
            this.displays.Remove(observer);
        }

        // Notifies the Observers of any changes to the WeatherData
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            displays.ForEach(o => { o.Update(temperature, humidity, pressure); });
        }

        public void measurementsChanged()
        {
            Notify();
        }

    }
}
