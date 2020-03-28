using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var val = slider.Value; 
            var f = (val * 1.8) + 32;
            var k = val + 273.15;
            fahrenheitTextBox.Text = f.ToString();
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var val = slider.Value;
            var c = (val - 32) / 1.8;
            var k = c + 273.15;
            celsiusTextBox.Text = c.ToString();
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {

        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var val = slider.Value;
        }
    }
}
