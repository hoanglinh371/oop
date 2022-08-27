using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class SinhVien
    {
        private string id;
        private double year;
        private string fullName;
        private double p1;
        private double p2;
        private double avg;

        public SinhVien()
        {
        }

        public SinhVien(string id, string fullName, double p1, double p2, double year)
        {
            this.id = id;
            this.fullName = fullName;
            this.p1 = p1;
            this.p2 = p2;
            this.year = year;
        }

        public void input()
        {
            Console.WriteLine("Nhap ho ten: ");
            this.fullName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap nam sinh: ");
            this.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ma sinh vien: ");
            this.id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh: ");
            this.p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem co so du lieu: ");
            this.p2 = Convert.ToDouble(Console.ReadLine());
        }

        public override string? ToString()
        {
            return "SinhVien {" +
                "id: " + this.id +
                ", fullName: " + this.fullName +
                ", year: " + this.year +
                ", p1: " + this.p1 +
                ", p2: " + this.p2 +
                ", avg: " + this.calcAvg() +
                "}";
        }

        public double calcAvg()
        {
            return (this.p1 + this.p2) / 2;
        }

        public static void Main()
        {
            SinhVien a = new SinhVien();
            a.input();
            Console.WriteLine(a.ToString());
        }
    }
}
