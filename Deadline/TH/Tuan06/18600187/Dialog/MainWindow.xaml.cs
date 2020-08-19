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

namespace Dialog
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

        private void keo_Click(object sender, RoutedEventArgs e)
        {
            Random _rng = new Random();
            var n = _rng.Next(1, 4);
            if( n == 1)
            {
               Bua.Width = new GridLength(0);
               var uri = new Uri($"Images/scissors--right.png", UriKind.Relative);
               imgBao.Source = new BitmapImage(uri);
               MessageBoxResult result = MessageBox.Show("Hòa", "Result", MessageBoxButton.OK, MessageBoxImage.Exclamation);
               if(result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }    

            }
            if (n == 2)
            {
                Bao.Width = new GridLength(0);
                var uri = new Uri($"Images/rock--right.png", UriKind.Relative);
                imgBua.Source = new BitmapImage(uri);
                MessageBoxResult result = MessageBox.Show("Thua", "Result",
                MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
            if (n == 3)
            {
                Bua.Width = new GridLength(0);
                var uri = new Uri($"Images/paper--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(uri);
                MessageBoxResult result = MessageBox.Show("Thắng", "Result",
                MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
        }

        private void bua_Click(object sender, RoutedEventArgs e)
        {
            Random _rng = new Random();
            var n = _rng.Next(1, 4);
            if (n == 1)
            {
                Keo.Width = new GridLength(0);
                var uri = new Uri($"Images/scissors--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(uri);
                MessageBoxResult result = MessageBox.Show("Thắng", "Result",
                MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
            if (n == 2)
            {
                Keo.Width = new GridLength(0);
                var uri = new Uri($"Images/rock--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(uri);
                MessageBoxResult result = MessageBox.Show("Hòa", "Result",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
            if (n == 3)
            {
                Keo.Width = new GridLength(0);
                var uri = new Uri($"Images/paper--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(uri);
                MessageBoxResult result = MessageBox.Show("Thua", "Result",
                MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
        }

        private void bao_Click(object sender, RoutedEventArgs e)
        {
            Random _rng = new Random();
            var n = _rng.Next(1, 4);
            Keo.Width = new GridLength(0);
            var uri = new Uri($"Images/bao.png", UriKind.Relative);
            imgBua.Source = new BitmapImage(uri);
            if (n == 1)
            {
                var urii = new Uri($"Images/scissors--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(urii);
                MessageBoxResult result = MessageBox.Show("Thua", "Result",
                MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
            if (n == 2)
            {
                var urii = new Uri($"Images/rock--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(urii);
                MessageBoxResult result = MessageBox.Show("Thắng", "Result",
                MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
            if (n == 3)
            {
                var urii = new Uri($"Images/paper--right.png", UriKind.Relative);
                imgBao.Source = new BitmapImage(urii);
                MessageBoxResult result = MessageBox.Show("Hòa", "Result",
                MessageBoxButton.OK, MessageBoxImage.Exclamation);
                if (result == MessageBoxResult.OK)
                {
                    MainWindow m = new MainWindow();
                    this.Close();
                    m.Show();
                }
            }
        }
    }
}
