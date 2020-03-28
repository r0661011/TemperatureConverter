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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(textBox.Text);
            var cels = (val - 32) / 1.8;
            var celsius = cels.ToString();
            textBox.Text = celsius;
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(textBox2.Text);
            var far = (val * 1.8) + 32;
            var fahrenheit = far.ToString();
            textBox.Text = fahrenheit;
        }
    }
}
