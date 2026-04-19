using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap4
{   class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double luongCoBan;
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                if(value < 500)
                {
                    luongCoBan = 500;
                }
                else
                {
                    luongCoBan = value;
                }
            }
        }
        public NhanVien(string maNV , string hoTen , double luongCoBan)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.LuongCoBan = luongCoBan;
        }
        public NhanVien()
        {

        }
        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }
    }
    class LapTrinhVien : NhanVien
    {
        private double tienOT;
        public double TienOT { get; set; }
       
        public LapTrinhVien(string maNV , string hoTen ,double luongCoBan , double tienOT ):base(maNV , hoTen, luongCoBan)
        {
            this.TienOT = tienOT;
        }
        public LapTrinhVien() : base()
        {

        }
        public override double TinhLuong()
        {
            return LuongCoBan + (TienOT * 200);
        }

    }
    class NhanVienKiemThu : NhanVien
    {
        private int soLoiPhatHien;
        public int SoLoiPhatHien { get; set; }
        public NhanVienKiemThu(string maNV , string hoTen , double luongCoBan , int soLoiPhatHien) : base(maNV, hoTen, luongCoBan)
        {
            this.SoLoiPhatHien = soLoiPhatHien;
        }
        public NhanVienKiemThu() : base()
        {

        }
        public override double TinhLuong()
        {
            return LuongCoBan + (SoLoiPhatHien * 50);
        }
    }
    internal class Program
    {   public static void Nhapds(List<NhanVien> ds,int n)
        {
            for(int i = 0; i<n; i++)
            {
                int chon;
                do
                {
                    Console.WriteLine("1.Lap Trinh Vien ");
                    Console.WriteLine("2.NhanVienKiemThu ");
                    chon = int.Parse(Console.ReadLine());
                } while (chon != 1 && chon != 2);
                if(chon == 1)
                {
                    LapTrinhVien l = new LapTrinhVien();
                    Console.WriteLine("Nhap ma nhan vien: ");
                    l.MaNV = Console.ReadLine();
                    Console.WriteLine("Nhap ho va ten: ");
                    l.HoTen = Console.ReadLine();
                    Console.WriteLine("Nhap luong co ban ");
                    l.LuongCoBan = double.Parse(Console.ReadLine());
                    Console.WriteLine("TienOT: ");
                    l.TienOT = double.Parse(Console.ReadLine());
                    ds.Add(l);
                }else if(chon == 2)
                {
                    NhanVienKiemThu l = new NhanVienKiemThu();
                    Console.WriteLine("Nhap ma nhan vien: ");
                    l.MaNV = Console.ReadLine();
                    Console.WriteLine("Nhap ho va ten: ");
                    l.HoTen = Console.ReadLine();
                    Console.WriteLine("Nhap luong co ban ");
                    l.LuongCoBan = double.Parse(Console.ReadLine());
                    Console.WriteLine("So San Pham Loi: ");
                    l.SoLoiPhatHien = int.Parse(Console.ReadLine());
                    ds.Add(l);
                }
            }
        }
        public static void Xuatds(List<NhanVien> ds)
        {
            foreach(var x in ds)
            { 
                    Console.WriteLine("Ma Nhan Vien" + x.MaNV);
                Console.WriteLine("Tong luong: " + x.TinhLuong());
                Console.WriteLine("--------------------");
            }
        }
        public static void LTV(List<NhanVien>ds)
        {   
            foreach( var x in ds)
            {
                if ( x is LapTrinhVien ltv )
                {
                    if (ltv.TienOT > 20){
                    Console.WriteLine("Ma nhan vien " + x.MaNV);
                    Console.WriteLine("Tong luong: " + x.TinhLuong());
                    }
                }
            }
        }
        public static List<NhanVien> SapXep(List<NhanVien>ds)
        {
            return ds.OrderBy(x => x.HoTen).ToList();
        }
        public static void TongLuongNV(List<NhanVien> ds)
        {
            var tong = ds.Sum(x => x.TinhLuong());
            Console.WriteLine("Tong luong cong try tra: " + tong);
        }
        public static void XoaNV(List<NhanVien>ds,string ten)
        {
            var ma = ds.Find(x => x.MaNV == ten);
            if (ma != null)
            {
                ds.Remove(ma);
            }
            else
            {
                Console.WriteLine("khong tim thay ");
            }
        }
        static void Main(string[] args)
        { 
            List<NhanVien> dsnv = new List<NhanVien>();
            Console.WriteLine("Nhap n danh sach ");
            int n = int.Parse(Console.ReadLine());
            Nhapds(dsnv, n);
            Xuatds(dsnv);
            //LTV(dsnv);
            Console.WriteLine("Sap xep theo A->Z");
            //SapXep(dsnv);
            //dsnv = SapXep(dsnv);
            //Xuatds(dsnv);
            //TongLuongNV(dsnv);
            Console.WriteLine("Nhap ma nhan vien muon xoa ");
            string manv = Console.ReadLine();
            XoaNV(dsnv, manv);

            Xuatds(dsnv);
        }
    }
}
