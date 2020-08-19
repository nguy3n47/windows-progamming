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

namespace MyStaff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<Staff> _list;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _list = new BindingList<Staff>()
            {
                new Staff() { Name = "NGUYỄN THỊ KIM DUNG", Email="kimdung@gmail.com", Address = "10 Đường Phan Ngữ, Phương ĐaKao, Q.1, TP.HCM", Phone = "0382015636", Avatar ="avatar01.jpg" },
                new Staff() { Name = "NGÔ XUÂN LỘC", Email="xuanloc@gmail.com", Address = "33 Lê Quốc Hưng, P.12, Q.4, TP.HCM", Phone = "0906638866", Avatar ="avatar02.jpg" },
                new Staff() { Name = "VÕ HUY PHÚC", Email="vohuyphuc@gmail.com", Address = "35 Nguyễn Bá Huân , Phường Thảo Điền, Quận 2, TP.HCM", Phone = "0918033903", Avatar ="avatar03.jpg"},
                new Staff() { Name = "TRẦN THỊ THÚY HẰNG", Email="thuyhang@gmail.com", Address = "Lầu 6, Tòa nhà Hải Âu, 39B Trường Sơn, Phường 4, Quận Tân Bình, TP.HCM", Phone = "0943834748", Avatar ="avatar04.jpg" },
                new Staff() { Name = "TRẦN VŨ HẢI ĐĂNG", Email="haidang@gmail.com", Address = "125/83 Đường D1, Phường 25, Q.Bình Thạnh, TP.HCM", Phone = "0862833880", Avatar ="avatar05.jpg" },
                new Staff() { Name = "NGUYỄN HÀ THANH", Email="thanh.ha@one.com.vn", Address = "226 Khánh Hội, Phường 6, Q.4, TP.HCM", Phone = "0917105313", Avatar ="avatar06.jpg"},
                new Staff() { Name = "LÊ NGỌC QUỲNH", Email="ngocquynh@outlook.com", Address = "25 Bis Nguyễn Thị Minh Khai, Q.1, TP.HCM", Phone = "0911200800", Avatar ="avatar07.jpg" },
                new Staff() { Name = "PHẠM QUỐC TOÀN", Email="quoctoan@hotmail.com", Address = "68 Nam Kỳ Khởi Nghĩa, P. Nguyễn Thái Bình, Q.1, TP.HCM", Phone = "0943903234", Avatar ="avatar08.jpg" },
                new Staff() { Name = "DƯƠNG TUẤN ANH", Email="tuananh@gmail.com", Address = "18F Simcity, Đường số 4, Trường Thạnh, Q.9, TP.HCM", Phone = "0969909737", Avatar ="avatar09.jpg"},
                new Staff() { Name = "TRẦN VIỆT THU HUYỀN", Email="thuhuyen@outlook.com", Address = "Số 94, Trần Bình Trọng, Phường 1, Quận 5, TP.HCM", Phone = "0933480386", Avatar ="avatar10.jpg"}
            };
            dataListBox.ItemsSource = _list;
        }
    }
}
