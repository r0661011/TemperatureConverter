using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Cells;
using System.Collections.Generic;
using System.Diagnostics;

namespace ViewModel
{
    public class ConverterViewModel
    {
        public Cell<double> temperatureInKelvin;

        public ConverterViewModel()
        {
            this.Kelvin = new TemperatureScaleViewModel(this, new KelvinTemperatureScale());
            this.Fahrenheit = new TemperatureScaleViewModel(this, new FahrenheitTemperatureScale());
            this.Celsius = new TemperatureScaleViewModel(this, new CelsiusTemperatureScale());
            temperatureInKelvin = new Cell<double>();
        }
        public Cell<double> TemperatureInKelvin
        {
            get
            {
                return temperatureInKelvin;
            }

            set
            {
                temperatureInKelvin = value;
                temperatureInKelvin.PropertyChanged += (sender, args) => Debug.WriteLine("x has changed!");
            }
        }

        public TemperatureScaleViewModel Kelvin { get; }
        public TemperatureScaleViewModel Fahrenheit { get; }
        public TemperatureScaleViewModel Celsius { get; }

        public IEnumerable<TemperatureScaleViewModel> Scales
        {
            get
            {
                yield return Celsius;
                yield return Fahrenheit;
                yield return Kelvin;
            }
        }
    }

    public class TemperatureScaleViewModel
    {
        private readonly ConverterViewModel parent;

        private readonly ITemperatureScale temperatureScale;

        public TemperatureScaleViewModel(ConverterViewModel parent, ITemperatureScale temperatureScale)
        {
            this.parent = parent;
            this.temperatureScale = temperatureScale;

            this.Temperature = this.parent.TemperatureInKelvin.Derive(kelvin => temperatureScale.ConvertFromKelvin(kelvin));
        }

        public string Name => temperatureScale.Name;

        public Cell<double> Temperature { get; }
    }
}
