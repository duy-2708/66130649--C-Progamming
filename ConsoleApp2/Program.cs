using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{ class Ve
    {
        private string maVe;
        private double giaGoc;
        public string MaVe { get => maVe; set => maVe = value; }
        public double GiaGoc
        {
            get { return giaGoc; }
            set
            {
                if(value > 50000)
                {
                    giaGoc = value;
                }
                else
                {
                    Console.WriteLine("Gia tri mac dinh gan la 50.000");
                    giaGoc = 50000;
                }
            }
        }
        public Ve(string maVe ,double giaGoc)
        {
            this.maVe = maVe;
            this.giaGoc = giaGoc;
        }
        public Ve()
        {
            
        }
        public virtual double tinhGiaTien()
        {
            return giaGoc;
        }

    }
    class VeVip:Ve
    {
        private double phuPhi;
        public double PhuPhi
        {
            get { return phuPhi; }
            set
            {
                if(value > 10000)
                {
                    phuPhi = value;
                }
                else
                {
                    Console.WriteLine("Phu phi bat buoc > 10.000");
                    phuPhi = 10000;
                }
            }
        }
        public VeVip(string maVe , double giaGioc , double phuPhi):base(maVe,giaGioc)
        {
            this.phuPhi = phuPhi;
        }
        public VeVip() : base()
        {
            this.phuPhi = phuPhi;
        }
        public override double tinhGiaTien()
        {
            return GiaGoc + PhuPhi;
        }
    }
    internal class Program
    {   public static void Nhapds(List<Ve>dsve,int n)
        {
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("1.Ve binh thuong");
                Console.WriteLine("2.Ve Vip ");
                int chon = int.Parse(Console.ReadLine());
                if(chon == 1)
                {
                    Ve v = new Ve();
                    Console.WriteLine("Nhap ma ve ");
                    v.MaVe = Console.ReadLine();
                    Console.WriteLine("Nhap gia gioc ");
                    v.GiaGoc = double.Parse(Console.ReadLine());
                    dsve.Add(v);
                } else if(chon == 2 )
                {
                    VeVip v = new VeVip();
                    Console.WriteLine("Nhap ma ve ");
                    v.MaVe = Console.ReadLine();
                    Console.WriteLine("Nhap gia gioc ");
                    v.GiaGoc = double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap phu phi ");
                    v.PhuPhi = double.Parse(Console.ReadLine());
                    dsve.Add(v);
                }
            }
        }
        public static void Xuatds(List<Ve>dsve)
        {
            foreach(var ve in dsve)
            {
                Console.WriteLine("Ma Ve "+ve.MaVe);
                Console.WriteLine("Gia cua ve " + ve.tinhGiaTien());
                Console.WriteLine("-----------------------------");
            }
        }
        public static void DSVV(List<Ve> dsve)
        {
            foreach( var ve in dsve)
            {
                if( ve is VeVip && (ve.tinhGiaTien() > 100000))
                {
                    Console.WriteLine("Ma Ve " + ve.MaVe);
                    Console.WriteLine("Gia cua ve " + ve.tinhGiaTien());
                    Console.WriteLine("-----------------------------");
                }
            }
        }
        public static List<Ve> GiamDan(List<Ve> dsve)
        {
            return  dsve.OrderByDescending(x => x.tinhGiaTien()).ToList();
         
        }
        public static void Xoa(List<Ve>dsve,string ten)
        {
            Ve v = dsve.Find(x => x.MaVe == ten);
            if(v != null)
            {
                dsve.Remove(v);

            }
            else
            {
                Console.WriteLine("Khong tim thay ten de xoa ");
            }
        }
        static void Main(string[] args)
        { List<Ve> dsve = new List<Ve>();
            Console.WriteLine("Nhap so luong ve muon mua ");
            int n = int.Parse(Console.ReadLine());
            Nhapds(dsve, n);
            Xuatds(dsve);
            //Console.WriteLine("DS Ve Vip > 100.000 ");
            //DSVV(dsve);
            //GiamDan(dsve);
            //Console.WriteLine("Danh sach ve giam dan");
            //Xuatds(dsve);
            Console.WriteLine("Nhap ma ve muon xoa");
            string ten = Console.ReadLine();
            Xoa(dsve, ten);
            Xuatds(dsve);
            
        }
    }
}
