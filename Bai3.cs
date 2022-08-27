//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    internal class ToaDo
//    {
//        private double x;
//        private double y;

//        public ToaDo()
//        {
//            this.x = 0;
//            this.y = 0;
//        }

//        public ToaDo(double x, double y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//        public override string? ToString()
//        {
//            return "ToaDo ( " + this.x + this.y + ")";
//        }

//        public void input()
//        {
//            Console.WriteLine("Nhap x, y: ");
//            this.x = Convert.ToDouble(Console.ReadLine());
//            this.y = Convert.ToDouble(Console.ReadLine());
//        }

//        public double distance(ToaDo a)
//        {
//            double result = Math.Sqrt(Math.Pow(a.x - this.x, 2) + Math.Pow(a.y - this.y, 2));
//            return result;
//        }

//        public static void Main()
//        {
//            ToaDo a = new ToaDo(5, 6);
//            ToaDo b = new ToaDo();
//            b.input();
//            Console.WriteLine("Khoang cach a to b: " + a.distance(b));
//        }
//    }
//}
