using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace BTLT08
{
    /// <summary>
    /// Interaction logic for EditPhoneWindow.xaml
    /// </summary>
    public partial class EditPhoneWindow : Window
    {
        public Phone NewPhoneInfo { get; set; } = null;
        private Phone _data;
        public EditPhoneWindow(Phone p)
        {
            InitializeComponent();
            _data = p;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonePictureTextBox.Text == "")
            {
                NewPhoneInfo = new Phone()
                {
                    Name = phoneNameTextBox.Text,
                    Manufacturer = phoneManufacturerTextBox.Text,
                    Picture = _data.Picture,
                    Prices = phonePricesTextBox.Text
                };
                DialogResult = true;
            }
            else
            {
                var info = new FileInfo(_filename);
                var folder = AppDomain.CurrentDomain.BaseDirectory;
                folder += "\\Images\\";
                if (File.Exists(System.IO.Path.Combine(_filename, folder + info.Name)))
                {
                    File.Copy(_filename, folder + Guid.NewGuid() + info.Extension);
                }
                else
                {
                    File.Copy(_filename, folder + info.Name);
                }
                NewPhoneInfo = new Phone()
                {
                    Name = phoneNameTextBox.Text,
                    Manufacturer = phoneManufacturerTextBox.Text,
                    Picture = info.Name,
                    Prices = phonePricesTextBox.Text
                };
                DialogResult = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _data;
        }

        string _filename = "";
        private void chooseButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            if (screen.ShowDialog() == true)
            {
                _filename = screen.FileName;
                phonePictureTextBox.Text = screen.FileName;
                var bitmap = new BitmapImage(new Uri(screen.FileName, UriKind.Absolute));
                phoneImage.Source = bitmap;
            }
        }
    }
}
