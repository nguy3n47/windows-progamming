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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for yc7_ListView.xaml
    /// </summary>
    public partial class yc7_ListView : Window
    {
        public yc7_ListView()
        {
            InitializeComponent();
            List<User3> items = new List<User3>();
            items.Add(new User3() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User3() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User3() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
            lvUsers.ItemsSource = items;
        }
    }
}
