using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron2
{
    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }
}
