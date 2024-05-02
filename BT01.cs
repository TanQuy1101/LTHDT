using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    class BT01
    {
        int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public BT01(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void nhapTTSV()
        {
            Console.WriteLine("Nhap Gia Tri a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Gia Tri b: ");
            b = int.Parse(Console.ReadLine());
        }

        public void xuatTTSV()
        {
            Console.WriteLine("Tong Hai So La: {0}", a + b);
            Console.WriteLine("Hieu Hai So La: {0}", a - b);
            Console.WriteLine("Tich Hai So La: {0}", a * b);
            Console.WriteLine("Thuong Hai So La: {0:0.00}", a * 1.0 / b);
        }
    }
}
