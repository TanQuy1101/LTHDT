using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI_01
{
    class BGD_BT1 : BT1
    {
        protected string chucvu;
        protected int hesochucvu;

        public BGD_BT1(string maNV, string tenNV, string trinhdo, string noidaotao, double hesoluong, int soloivipham, string chucvu, int hesochucvu)
            : base(maNV, tenNV, trinhdo, noidaotao, hesoluong, soloivipham)
        {
            this.chucvu = chucvu;
            this.hesochucvu = hesochucvu;
        }

        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap He So Chuc Vu: ");
            hesochucvu = int.Parse(Console.ReadLine());
        }

        public override double tinhTNTT()
        {
            return hesochucvu * luongcoban;
        }

        public override double tinhHSTD()
        {
            return 1;
        }
    }
}
