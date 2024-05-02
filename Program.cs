using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //BT01 a = new BT01(10,20);
            //a.nhapTTSV();
            //a.xuatTTSV();

            //BT02 a = new BT02("2001", "Edward", 9);
            //a.nhap();
            //a.xuat();
            //a.xepLoai();
            //Console.ReadKey();

            NhanVien nv = new NhanVien("0","0",0);
            nv.nhapNV();
            nv.xuatNV();
            nv.xepLoai();
            nv.tinhLuong();
            nv.tinhThuong();
            Console.ReadKey();
        }
    }
}
