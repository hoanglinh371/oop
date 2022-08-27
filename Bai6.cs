//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    internal class Nhanvien
//    {
//        private string fullName;
//        private int year;
//        private string address;
//        private double luongCoBan;
//        private double heSo;
//        private double phuCap;
//        private double tongTien;

//        public Nhanvien()
//        {
//        }

//        public override string? ToString()
//        {
//            return "NhanVien {" +
//                "fullName: " + this.fullName +
//                ",year: " + this.year + 
//                ",address: " + this.address +
//                ",luongCoBan: " + this.luongCoBan +
//                ",heSo: " + this.heSo +
//                ",phuCap: " + this.phuCap +
//                ",tongTien: " + this.Calc() +
//                "}";
//        }

//        public void input()
//        {
//            Console.WriteLine("Nhap ho ten: ");
//            this.fullName = Convert.ToString(Console.ReadLine());
//            Console.WriteLine("Nhap nam sinh: ");
//            this.year = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Nhap dia chi: ");
//            this.address = Convert.ToString(Console.ReadLine());
//            Console.WriteLine("Nhap luong co ban: ");
//            this.luongCoBan = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Nhap he so: ");
//            this.heSo = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Nhap phu cap: ");
//            this.phuCap = Convert.ToDouble(Console.ReadLine());
//        }

//        public double Calc()
//        {
//            this.tongTien = this.luongCoBan * this.heSo + this.phuCap;
//            return this.tongTien;
//        }

//        public static void Main()
//        {
//            Nhanvien nhanvien = new Nhanvien();
//            nhanvien.input();
//            Console.WriteLine(nhanvien.ToString());
//        }
//    }
//}
