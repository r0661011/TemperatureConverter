using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.TemperatureScale;

namespace View
{
    class TemperatureScale
    {
        public interface ITemperatureScale
        {
            string Name { get; }

            double ConvertToKelvin(double temperature);
            double ConvertFromKelvin(double temperature);
        }
    }

    class KelvinTemperatureScale : TemperatureScale.ITemperatureScale
    {
        public string Name { get; }

        public double ConvertFromKelvin(double temperature)
        {
            return temperature;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature;
        }
    }

    class CelsiusTemperatureScale : ITemperatureScale
    {
        public string Name { get; }

        public double ConvertFromKelvin(double temperature)
        {
            return temperature - 273.15;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature + 273.15;
        }
    }
}
