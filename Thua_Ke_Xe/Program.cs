using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thua_Ke_Xe
{   class Xe
    {
         private String bienSo;
        private int nSX;
        private double gia;
        public String BienSo { get => bienSo; set => bienSo = value; }
        public int NSX { get => nSX; set => nSX = value; }
        public double Gia { get => gia; set => gia = value; }
        public Xe(String bienSo , int nSX , double gia)
        {
            this.bienSo = bienSo;
            this.nSX = nSX;
            this.gia = gia;
        }
        public Xe()
        {
            this.bienSo = bienSo;
            this.nSX = nSX;
            this.gia = gia;

        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap bien so xe (79-2708): ");
            bienSo = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat(2006): ");
            nSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia xe(Trieu Dong): ");
            gia = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Bien so xe " + bienSo);
            Console.WriteLine("Nam san xuat: " + nSX);
            Console.WriteLine("Gia cua xe: " + gia);
        }
    }
    class XeCon:Xe
    {
        private int choNgoi;
        private String loaiXe;

        public int ChoNgoi { get => choNgoi; set => choNgoi = value; }
        public string LoaiXe { get => loaiXe; set => loaiXe = value; }
        public XeCon(String bienSo,int nSX ,double gia,int choNgoi ,string LoaiXe) :base(bienSo ,nSX, gia)
        {
            this.choNgoi = choNgoi;
            this.LoaiXe = LoaiXe;
        }
        public XeCon() : base()
        {
            this.choNgoi = choNgoi;
            this.LoaiXe = LoaiXe;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so cho ngoi ");
            choNgoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loai xe(Sedal/SUV/Ban tai): ");
            loaiXe = Console.ReadLine();
        }
        public override void Xuat()
        {   
            base.Xuat();
            Console.WriteLine("So cho ngoi: "+choNgoi);
            Console.WriteLine("Loai xe la: " + loaiXe);
            Console.WriteLine("-----------------");
        }

    }
    internal class Program
    {   public static void NhapdsXe(List<XeCon>dsxe,int n)
        {
            
            
            for(int i = 0; i< n; i++)
            {
                XeCon x1 = new XeCon();
                x1.Nhap();
                dsxe.Add(x1);
            }
        }
        public static void XuatdsXe(List<XeCon> dsxe)
        {
            foreach(var x in dsxe)
            {
                x.Xuat();
            }
        }
        public static Boolean sosanh(string a, string b)
        {
            for(int i = 0; i<2; i++)
            {
                if ((a[i] != b[i]))
                {
                    return false;
                }
                }
            return true;
            }
         
   
        public static void timxe(List<XeCon>dsxe)
        {
            Console.WriteLine("Nhap bien so xe can tim");
            string n = Console.ReadLine();
            foreach(var x in dsxe)
            {
                if (sosanh(n,x.BienSo) == true)
                {
                    x.Xuat();
                }
            }
        }
        static void Main(string[] args)
        { List<XeCon> dsxe = new List<XeCon>();
            Console.WriteLine("Nhap so luong xe ");
            int n = int.Parse(Console.ReadLine());
            NhapdsXe(dsxe, n);
            XuatdsXe(dsxe);
            Console.WriteLine("TIm bien so xe");
            timxe(dsxe);
            
        }

    }
}
