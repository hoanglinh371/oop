//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    internal class MangMotChieu
//    {
//        private int n;
//        private int[] a;

//        public MangMotChieu(int n)
//        {
//            this.n = n;
//            this.a = new int[this.n];
//        }

//        public void input()
//        {
//            for (int i = 0; i < this.n; i++)
//            {
//                this.a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//        }

//        public void output()
//        {
//            for (int i = 0; i < this.n; i++)
//            {
//                Console.Write(a[i] + " ");
//            }
//        }

//        public void Sort(int compare)
//        {
//            Array.Sort(this.a);
//            if (compare != 0)
//                Array.Reverse(this.a);
//        }

//        public int Search(int value)
//        {
//            return Array.BinarySearch(this.a, value);
//        }

//        public static void Main()
//        {
//            MangMotChieu arr = new MangMotChieu(5);

//            arr.input();
//            arr.output();

//            int order = 0;
//            Console.WriteLine("Nhap 0 de sap xep tang dan, 1 de sap xep giam dan: ");
//            order = Convert.ToInt32(Console.ReadLine());
//            arr.Sort(order);
//            arr.output();

//            Console.WriteLine("Nhap phan tu can tim kiem: ");
//            int value = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(arr.Search(value));
            
//        }
//    }
//}
