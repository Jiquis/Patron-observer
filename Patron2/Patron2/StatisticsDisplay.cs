using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron2
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _maxTemp;
        private double _minTemp = 200;
        private double _tempSum;
        private int _numReadings;
        private readonly ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings)
            + "/" + _maxTemp + "/" + _minTemp);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _tempSum += temp;
            _numReadings++;

            if (temp > _maxTemp)
            {
                _maxTemp = temp;
            }

            if (temp < _minTemp)
            {
                _minTemp = temp;
            }

            Display();
        }
    }
}
