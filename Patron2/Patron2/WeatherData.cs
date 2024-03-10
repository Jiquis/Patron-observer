using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron2
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
    }
}
