using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TODO
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

        string dataFile = "";
        ObservableCollection<string> todos = new ObservableCollection<string>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string folder = AppDomain.CurrentDomain.BaseDirectory;
            dataFile = $"{folder}list.txt";

            var items = File.ReadAllLines(dataFile);

            foreach (var item in items)
            {
                todos.Add(item);
            }
            todoListBox.ItemsSource = todos;
        }
        public bool IsDefault { get; set; }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var newItem = newDataTextBox.Text.Trim();

            if (todos.Contains(newItem))
            {
                MessageBox.Show($"TODO {newItem} already exists in LIST.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            } else if (newItem.Length == 0)
            {
                MessageBox.Show($"Cannot add spaces to TODO LIST.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                // Cập nhật lại dữ liệu ở nơi lưu trữ / Database

                File.AppendAllText(dataFile, $"\r\n{newItem}");

                // Cập nhật lại đối tượng trên bộ nhớ 
                todos.Add(newItem);

                // Reset lại ô nhập liệu, cập nhật lại giao diện
                newDataTextBox.Text = "";
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var index = todoListBox.SelectedIndex;

            if (index == -1)
            {
                
            }
            else
            {
                // Cập nhật mảng trên bộ nhớ
                todos.RemoveAt(index);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.WriteAllLines(dataFile, todos);
        }
    }
}
