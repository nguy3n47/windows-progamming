using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Phone
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
        MyPhone _p;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _p = new MyPhone()
            {
                Name = "Iphone 11 Pro",
                Picture = "iPhone11.jpg",
                Manufacturer = "Apple",
                Prices = "999"
            };
            DataContext = _p;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Debug.WriteLine("Closed");
        }
    }
}
