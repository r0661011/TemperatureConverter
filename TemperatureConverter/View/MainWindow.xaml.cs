using System;
using System.Collections.Generic;
using System.Globalization;
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
    }

    public class TemparatureConverter : ITemperatureScale
    {
        public string Name => throw new NotImplementedException();

        public double ConvertFromKelvin(double temperature)
        {
            throw new NotImplementedException();
        }

        public double ConvertToKelvin(double temperature)
        {
            throw new NotImplementedException();
        }
    }
}
