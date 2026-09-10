using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            if ( temp > maxTemp)
            {
                this.maxTemp = temp;
            }
            if (temp < minTemp)
            {
                this.minTemp = temp;
            }

            this.sumTemperature += temp;

            this.countUpdated++;

            this.temperature = this.sumTemperature / this.countUpdated;
            Display();
        }

        public void Display()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            Console.WriteLine($"this is the avarage temperature: {temperature} - this is the maximum temperature: {maxTemp} - this is the minimum temperature: {minTemp}");
        }
    }
}
