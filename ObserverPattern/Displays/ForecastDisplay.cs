using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity
            if (humidity > 30 && temperature > 20) {
                Console.WriteLine("Mooi weer komt er aan");
            } else
            {
                Console.WriteLine("Trek je paraplu’s uit de kast");
            }

        }
    }
}
