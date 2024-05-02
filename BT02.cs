using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    class BT02
    {
        string mssv;

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        float dtb;

        public float Dtb
        {
            get { return dtb; }
            set { dtb = value; }
        }
        //string xeploai;

        //public string Xeploai
        //{
        //    get { return xeploai; }
        //    set { xeploai = value; }
        //}

        public BT02(string mssv, string hoten, float dtb)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.dtb = dtb;
            //this.xeploai = xeploai;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap MSSV: ");
            mssv = Console.ReadLine();
            Console.WriteLine("Nhap Ho Ten SV: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap Diem Trung Binh: ");
            dtb = float.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("MSSV: {0} \t Ho Ten SV: {1} \t DTB: {2} \t XepLoai: {3}", mssv, hoten, dtb,xepLoai());
        }

        public string xepLoai()
        {
            if (dtb >= 8)
                return "Gioi";
            else if (dtb >= 6.5)
                return "Kha";
            else if (dtb >= 5)
                return "Trung Binh";
            else
                return "Yeu Kem";
        }
    }
}
