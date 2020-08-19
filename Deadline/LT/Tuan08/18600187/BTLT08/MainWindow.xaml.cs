using System;
using System.Collections.Generic;
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

namespace BTLT08
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

        BindingList<Phone> _data;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _data = new BindingList<Phone>()
            {
                new Phone() { Name = "Vsmart Active 3", Picture="phone01.jpg", Manufacturer = "Vsmart", Prices = "3.990.000₫" },
                new Phone() { Name = "Xiaomi Redmi Note 9S", Picture="phone02.jpg", Manufacturer = "Xiaomi", Prices = "5.990.000₫" },
                new Phone() { Name = "Samsung Galaxy S10+", Picture="phone03.jpg", Manufacturer = "Samsung", Prices = "13.990.000₫"},
                new Phone() { Name = "Samsung Galaxy Note 10+", Picture="phone04.jpg", Manufacturer = "Samsung", Prices = "26.990.000₫" },
                new Phone() { Name = "Samsung Galaxy S20 Ultra", Picture="phone05.jpg", Manufacturer = "Samsung", Prices = "24.990.000₫" },
                new Phone() { Name = "IPhone Xs Max 256GB", Picture="phone06.jpg", Manufacturer = "Apple", Prices = "28.990.000₫"},
                new Phone() { Name = "Samsung Galaxy Z Flip", Picture="phone07.jpg", Manufacturer = "Samsung", Prices = "36.000.000₫" },
                new Phone() { Name = "IPhone 11 Pro Max 256GB", Picture="phone08.jpg", Manufacturer = "Apple", Prices = "35.490.000₫" },
                new Phone() { Name = "Samsung Galaxy A21s", Picture="phone09.jpg", Manufacturer = "Samsung", Prices = "5.690.000₫"},
                new Phone() { Name = "OPPO A52", Picture="phone10.jpg", Manufacturer = "OPPO", Prices = "5.690.000₫"}
            };
            dataListview.ItemsSource = _data;
        }

        private void deleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var index = dataListview.SelectedIndex;
            var phone = _data[index];
            _data.RemoveAt(index);
        }

        private void editMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var index = dataListview.SelectedIndex;
            var phone = _data[index];
            var screen = new EditPhoneWindow(phone);
            if (screen.ShowDialog()== true)
            {
                var newInfo = screen.NewPhoneInfo;
                phone.Name = newInfo.Name;
                phone.Manufacturer = newInfo.Manufacturer;
                phone.Picture = newInfo.Picture;
                phone.Prices = newInfo.Prices;
            }
        }

        private void addMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var screen = new AddPhoneWindow();
            if (screen.ShowDialog() == true)
            {
                var newInfo = screen.NewPhoneInfo;
                _data.Add(newInfo);
            }
        }
    }
}
