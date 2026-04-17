using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_3
{
    class HinhVe
    {
        private String tenHinh;
        public string TenHinh { get => tenHinh; set => tenHinh = value; }

        public HinhVe(String tenHinh)
        {
            this.tenHinh = tenHinh;
        }
        public virtual void DienTich()
        {
            Console.WriteLine("Dien tich cua hinh ve: ");
        }
    }
    class HinhChuNhat : HinhVe
    {
        private double chieuDai;
        private double chieuRong;
        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public HinhChuNhat(String tenHinh, double chieuDai = 0, double chieuRong = 0) : base(tenHinh)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public override void DienTich()
        {
            Console.WriteLine("{0}", TenHinh);
            Console.WriteLine("Dien tich hinh chu nhat: " + (chieuDai * chieuRong));
        }

    }
    class HinhTron : HinhVe
    {
        private double radius;
        public double Radius { get => Radius; set => Radius = value; }
        public HinhTron(String tenHinh, double radius) : base(tenHinh)
        {
            this.radius = radius;
        }
        public override void DienTich()
        {
            Console.WriteLine("{0}", TenHinh);
            Console.WriteLine("Dien Tich Hinh Tron {0}", radius * radius * Math.PI);
        }
    }
    class HinhVuong : HinhChuNhat
    {
        public HinhVuong(string tenHinh, double chieuDai) : base(tenHinh, chieuDai)
        {
            this.ChieuDai = chieuDai;
        }
        public override void DienTich()
        {
            Console.WriteLine("{0}", TenHinh);
            Console.WriteLine("Dien tich hinh vuong {0}", ChieuDai * ChieuDai);
            

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hc1 = new HinhChuNhat("ChuNhat", 5, 4);
            hc1.DienTich();
            HinhTron ht1 = new HinhTron("Tron", 3);
            ht1.DienTich();
            HinhVuong hv1 = new HinhVuong("HinhVuong", 4);
            hv1.DienTich();
        }
    }
}
