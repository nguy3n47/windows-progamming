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
    /// Interaction logic for yc4_ListView.xaml
    /// </summary>
    public partial class yc4_ListView : Window
    {
        public yc4_ListView()
        {
            InitializeComponent();
            List<User1> items = new List<User1>();
            items.Add(new User1() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User1() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User1() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });
            lvDataBinding.ItemsSource = items;
        }
    }
    public class User1
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }
    }
}
