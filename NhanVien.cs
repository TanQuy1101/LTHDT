using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    public class NhanVien
    {
        string maso;

        public string Maso
        {
            get { return maso; }
            set { maso = value; }
        }

        string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        int songaycong;

        public int Songaycong
        {
            get { return songaycong; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du Lieu Sai!");
                    songaycong = 0;
                }
                else
                    songaycong = value;
            }
        }

        static int luongngay = 200000;

        // Khởi Tạo Không Có Tham Số.
        public NhanVien()
        {
            maso = "123456";
            hoten = "edward";
            songaycong = 2;
        }


        // Khởi Tạo Có Tham Số.
        public NhanVien(string maso, string hoten, int songaycong)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.songaycong = songaycong;
        }

        // Khởi Tạo Sao Chép.
        public NhanVien(NhanVien a)
        {
            this.maso = a.maso;
            this.hoten = a.hoten;
            this.songaycong = a.songaycong;
        }

        // Hàm Hủy
        ~NhanVien()
        {

        }

        public void nhapNV()
        {
            Console.WriteLine("Nhap Ma So NV: ");
            maso = Console.ReadLine();
            Console.WriteLine("Nhap Ho Ten NV: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap So Ngay Cong: ");
            songaycong = int.Parse(Console.ReadLine());
        }

        public void xuatNV()
        {
            Console.WriteLine("MSNV: {0} \t Ho Ten NV: {1} \t So Ngay Cong: {2} \t XepLoai: {3} \t Luong: {4} \t Thuong: {5}", maso, hoten, songaycong, xepLoai(), tinhLuong(), tinhThuong());
        }

        public char xepLoai()
        {
            if (songaycong > 26)
                return 'A';
            else if (songaycong >= 22)
                return 'B';
            else
                return 'C';
        }

        public float tinhLuong()
        {
            return songaycong * luongngay;
        }

        public float tinhThuong()
        {
            if (xepLoai() == 'A')
                return tinhLuong() * 5 / 100;
            else if (xepLoai() == 'B')
                return tinhLuong() * 2 / 100;
            else
                return 0;
        }

    }
}
