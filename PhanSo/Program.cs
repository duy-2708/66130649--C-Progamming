using Bai2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_1
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }
        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public PhanSo(PhanSo ps, int tuSo)
        {
            tuSo = ps.tuSo;
            mauSo = ps.MauSo;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauSo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Phan so: {0}/{1}", tuSo, mauSo);
        }
        public void ToiGian()
        {
            int a = tuSo;
            int b = mauSo;
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;

                }
            }
            tuSo /= a;
            mauSo /= a;
            Console.WriteLine("Phan so toi gian: {0}/{1}", tuSo, mauSo);
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo * ps.mauSo + mauSo * ps.tuSo;
            kq.mauSo = mauSo * ps.mauSo;
            return kq;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = tuSo * ps.mauSo - mauSo * ps.tuSo;
            kq.mauSo = mauSo * ps.mauSo;
            return kq;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //PhanSo ps1 = new PhanSo();
                //ps1.Nhap();
                //ps1.Xuat();
                //ps1.ToiGian();
                //PhanSo ps2 = new PhanSo();
                //ps2.Nhap();
                //ps2.Xuat();
                //ps2.ToiGian();
                //PhanSo kqCong = ps1.Cong(ps2);
                //Console.WriteLine("Tong 2 phan so: {0}/{1}", kqCong.TuSo, kqCong.MauSo);
                //PhanSo kqTru = ps1.Tru(ps2);
                //Console.WriteLine("Hieu 2 phan so: {0}/{1}", kqTru.TuSo, kqTru.MauSo);
                DSPS  ds = new DSPS();
                ds.NhapPS();
                ds.XuatPS();
                PhanSo lonnhat =  ds.Max();  
                Console.WriteLine("Phan so lon nhat: ");
                lonnhat.Xuat();
                Console.WriteLine("Tang dan: ");
                ds.TangDan();
                ds.XuatPS();
            }
        }
    }
}
