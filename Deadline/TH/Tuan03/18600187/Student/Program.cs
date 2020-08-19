using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        public class FakeName
        {
            static List<string> lastname = new List<string> { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Phan", "Vũ", "Võ", "Đặng", "Bùi" };
            static List<string> middlename = new List<string> { "Anh", "Thị", "Đăng", "Đức", "Thanh", "Thi", "Uyển", "Yến", "Cao", "Nhật" };
            static List<string> firstname = new List<string> { "Huy", "Vy", "Nguyên", "Hương", "Tùng", "Khoa", "Cường", "Nam", "Hiếu", "Duy" };

            private Random _rng = new Random();

            public String generator()
            {
                var l = _rng.Next(lastname.Count);
                var m = _rng.Next(middlename.Count);
                var f = _rng.Next(firstname.Count);

                return $"{lastname[l]} {middlename[m]} {firstname[f]}";
            }
        }
        public class FakeAge
        {
            private Random _rng = new Random();
            public int generator()
            {
                var age = _rng.Next(5, 50);
                return age;
            }
        }
        public class FakeTel
        {
            static List<string> firstnumber = new List<string> { "086", "096", "097", "098", "035", "036", "037", "038", "039", "089" };
            private Random _rng = new Random();

            public String generator()
            {
                var f = _rng.Next(firstnumber.Count);
                var tel = new StringBuilder();
                tel.Append(firstnumber[f]);
                for (int j = 1; j <= 7; j++)
                {
                    tel.Append(_rng.Next(10));
                }
                return $"{tel}";
            }
        }
        public class FakeStudent
        {
            FakeName name = new FakeName();
            FakeAge age = new FakeAge();
            FakeTel tel = new FakeTel();
            public void Next()
            {
                string n = name.generator();
                Console.WriteLine(n);
                int a = age.generator();
                Console.WriteLine(a);
                string t = tel.generator();
                Console.WriteLine(t);
            }
        }
        class StudentStore
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Tel { get; set; }
            public void GetAllStudent()
            {
                FakeStudent fakestudent = new FakeStudent();
                for (int i = 0; i < 10; i++)
                {
                    fakestudent.Next();
                }
            }
            public void Xuat()
            {
                Console.WriteLine($"\tFullname: {Name}");
                Console.WriteLine($"\tAge: {Age}");
                Console.WriteLine($"\tTel: {Tel}");
                Console.WriteLine("---------------------------------");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //StudentStore store = new StudentStore();
            //store.GetAllStudent();
            List<StudentStore> Store = new List<StudentStore>();
            var name = new FakeName();
            var age = new FakeAge();
            var tel = new FakeTel();
            List<Tuple<string, string>> Student = new List<Tuple<string, string>>();
            for (int i = 0; i < 10; i++)
            {
                Store.Add(new StudentStore()
                {
                   Name = name.generator(),
                   Age = age.generator(),
                   Tel = tel.generator()
                });
            }
            Console.WriteLine("Danh sách ngẫu nhiên 10 sinh viên với các thông tin Fullname, Age, Tel");
            foreach (var s in Store)
            {
                s.Xuat();
                if (s.Age > 18 && s.Age < 30)
                {
                    Student.Add(new Tuple<string, string>(s.Name, s.Tel));
                }
            }
            Console.WriteLine("Danh sách sinh viên (chỉ gồm tên và số điện thoại) có độ tuổi > 18 và < 30");
            int length = Student.Count;
            if (length == 0)
            {
                Console.WriteLine("Không có dữ liệu hợp lệ!");
            }
            else
            {
                foreach (var e in Student)
                {
                    Console.WriteLine($"\tFullname: {e.Item1}");
                    Console.WriteLine($"\tTel: {e.Item2}");
                    Console.WriteLine("---------------------------------");
                }
            }    
        }
    }
}
