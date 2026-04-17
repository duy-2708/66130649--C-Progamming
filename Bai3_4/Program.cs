using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_4
{   class Printer
    {
        private string nhaSanXuat;
        private double giaBan;

         public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
         public double GiaBan { get => giaBan; set => giaBan = value; }
        public Printer(string nhaSanXuat , double giaBan)
        {
            this.nhaSanXuat = nhaSanXuat;
            this.giaBan = giaBan;
        }
        public Printer()
        {

        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhap nha san xuat: ");
                nhaSanXuat =Console.ReadLine();
            Console.WriteLine("Nhap gia ban: ");
            giaBan = double.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Nha San Xuat: "+nhaSanXuat);
            Console.WriteLine("Gia ban: " + giaBan);
        }
   
    }
    class LaserPrinter : Printer
    {
        private string doPhanGiai;
        public string DoPhanGiai { get => doPhanGiai; set => doPhanGiai = value; }
        public LaserPrinter(string nhaSanXuat, double giaBan , string doPhanGiai):base(nhaSanXuat, giaBan){
            this.doPhanGiai = doPhanGiai;
        }
        public LaserPrinter ():base(){
            this.doPhanGiai = doPhanGiai;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap do phan giai");
             doPhanGiai =Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Do phan giai " + doPhanGiai);
        }
    }
    internal class Program
    {   static void Nhapds(List <LaserPrinter> ls1,int n  )
        {
            
            for(int i = 0; i < n; i++)
            {
                LaserPrinter laser1 = new LaserPrinter();
                laser1.nhap();
                ls1.Add(laser1);
            }
        }
        static void Xuatds(List <LaserPrinter> ls1)
        {
            foreach(var x in ls1)
            {
                x.xuat();
                Console.WriteLine("----");
            }
        }
        static void giaMaxMin(List<LaserPrinter> ls1,int n )
        {
            double max = ls1[0].GiaBan;
            double min = ls1[0].GiaBan;
            for(int i = 0; i < n; i++)
            {
                if(max < ls1[i].GiaBan)
                {
                    max = ls1[i].GiaBan;
                }
            }
            for(int i = 0; i < n; i++)
            {
                if(min > ls1[i].GiaBan)
                {
                    min = ls1[i].GiaBan;
                }
            }
            Console.WriteLine("Gia cao nhat la " + max);
            Console.WriteLine("Gia thap nhat la " + min);

            
        }
        static void TangDan(List<LaserPrinter> ls1,int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                for(int j = i+1; j< n; j++)
                {
                    if (ls1[i].GiaBan > ls1[j].GiaBan)
                    {
                        LaserPrinter tam = new LaserPrinter();
                        tam = ls1[i];
                        ls1[i] = ls1[j];
                        ls1[j] = tam;
                    }
                }
            } 
        }
        static void timTen (List<LaserPrinter> ls1)
        {
            Console.WriteLine("Nhap ten hang can tim ");
            string tenHang = Console.ReadLine();
            bool timthay = false;
            foreach(var x in ls1)
            {
                if(x.NhaSanXuat == tenHang)
                {
                    x.xuat();
                    timthay = true;
                }
            }
            if(!timthay)
            {
                Console.WriteLine("Khong tim thay nha san xuat ");
            }
        }
        static void Main(string[] args)
        {
            List<LaserPrinter> ls1 = new List<LaserPrinter>() ;
            Console.WriteLine("Nhap n may in laser: ");
            int n = int.Parse(Console.ReadLine());
            Nhapds(ls1,n);
            Xuatds(ls1);
            //giaMaxMin(ls1, n);
            //Console.WriteLine("Day sau khi sap xep -----------------");
            //TangDan(ls1, n);
            //Xuatds(ls1);
            timTen(ls1);
           
        }
    }
}
