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
    /// Interaction logic for yc8_ListView.xaml
    /// </summary>
    public partial class yc8_ListView : Window
    {
        public yc8_ListView()
        {
            InitializeComponent();
            List<User4> items = new List<User4>();
            items.Add(new User4() { Name = "John Doe", Age = 42, Sex = SexType.Male });
            items.Add(new User4() { Name = "Jane Doe", Age = 39, Sex = SexType.Female });
            items.Add(new User4() { Name = "Sammy Doe", Age = 13, Sex = SexType.Male });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
    public enum SexType { Male, Female };

    public class User4
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }

        public SexType Sex { get; set; }
    }
}
