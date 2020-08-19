using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MyBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<Book> _list;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _list = new BindingList<Book>()
            {
                new Book() { Name = "Lập Trình Với C#", Picture="book01.jpg", Author = "Phạm Quang Huy - Vũ Trọng Luật - Phạm Quang Hiển", Year = "2019" },
                new Book() { Name = "Giáo Trình Kỹ Thuật Lập Trình C Căn Bản Và Nâng Cao", Picture="book02.jpg", Author = "GS. Phạm Văn Ất", Year = "2018" },
                new Book() { Name = "Giáo Trình C++ Và Lập Trình Hướng Đối Tượng", Picture="book03.jpg", Author = "GS. Phạm Văn Ất", Year = "2018"},
                new Book() { Name = "Kiểm Thử Phần Mềm - Từng Bước Trở Thành Tester Chuyên Nghiệp", Picture="book04.jpg", Author = "ThS. Nguyễn Thị Kiêm Ái", Year = "2017" },
                new Book() { Name = "Code Dạo Kí Sự - Lập Trình Viên Đâu Phải Chỉ Biết Code", Picture="book05.jpg", Author = "Phạm Huy Hoàng", Year = "2017" },
                new Book() { Name = "Arduino Và Lập Trình IoT", Picture="book06.jpg", Author = "TS. Nguyễn Tất Bảo Thiện - KS. Phạm Quang Huy", Year = "2020"},
                new Book() { Name = "Thiết Kế Web Với Dreamweaver", Picture="book07.jpg", Author = "Jerymy Osborn và nhóm AGI Creative", Year = "2016" },
                new Book() { Name = "Công Tác Bảo Mật Cá Nhân Trong Kỷ Nguyên Big Data: Nghệ Thuật Ẩn Mình", Picture="book08.jpg", Author = "Kevin Mitnick - Robert Vamosi", Year = "2018" },
                new Book() { Name = "Cuộc Rượt Đuổi Ngoạn Mục Trong Mê Lộ Máy Tính: Gián Điệp Mạng", Picture="book09.jpg", Author = "Clifford Stoll", Year = "2018"},
                new Book() { Name = "Bóng Ma Trên Mạng", Picture="book10.jpg", Author = "Willam L.Simon", Year = "2018"}
            };
            dataListBox.ItemsSource = _list;
        }
    }
}
