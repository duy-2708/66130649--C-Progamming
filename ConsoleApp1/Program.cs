using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Tap_2
{   class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double luongCoBan;
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public NhanVien (string maNV , string hoTen ,double luongCoBan)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.luongCoBan = luongCoBan;
        }
        public NhanVien()
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.luongCoBan = luongCoBan;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma NV ");
            maNV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap luong co ban ");
            luongCoBan = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma Nhan Vien: " + maNV);
            Console.WriteLine("Ho va ten: " + hoTen);
            Console.WriteLine("Luong co ban: " +luongCoBan);
        }
        public virtual double TinhLuong()
        {
            return luongCoBan;
        }
    }
    class LapTrinhVien : NhanVien
    {
        private double tienOT;
        public double TienOT { get => tienOT; set => tienOT = value; }
        public LapTrinhVien() : base()
        {
            this.tienOT = tienOT;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap tien lam them ");
            tienOT = double.Parse(Console.ReadLine());

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong thuc te "+TinhLuong());
        }
        public override double TinhLuong()
        {
            return LuongCoBan + tienOT;
        }
    }
    
    internal class Program
    {   public static void dsNhanVien(List<NhanVien>dsnv,int n)
        {
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("1.NhanVien");
                Console.WriteLine("2.LapTrinhVien");
                int chon = int.Parse(Console.ReadLine());
                if(chon == 1)
                {
                    NhanVien nvi = new NhanVien();
                    nvi.Nhap();
                    dsnv.Add(nvi);
                } else if(chon == 2)
                {
                    LapTrinhVien ltvi = new LapTrinhVien();
                    ltvi.Nhap();
                    dsnv.Add(ltvi);
                }
                
            }
        }
        public static void Xuatds(List<NhanVien> dsnv)
        {
            foreach(var x in dsnv)
            {
                x.Xuat();
                Console.WriteLine("-------------");
            }
        }
        public static double LuongMax(List<NhanVien> dsnv)
        { double max = dsnv[0].TinhLuong();
            foreach(var x in dsnv)
            {
                if(max < x.TinhLuong())
                {
                    max = x.TinhLuong();
                }
            }
            return max;
        }
        public static void SapXepAZ(List<NhanVien>dsnv,int n)
        {
            for(int i = 0; i< n-1; i++)
            {
                for(int j = i+1; j<n; j++)
                {
                    if ((dsnv[i]).HoTen.CompareTo(dsnv[j].HoTen ) > 0)
                    {
                        NhanVien tam = new NhanVien();
                        tam = dsnv[i];
                        dsnv[i] = dsnv[j];
                        dsnv[j] = tam;
                    }
                }
            }
        }
        public static void Xoa(List<NhanVien> dsnv,string xoa)
        {
            dsnv.RemoveAll(x => x.MaNV == xoa);
        }

        static void Main(string[] args)
        { List<NhanVien> dsnv = new List<NhanVien>();
            Console.WriteLine("Nhap so luong  nhan vien ");
            int n = int.Parse(Console.ReadLine());
            dsNhanVien(dsnv, n);
            Xuatds(dsnv);
            Console.WriteLine("Luong cao nhat la " + LuongMax(dsnv));
            Console.WriteLine("Sap xep theo A->Z");
            SapXepAZ(dsnv, n);
            Console.WriteLine("Nhap MaNV neu co se xoa ");
            string xoa = Console.ReadLine();
            Xuatds(dsnv);
            Xoa(dsnv,xoa);
            Xuatds(dsnv);

        }
    }
}
