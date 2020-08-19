using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace MyPhone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<Phone> _list;
        public MainWindow()
        {
            InitializeComponent();
        }

        Random _rng = new Random();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _list = new BindingList<Phone>()
            {
                new Phone() { Name = "Vsmart Active 3", Picture="phone01.jpg", Manufacturer = "Vsmart", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "Xiaomi Redmi Note 9S", Picture="phone02.jpg", Manufacturer = "Xiaomi", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "Samsung Galaxy S10+", Picture="phone03.jpg", Manufacturer = "Samsung", Prices = _rng.Next(5000000, 40000000)},
                new Phone() { Name = "Samsung Galaxy Note 10+", Picture="phone04.jpg", Manufacturer = "Samsung", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "Samsung Galaxy S20 Ultra", Picture="phone05.jpg", Manufacturer = "Samsung", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "IPhone Xs Max 256GB", Picture="phone06.jpg", Manufacturer = "Apple", Prices = _rng.Next(5000000, 40000000)},
                new Phone() { Name = "Samsung Galaxy Z Flip", Picture="phone07.jpg", Manufacturer = "Samsung", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "IPhone 11 Pro Max 256GB", Picture="phone08.jpg", Manufacturer = "Apple", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "Samsung Galaxy A21s", Picture="phone09.jpg", Manufacturer = "Samsung", Prices = _rng.Next(5000000, 40000000) },
                new Phone() { Name = "OPPO A52", Picture="phone10.jpg", Manufacturer = "OPPO", Prices = _rng.Next(5000000, 40000000) }
            };
            dataListBox.ItemsSource = _list;
        }
    }
}
