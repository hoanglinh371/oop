//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    internal class SinhVien
//    {
//        private string fullName;
//        private string dateOfBirth;
//        private double p1;
//        private double p2;
//        private double p3;

//        public SinhVien(string fullName, string dateOfBirth, double p1, double p2, double p3)
//        {
//            this.fullName = fullName;
//            this.dateOfBirth = dateOfBirth;
//            this.p1 = p1;
//            this.p2 = p2;
//            this.p3 = p3;
//        }

//        public override string? ToString()
//        {
//            return "SinhVien {" +
//                "fullName: " + this.fullName +
//                ", dateOfBirth: " + this.dateOfBirth +
//                ", p1: " + this.p1 +
//                ", p2: " + this.p2 +
//                ", p3: " + this.p3 +
//                "}";
//        }

//        public double AvgPoint()
//        {
//            double avg = 0;
//            avg = (this.p1 + this.p2 + this.p3) / 3;
//            return avg;
//        }

//        public bool IsAllPointNotUnderFive()
//        {
//            return this.p1 >= 5 && this.p2 >= 5 && this.p3 >= 5;
//        }

//        static void Main()
//        {
//            SinhVien sv1 = new SinhVien("nguyen van a", "01/01/2000", 9, 9, 9);
//            SinhVien sv2 = new SinhVien("nguyen van b", "01/01/2002", 6, 7, 8);
//            SinhVien sv3 = new SinhVien("nguyen van c", "01/01/2001", 3, 5, 6);

//            SinhVien[] svs = new SinhVien[] { sv1, sv2, sv3 };

//            int i = 0, j = 0;
//            foreach(SinhVien sv in svs)
//            {
//                if (sv.AvgPoint() >= 8 && sv.IsAllPointNotUnderFive())
//                {
//                    i++;
//                }
//                if (sv.IsAllPointNotUnderFive())
//                {
//                    j++;
//                }
//            }

//            Console.WriteLine("So sv dc lam khoa luan tot nghiep: " + i);
//            Console.WriteLine("So sv dc lam chuyen de tot nghiep: " + j);
//        }
//    }
//}
