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

namespace QuickImage
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

        private void clickButton_Random(object sender, RoutedEventArgs e)
        {
            Home.Content = "";
            var img = new Random();
            string[] ID = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" };
            int i = img.Next(ID.Length);
            string value = ID[i];
            var uri = new Uri($"Image/{value}.jpg", UriKind.Relative);
            Image.Source = new BitmapImage(uri);
            Image.Width = 300;
            Image.Height = 300;
            Canvas.SetLeft(Image, 150);
            Canvas.SetTop(Image, 10);
         
            switch (value)
            {
                case "01":
                    Text.Content = "Hulk";
                    break;
                case "02":
                    Text.Content = "Captain America";
                    break;
                case "03":
                    Text.Content = "Iron Man";
                    break;
                case "04":
                    Text.Content = "War Machine";
                    break;
                case "05":
                    Text.Content = "Mantis";
                    break;
                case "06":
                    Text.Content = "Dr. Stephen Strange";
                    break;
                case "07":
                    Text.Content = "Falcon";
                    break;
                case "08":
                    Text.Content = "Okoye";
                    break;
                case "09":
                    Text.Content = "Vision";
                    break;
                case "10":
                    Text.Content = "Scarlet Witch";
                    break;
                case "11":
                    Text.Content = "Black Widow";
                    break;
                case "12":
                    Text.Content = "Drax";
                    break;
                case "13":
                    Text.Content = "Black Panther";
                    break;
                case "14":
                    Text.Content = "Groot and Rocke";
                    break;
                case "15":
                    Text.Content = "Star-Lord";
                    break;
                case "16":
                    Text.Content = "Shuri";
                    break;
                case "17":
                    Text.Content = "Bucky Barnes";
                    break;
                case "18":
                    Text.Content = "Nebula";
                    break;
                case "19":
                    Text.Content = "Gamora";
                    break;
                case "20":
                    Text.Content = "Wong";
                    break;
                case "21":
                    Text.Content = "Spider-Man";
                    break;
                case "22":
                    Text.Content = "Thor";
                    break;
                case "23":
                    Text.Content = "Hawkeye";
                    break;
                case "24":
                    Text.Content = "Captain Marvel";
                    break;
                case "25":
                    Text.Content = "Goose the Cat";
                    break;
                case "26":
                    Text.Content = "Thanos";
                    break;
                default:
                    break;
            }
        }

        private void clickButton_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Developed by Nguy3^n – Copyright © 2020", "About",
                MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}
