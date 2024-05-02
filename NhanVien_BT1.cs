using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    class NhanVien_BT1 : BT1, IHoTroChiPhi
    {
        protected double phantramhoahong;

        public NhanVien_BT1(string maNV, string tenNV, string trinhdo, string noidaotao, double hesoluong, int soloivipham, double phantramhoahong)
            : base(maNV, tenNV, trinhdo, noidaotao, hesoluong, soloivipham)
        {
            this.phantramhoahong = phantramhoahong;
        }

        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap Phan Tram Hoa Hong: ");
            phantramhoahong = double.Parse(Console.ReadLine());
        }

        public override double tinhTNTT()
        {
            return phantramhoahong * 5000000;
        }

        public override double tinhHSTD()
        {
            if (soloivipham == 0)
                return 1;
            else if (soloivipham == 1)
                return 0.75;
            else
                return 0.5;
        }

        public double tinhHoTro()
        {
            if (Noidaotao == "Nuoc Ngoai")
            {
                return luongcoban * 2;
            }
            else
                return 0;
        }
    }
}
