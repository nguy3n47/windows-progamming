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

namespace BT01
{
    static class Util
    {
        public static bool IsEmpty(this TextBox control)
        {
            return control.Text.Trim().Length == 0;
        }

        public static bool IsEmpty(this PasswordBox control)
        {
            return control.Password.Trim().Length == 0;
        }

        public static int CountSpace(this string str)
        {
            int count = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    count++;
            }
            return count;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string U { get; set; } = "";
        public string P { get; set; } = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var textU = Username.Text;
            var textP = Password.Password;
            if (Username.IsEmpty() && Password.IsEmpty() || textU.CountSpace() >= 1 && textP.CountSpace() >= 1 || textU.CountSpace() >= 1 && Password.IsEmpty() || Username.IsEmpty() && textP.CountSpace() >= 1)
            {
                MessageBox.Show("Enter a valid Username & Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Username.IsEmpty() || textU.CountSpace() >= 1)
            {
                MessageBox.Show("Enter a valid Username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Password.IsEmpty() || textP.CountSpace() >= 1)
            {
                MessageBox.Show("Enter a valid Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (textU == "admin" && textP == "qwe3@1v")
            {
                var screen = new DashboardWindow();
                var choice = screen.ShowDialog();
            }    
            else
            {
                U = Username.Text;
                P = Password.Password;
                MessageBox.Show("Login Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
