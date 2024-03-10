using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron2
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly ISubject _weatherData;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }
        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
