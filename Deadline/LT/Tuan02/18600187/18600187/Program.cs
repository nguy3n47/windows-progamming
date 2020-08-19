using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18600187
{
    class Program
    {
        class SinhVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string DiemTrungBinh { get; set; }
            public string DiaChi { get; set; }
            public string SoDienThoai { get; set; }

            public void Xuat()
            {
                Console.WriteLine($"MSSV: {MSSV}");
                Console.WriteLine($"Họ và tên: {HoTen}");
                Console.WriteLine($"Điểm trung bình: {DiemTrungBinh}");
                Console.WriteLine($"Địa chỉ: {DiaChi}");
                Console.WriteLine($"SĐT: {SoDienThoai}");
                Console.WriteLine("---------------------------------");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> sv = new List<SinhVien>();
            Random rng = new Random();

            var hoten = new string[]
            {
                "Nông Huỳnh Di", "Hoa Liễu", "Trang Thi",
                "Dương Khoa", "Thịnh Lương Đoàn", "Hứa Phi Hương",
                "Quách Tiên Lan", "Lều Băng Khôi", "Phương Phong Nghĩa",
                "Phương Ái", "Thôi Hảo Phi", "Hán Ngôn", "Ông Toàn",
                "Nhâm Vũ", "Lã Hoán", "Ma Chế Duy", "Trình Kiến Cần",
                "Võ Vượng", "Đặng Cường Hỷ", "Trác Thanh Nhiên"
            };

            var diemtrungbinh = new string[]
            {
                "7.1", "6.8", "5.5",
                "8.3", "8.6", "9.5",
                "8.4", "7.7", "9.1",
                "7.4", "7.5", "8.9", "6.9",
                "9.2", "8.0", "9.0", "9.8",
                "10", "8.5", "6.0"
            };

            var diachi = new string[]
            {
                "Hà Nội", "Hải Dương", "An Giang",
                "TP HCM", "Đà Nẵng", "Cần Thơ",
                "Quảng Nam", "Hòa Bình", "Lâm Đồng",
                "Ninh Bình", "Đắk Lắk", "Bình Thuận", "Bến Tre",
                "Bắc Giang", "Kon Tum", "Ninh Thuận", "Nghệ An",
                "Hà Giang", "Tây Ninh", "Quảng Trị"
            };

            var sodienthoai = new string[]
            {
                "(073) 550 7345", "0780-217-6222", "125-722-4556",
                "20-697-8871", "128-396-6351", "(53)285-9873",
                "0165 501 6232", "199-928-8592", "0240-350-8969",
                "231-522-9449", "120-668-8972", "(059) 905 8448", "(091) 770 2181",
                "(0122) 540 1892", "84-169-642-3765", "029-788-4184", "84-62-000-4957",
                "84-165-632-6181", "094-271-7473", "+84-31-687-0711"
            };

            var selectName= new List<int>();
            var selectDiaChi = new List<int>();
            var selectSDT = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                // Random MSSV
                var mssv = new StringBuilder();
                mssv.Append("18600");
                for (int j = 1; j <= 3; j++)
                {
                    mssv.Append(rng.Next(10));
                }

                // Random HoTen
                int ix1 = rng.Next(hoten.Length);
                while (selectName.Contains(ix1))
                {
                    ix1 = rng.Next(hoten.Length);
                }
                selectName.Add(ix1);
                string ht = hoten[ix1];

                // Random DiemTrungBinh
                int ix2 = rng.Next(diemtrungbinh.Length);
                string dtb = diemtrungbinh[ix2];

                // Random DiaChi
                int ix3 = rng.Next(diachi.Length);
                while (selectDiaChi.Contains(ix3))
                {
                    ix3 = rng.Next(diachi.Length);
                }
                selectDiaChi.Add(ix3);
                string dc = diachi[ix3];

                // Random SoDienThoai
                int ix4 = rng.Next(sodienthoai.Length);
                while (selectSDT.Contains(ix4))
                {
                    ix4 = rng.Next(sodienthoai.Length);
                }
                selectSDT.Add(ix4);
                string sdt = sodienthoai[ix4];

                sv.Add(new SinhVien()
                {
                    MSSV = mssv.ToString(),
                    HoTen = ht,
                    DiemTrungBinh = dtb,
                    DiaChi = dc,
                    SoDienThoai = sdt
                });
            }
            foreach (var s in sv)
            {
                s.Xuat();
            }

            double Tong = 0;
            foreach (var e in sv)
            {
                double DTB = double.Parse(e.DiemTrungBinh);
                Tong += DTB;
            }
            double KetQua = Tong / sv.Count;
            KetQua = Math.Truncate(KetQua * 100) / 100;
            Console.WriteLine($"Điểm trung bình tổng thể của 10 sinh viên: {KetQua}\n---------------------------------");

            for (int m = 0; m < sv.Count - 1; m++)
            {
                for (int n = m + 1; n < sv.Count; n++)
                {
                    if (double.Parse(sv[m].DiemTrungBinh) > double.Parse(sv[n].DiemTrungBinh))
                    {
                        SinhVien tmp = sv[m];
                        sv[m] = sv[n];
                        sv[n] = tmp;
                    }
                }
            }

            Console.WriteLine($"Sinh viên có điểm trung bình cao nhất là:\nHọ và Tên: {sv[sv.Count - 1].HoTen}\nSĐT: {sv[sv.Count - 1].SoDienThoai}\n---------------------------------");
            Console.WriteLine($"Sinh viên có điểm trung bình thấp nhất là:\nHọ và Tên: {sv[0].HoTen}\nSĐT: {sv[0].SoDienThoai}");
        }
    }
}
