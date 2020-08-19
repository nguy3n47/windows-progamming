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

namespace BT02
{
    static class Util
    {
        public static bool IsEmpty(this PasswordBox control)
        {
            return control.Password.Trim().Length == 0;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string N { get; set; } = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            var textC = Current.Password; // "qwe3@1"
            var textN = New.Password;
            var textR = Retype.Password;

            if (Current.IsEmpty() || New.IsEmpty() || Retype.IsEmpty())
            {
                MessageBox.Show("Cannot use a blank password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (textC != "qwe3@1")
            {
                MessageBox.Show("Password was incorrect.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }    
            else if ((textC != textN) && (textN == textR))
            {
                N = New.Password;
                MessageBox.Show("Change Password Successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (textC == textN)
            {
                MessageBox.Show("Password must differ from old password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Password do not match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }    
        }
    }
}
