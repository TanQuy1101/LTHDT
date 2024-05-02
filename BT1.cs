using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    abstract class BT1
    {
        protected string maNV;
        protected string tenNV;
        protected string trinhdo;
        string noidaotao;

        // get set có điều kiện.
        public string Noidaotao
        {
            get
            {
                if (!noidaotao.Equals("Viet Nam") && !noidaotao.Equals("Nuoc Ngoai"))
                {
                    throw new Exception("Loi Noi Dao Tao!");
                }
                return noidaotao;
            }
            set { noidaotao = value; }
        }
        protected double hesoluong;
        protected int soloivipham;
        public static double luongcoban = 1500000;

        public BT1(string maNV, string tenNV, string trinhdo, string noidaotao, double hesoluong, int soloivipham)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.trinhdo = trinhdo;
            this.noidaotao = noidaotao;
            this.hesoluong = hesoluong;
            this.soloivipham = soloivipham;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap Ma NV: ");
            maNV = Console.ReadLine();
            Console.WriteLine("Nhap Ten NV: ");
            tenNV = Console.ReadLine();
            Console.WriteLine("Nhap Trinh Do: ");
            trinhdo = Console.ReadLine();
            Console.WriteLine("Nhap Noi Dao Tao: ");
            noidaotao = Console.ReadLine();
            Console.WriteLine("Nhap He So Luong: ");
            hesoluong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So Loi Vi Pham: ");
            soloivipham = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("MaMV: {0} \t TenNV: {1} \t Trinh Do: {2} \t Noi Dao Tao: {3} \t He So Luong: {4} \t So Loi Vi Pham: {5} \t Luong: {6} \t Thuc Lanh: {7}", maNV, tenNV, trinhdo, noidaotao, hesoluong, soloivipham,tinhLuong(),tinhTL());
        }

        public double tinhLuong()
        {
            return hesoluong * luongcoban + tinhTNTT();
        }

        public abstract double tinhTNTT();

        public double tinhTL()
        {
            return tinhLuong() * tinhHSTD();
        }

        public abstract double tinhHSTD();
    }


}
