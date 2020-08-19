using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData
{
    /// <summary>
    /// Lớp FackeNameStore dùng để lưu trữ 10 phần tử họ, tên lót và tên + thực hiện chức năng tạo ra ngẫu nhiên 1 họ và tên đầy đủ
    /// </summary>
    public class FakeNameStore
    {
        // Mảng động 10 phần tử họ
        static List<string> lastname = new List<string> { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Phan", "Vũ", "Võ", "Đặng", "Bùi" };
        // Mảng động 10 phần tử tên lót
        static List<string> middlename = new List<string> { "Anh", "Thị", "Đăng", "Đức", "Thanh", "Thi", "Uyển", "Yến", "Cao", "Nhật" };
        // Mảng động 10 phần tử tên
        static List<string> firstname = new List<string> { "Huy", "Vy", "Nguyên", "Hương", "Tùng", "Khoa", "Cường", "Nam", "Hiếu", "Duy" };

        // Hàm tạo ra một số ngẫu nhiên
        private Random _rng = new Random();

        /// <summary>
        /// Hàm tạo ngẫu nhiên 1 họ và tên đầy đủ
        /// </summary>
        /// <returns>
        /// Chuỗi họ và tên
        /// </returns>
        public String generator()
        {
            // Tạo ngẫu nhiên một vị trí trong mảng động 10 phần tử họ
            var l = _rng.Next(lastname.Count);
            // Tạo ngẫu nhiên một vị trí trong mảng động 10 phần tử tên lót
            var m = _rng.Next(middlename.Count);
            // Tạo ngẫu nhiên một vị trí trong mảng động 10 phần tử tên
            var f = _rng.Next(firstname.Count);
            // Trả về kết quả là một chuỗi họ và tên đầy đủ
            return $"{lastname[l]} {middlename[m]} {firstname[f]}";
        }
    }

    /// <summary>
    /// Lớp FakeTelStore dùng để lưu trữ 10 phần tử đầu số điện thoại + thực hiên chức năng tạo ngẫu nhiên 1 số điện thoại bao gồm 10 số
    /// </summary>
    public class FakeTelStore
    {
        // Mảng động 10 phần tử đầu số điện thoại
        static List<string> firstnumber = new List<string> { "086", "096", "097", "098", "035", "036", "037", "038", "039", "089" };

        // Hàm tạo ra một số ngẫu nhiên
        private Random _rng = new Random();

        /// <summary>
        /// Hàm tạo ngẫu nhiên 1 số điện thoại
        /// </summary>
        /// <returns>
        /// Chuỗi 1 số điện thoại có độ dài là 10
        /// </returns>
        public String generator()
        {
            // Tạo ngẫu nhiên một vị trí trong mảng động 10 phần tử đầu số điện thoại
            var f = _rng.Next(firstnumber.Count);
            // Tạo một chuỗi để thực hiện việc nối chuỗi
            var tel = new StringBuilder();
            // Nối chuỗi 3 số đầu điện thoại vào biến tel
            tel.Append(firstnumber[f]);
            // Thực hiện việc tạo ngẫu nhiên 7 số còn lại để nối với 3 số đầu điện thoại
            for (int j = 1; j <= 7; j++)
            {
                tel.Append(_rng.Next(10)); // Tạo ngẫu nhiên các số từ 0 -> 9
            }
            // Trả về kết quả là 1 chuỗi số điện thoại có độ dài là 10
            return $"{tel}";
        }
    }

    /// <summary>
    /// Lớp FakeAddressStore dùng để lưu trữ 5 phần tử Quận, mỗi Quận sẽ có 5 phần tử phường và mỗi phường sẽ có 5 phần tử đường tương ứng + thực hiện chức năng tạo ngẫu nhiên một địa chỉ
    /// </summary>
    public class FakeAddressStore
    {
        // Mảng động 5 phần tử Quận
        static List<string> district = new List<string> { "Quận 1", "Quận 5", "Quận 10", "Quận 7", "Quận Thủ Đức" };

        // Mảng động 5 phần tử Phường của Quận 1
        static List<string> ward1 = new List<string> { "Bến Nghé", "Bến Thành", "Cầu Ông Lãnh", "Phạm Ngũ Lão", "Đa Kao" };
        // Mảng động 5 phần tử Phường của Quận 5
        static List<string> ward2 = new List<string> { "Phường 1", "Phường 2", "Phường 3", "Phường 4", "Phường 5" };
        // Mảng động 5 phần tử Phường của Quận 10
        static List<string> ward3 = new List<string> { "Phường 6", "Phường 7", "Phường 8", "Phường 9", "Phường 10" };
        // Mảng động 5 phần tử Phường của Quận 7
        static List<string> ward4 = new List<string> { "Phú Mỹ", "Tân Hưng", "Tân Phong", "Tân Quy", "Tân Phú" };
        // Mảng động 5 phần tử Phường của Quận Thủ Đức
        static List<string> ward5 = new List<string> { "Linh Trung", "Linh Xuân", "Linh Chiểu", "Linh Đông", "Linh Tây" };

        // Mảng động 25 phần tử Đường tương ứng với từng Phường của Quận 1
        static List<string> street1 = new List<string> { "01 Công xã Paris", "10-12 Đinh Tiên Hoàng", "07 Công Trường Lam Sơn", "160 Pasteur", "86 Lê Thánh Tôn", "26 Lê Thị Riêng", "116 Nguyễn Du", "131 Nam Kỳ Khởi Nghĩa", "59 Nguyễn Thị Minh Khai", "140 Lý Tự Trọng", "95A Trần Hưng Đạo", "75 Nguyễn Thái Học", "6 Trịnh Văn Cấn", "168 Võ Văn Kiệt", "18 Yersin", "107 Phạm Ngũ Lão", "284 Cống Quỳnh", "50-82 Bùi Viện", "8 Nguyễn Văn Tráng", "212 Đề Thám", "45 Võ Thị Sáu", "38 Huỳnh Khương Ninh", "10 Nguyễn Thành Ý", "27 Nguyễn Đình Chiểu", "2 Mai Thị Lựu" };
        // Mảng động 25 phần tử Đường tương ứng với từng Phường của Quận 5
        static List<string> street2 = new List<string> { "937 Trần Hưng Đạo", "764 Võ Văn Kiệt", "197 Đường Cao Đạt", "36 Nguyễn Biểu", "57 Nguyễn Văn Cừ", "823 Trần Hưng Đạo", "129 Phan Văn Trị", "207 Nguyễn Biểu", "121 Trần Bình Trọng", "110 Phan Văn Trị", "273 An Dương Vương", "223A Trần Bình Trọng", "207 Nguyễn Văn Cừ", "166 Lê Hồng Phong", "116 Nguyễn Trãi", "280 An Dương Vương", "227 Nguyễn Văn Cừ", "198A Trần Bình Trọng", "266 Lê Hồng Phong", "3A Trần Phú", "69 Bạch Vân", "96 Trần Tuấn Khải", "37 Bùi Hữu Nghĩa", "23 Nhiêu Tâm", "102 An Bình" };
        // Mảng động 25 phần tử Đường tương ứng với từng Phường của Quận 10
        static List<string> street3 = new List<string> { "2 Nguyễn Lâm", "188 Tân Phước", "106 Nguyễn Kim", "214 Ngô Quyền", "205 Đào Duy Từ", "344 Tân Phước", "106 Lý Thường Kiệt", "592/2 Vĩnh Viễn", "497 Hoà Hảo", "821 Đường 3 Tháng 2", "327 Nguyễn Tiểu La", "552 Bà Hạt", "192 Ngô Quyền", "431 Nguyễn Tri Phương", "617 Đường 3 Tháng 2", "435 Lý Thái Tổ", "482 Nguyễn Tri Phương", "281 Sư Vạn Hạnh", "29A Bà Hạt", "102 Vĩnh Viễn", "341 Sư Vạn Hạnh", "665 Lê Hồng Phong", "488 Lý Thái Tổ", "299 Đường 3 Tháng 2", "7 Trần Minh Quyền" };
        // Mảng động 25 phần tử Đường tương ứng với từng Phường của Quận 7
        static List<string> street4 = new List<string> { "1441 Huỳnh Tấn Phát", "109 Hoàng Quốc Việt", "148 Phạm Hữu Lầu", "33 Đào Trí", "116 Chuyên Dùng Chính", "9 Đường số 2A", "41 Trần Xuân Soạn", "469 Nguyễn Hữu Thọ", "702 Nguyễn Văn Linh", "37 Đường số 6", "1058 Nguyễn Văn Linh", "27-28 Đường Số 2", "153 Tôn Dật Tiên", "226 Lý Long Tường", "218 Đường số 10", "135 Đường số 39", "10 Đường số 41", "12 Mai Văn Vĩnh", "4 Đường số 13", "436 Nguyễn Thị Thập", "15 Trần Văn Trà", "10 Tân Trào", "4 Nguyễn Lương Bằng", "800 Nguyễn Văn Linh", "2 Nguyễn Văn Tưởng" };
        // Mảng động 25 phần tử Đường tương ứng với từng Phường của Quận Thủ Đức
        static List<string> street5 = new List<string> { "54 Le Van Chi", "27 QL1A", "47 Xa lộ Hà Nội", "72 Đường Vận Hành", "62A Đường 16", "63 Đường Số 10", "168/7 Quốc lộ 1K", "167/15/1B Đường số 8", "27 Đường Số 11", "33 Đường số 6", "25 Đường số 23", "24 Đường số 20", "763 Kha Vạn Cân", "53 Võ Văn Ngân", "2 Đường Nguyễn Văn Lịch", "415 Phạm Văn Đồng", "46 Lý Tế Xuyên", "74/2/1D Đường số 36", "12 Đường số 26", "242A Tô Ngọc Vân", "179A Kha Vạn Cân", "86 Đường số 9", "43 Đường số 4", "40 Đường Số 13", "22 Đường số 14" };

        // Hàm tạo ra một số ngẫu nhiên
        private Random _rng = new Random();

        /// <summary>
        /// Hàm in ra màn hình 1 địa chỉ ngẫu nhiên tại TP HCM theo dữ liệu từng Đường, Phường và Quận đã tạo
        /// </summary>
        public void generator()
        {
            string city = "TP HCM";
            // Biến để lưu trữ vị trí của Đường
            var s = 0;
            // Biến để lưu trữ vị trí của Phường
            var w = 0;
            // Tạo ngẫu nhiên 1 vị trí trong mảng động 5 phần tử Quận
            var d = _rng.Next(district.Count);

            if (d == 0) // d = 0 <=> "Quận 1"
            {
                // Tạo ngẫu nhiên 1 vị trí trong mảng động 5 phần tử Phường của Quận 1
                w = _rng.Next(ward1.Count);
                if (w == 0) // w = 0 <=> "Bến Nghé"
                {
                    // Tạo ngẫu nhiên 1 vị trí của Đường thuộc Phường "Bến Nghé" được quy định sẵn trong mảng 25 phần tử là các phần tử có vị trí từ 0 -> 4
                    s = _rng.Next(0, 4);
                }
                if (w == 1) // w = 1 <=> "Bến Thành"
                {
                    // Tạo ngẫu nhiên 1 vị trí của Đường thuộc Phường "Bến Thành" được quy định sẵn trong mảng 25 phần tử là các phần tử có vị trí từ 5 -> 9
                    s = _rng.Next(5, 9);
                }
                if (w == 2) // w = 2 <=> "Cầu Ông Lãnh"
                {
                    // Tạo ngẫu nhiên 1 vị trí của Đường thuộc Phường "Cầu Ông Lãnh" được quy định sẵn trong mảng 25 phần tử là các phần tử có vị trí từ 10 -> 14
                    s = _rng.Next(10, 14);
                }
                if (w == 3) // w = 3 <=> "Phạm Ngũ Lão"
                {
                    // Tạo ngẫu nhiên 1 vị trí của Đường thuộc Phường "Phạm Ngũ Lão" được quy định sẵn trong mảng 25 phần tử là các phần tử có vị trí từ 15 -> 19
                    s = _rng.Next(15, 19);
                }
                if (w == 4) // w = 4 <=> "Đa Kao"
                {
                    // Tạo ngẫu nhiên 1 vị trí của Đường thuộc Phường "Đa Kao" được quy định sẵn trong mảng 25 phần tử là các phần tử có vị trí từ 20 -> 24
                    s = _rng.Next(20, 24);
                }
                Console.WriteLine($"{street1[s]}, {ward1[w]}, {district[d]}, {city}");
            }
            if (d == 1) // d = 1 <=> "Quận 5"
            {
                w = _rng.Next(ward2.Count);
                if (w == 0) // "Phường 1"
                {
                    s = _rng.Next(0, 4);
                }
                if (w == 1) // "Phường 2"
                {
                    s = _rng.Next(5, 9);
                }
                if (w == 2) // "Phường 3"
                {
                    s = _rng.Next(10, 14);
                }
                if (w == 3) // "Phường 4"
                {
                    s = _rng.Next(15, 19);
                }
                if (w == 4) // "Phường 5"
                {
                    s = _rng.Next(20, 24);
                }
                Console.WriteLine($"{street2[s]}, {ward2[w]}, {district[d]}, {city}");
            }
            if (d == 2) // d = 2 <=> "Quận 10"
            {
                w = _rng.Next(ward3.Count);
                if (w == 0) // "Phường 6"
                {
                    s = _rng.Next(0, 4);
                }
                if (w == 1) // "Phường 7"
                {
                    s = _rng.Next(5, 9);
                }
                if (w == 2) // "Phường 8"
                {
                    s = _rng.Next(10, 14);
                }
                if (w == 3) // "Phường 9"
                {
                    s = _rng.Next(15, 19);
                }
                if (w == 4) // "Phường 10"
                {
                    s = _rng.Next(20, 24);
                }
                Console.WriteLine($"{street3[s]}, {ward3[w]}, {district[d]}, {city}");
            }
            if (d == 3) // d = 3 <=> "Quận 7"
            {
                w = _rng.Next(ward4.Count);
                if (w == 0) // "Phú Mỹ"
                {
                    s = _rng.Next(0, 4);
                }
                if (w == 1) // "Tân Hưng"
                {
                    s = _rng.Next(5, 9);
                }
                if (w == 2) // "Tân Phong"
                {
                    s = _rng.Next(10, 14);
                }
                if (w == 3) // "Tân Quy"
                {
                    s = _rng.Next(15, 19);
                }
                if (w == 4) // "Tân Phú"
                {
                    s = _rng.Next(20, 24);
                }
                Console.WriteLine($"{street4[s]}, {ward4[w]}, {district[d]}, {city}");
            }
            if (d == 4) // d = 4 <=> "Quận Thủ Đức"
            {
                w = _rng.Next(ward5.Count);
                if (w == 0) // "Linh Trung"
                {
                    s = _rng.Next(0, 4);
                }
                if (w == 1) // "Linh Xuân"
                {
                    s = _rng.Next(5, 9);
                }
                if (w == 2) // "Linh Chiểu"
                {
                    s = _rng.Next(10, 14);
                }
                if (w == 3) // "Linh Đông"
                {
                    s = _rng.Next(15, 19);
                }
                if (w == 4) // "Linh Tây"
                {
                    s = _rng.Next(20, 24);
                }
                Console.WriteLine($"{street5[s]}, {ward5[w]}, {district[d]}, {city}");
            }
        }
    }

    /// <summary>
    /// Lớp FakeEmailStore dùng để lưu trữ 10 phần tử tên miền của email + thực hiện chức năng tạo ngẫu nhiên 1 email với username là tên được tạo ngẫu nhiên ở lớp FakeNameStore
    /// </summary>
    public class FakeEmailStore
    {
        // Mảng động 10 phần tử tên miền của email
        static List<string> domain = new List<string> { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com", "@facebook.com", "@twitter.com", "@apple.com", "@amazon.com", "@github.com", "@tiktok.com" };
        // Hàm tạo ra một số ngẫu nhiên
        private Random _rng = new Random();

        /// <summary>
        /// Hàm tạo ngẫu nhiên 1 email
        /// </summary>
        /// <param name="username"></param>
        /// <returns>
        /// Chuỗi 1 email có dạng username@domain
        /// </returns>
        public String generator(string username)
        {
            // Tạo ngẫu nhiên 1 vị trí trong mảng động 10 phần tử tên miền của email
            var d = _rng.Next(domain.Count);
            // Trả về kết quả là 1 chuỗi email hoàn chỉnh
            return $"{username}{domain[d]}";
        }
    }

    /// <summary>
    /// Lớp thực hiện chạy chương trình FakeData
    /// </summary>
    class Program
    {
        /// <summary>
        /// Hàm biến chuỗi Tiếng Việt có dấu thành không dấu
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// Chuỗi sau khi chuyển đổi
        /// </returns>
        /// <example>
        /// "Vũ Cao Nguyên" --> "Vu Cao Nguyen"
        /// </example>
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        /// <summary>
        /// Hàm main()
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất ra màn hình Console được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // Mảng tĩnh gồm 10 phần tử để lưu trữ sau khi tạo họ và tên từ lớp FakeNameStore
            string[] array = new string[10];

            // Tạo ngẫu nhiên 10 họ và tên từ lớp FakeNameStore
            var namestore = new FakeNameStore();
            Console.WriteLine("----------FakeNameStore----------");
            for (int i = 0; i < 10; i++)
            {
                string fakename = namestore.generator();
                array[i] = fakename; // Gán họ và tên vào mảng tĩnh
                Console.WriteLine(fakename);
            }
            Console.WriteLine("---------------------------------");

            // Tạo ngẫu nhiên 10 số điện thoại từ lớp FakeTelStore
            var telstore = new FakeTelStore();
            Console.WriteLine("-----------FakeTelStore----------");
            for (int i = 0; i < 10; i++)
            {
                string tel = telstore.generator();
                Console.WriteLine(tel);
            }
            Console.WriteLine("---------------------------------");

            // Tạo ngẫu nhiên 10 địa chỉ tương ứng với từng Đường, Phường, Quận ở TP HCM từ lớp FakeAddressStore
            var addressstore = new FakeAddressStore();
            Console.WriteLine("---------FakeAddressStore--------");
            for (int i = 0; i < 10; i++)
            {
                addressstore.generator();
            }
            Console.WriteLine("---------------------------------");

            // Tạo ngẫu nhiên 10 email từ lớp FakeEmailStore với username lấy từ họ và tên được tạo ở lớp FakeNameStore
            var emailstore = new FakeEmailStore();
            Console.WriteLine("----------FakeEmailStore---------");
            for (int i = 0; i < 10; i++)
            {
                // username được lấy từ mảng tĩnh array
                // RemoveUnicode(array[i]) <--> "Vũ Cao Nguyên" --> "Vu Cao Nguyen"
                // ToLower() <--> "Vu Cao Nguyen" --> "vu cao nguyen"
                // Replace(" ", "") <--> "vu cao nguyen" --> "vucaonguyen"
                string username = RemoveUnicode(array[i]).ToLower().Replace(" ", "");
                string mail = emailstore.generator(username);
                Console.WriteLine(mail);
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
