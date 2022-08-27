//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    internal class PhanSo
//    {
//        private int t;
//        private int m;

//        public PhanSo(int t, int m)
//        {
//            if (m == 0)
//            {
//                throw new ArgumentException("mominator cannot be zero.", nameof(m));
//            }
//            this.t = t;
//            this.m = m;
//        }

//        public static PhanSo operator +(PhanSo a) => a;
//        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.t, a.m);

//        public static PhanSo operator +(PhanSo a, PhanSo b)
//            => new PhanSo(a.t * b.m + b.t * a.m, a.m * b.m);

//        public static PhanSo operator -(PhanSo a, PhanSo b)
//            => a + (-b);

//        public static PhanSo operator *(PhanSo a, PhanSo b)
//            => new PhanSo(a.t * b.t, a.m * b.m);

//        public static PhanSo operator /(PhanSo a, PhanSo b)
//        {
//            if (b.t == 0)
//            {
//                throw new DivideByZeroException();
//            }
//            return new PhanSo(a.t * b.m, a.m * b.t);
//        }

//        public override string ToString() => $"{t} / {m}";

//        public static void Main()
//        {
//            var a = new PhanSo(5, 4);
//            var b = new PhanSo(1, 2);
//            Console.WriteLine(-a);   // output: -5 / 4
//            Console.WriteLine(a + b);  // output: 14 / 8
//            Console.WriteLine(a - b);  // output: 6 / 8
//            Console.WriteLine(a * b);  // output: 5 / 8
//            Console.WriteLine(a / b);  // output: 10 / 4
//        }
//    }
//}
