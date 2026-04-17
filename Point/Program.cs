using Bai2_3;
using Bai2_4;
using System;
using System.Collections.Generic;

namespace Bai2_3
{
    //Khai báo lớp Point
    public class Point
    {
        private double x;
        private double y;
        private String mau;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
   // End of Point
    public Point(double x, double y, String mau) {
            this.x = x;
            this.y = y;
            this.mau = mau;
        } // End of Point
        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        public double KhoangCach() {
            return Math.Sqrt(x*x+y*y);
 }
    }
}// Main program 
class Program
{
    static void Main()

    {
        List<Point> ds = new List<Point>();
        Point point = new Point(1.0, 2.0, "red");
        Console.WriteLine("Nhap so toa do muon tao ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap toa do thu{0} ", i + 1);
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            String mau = Console.ReadLine();
            Point p = new Point(x, y, mau);
            ds.Add(p);
        }
        //Console.WriteLine("Diem ban dau {0} , {1}", point.X, point.Y);
        //point.Move(2.0, 3.0);
        //Console.WriteLine("Toa do  diem sau khi di chuyen:{0},{1} ", point.X, point.Y);
        ////
        //Console.WriteLine("Danh sach cac diem da nhap");
        //for (int i = 0; i < ds.Count; i++)
        //{
        //    Console.WriteLine("Diem thu {0} : {1} , {2} ", i + 1, ds[i].X, ds[i].Y);
        //}
        //if (ds.Count > 0)
        //{
        //    Point maxPoint = ds[0];
        //    for (int i = 1; i < ds.Count; i++)
        //    {
        //        if (ds[i].KhoangCach() > maxPoint.KhoangCach())
        //        {
        //            maxPoint = ds[i];
        //        }

        //}
        //    Console.WriteLine("Diem xa nhat tu goc toa do: {0} , {1} ", maxPoint.X, maxPoint.Y);
        //}
        //if (ds.Count >= 2)
        //{
        //    double min = double.MaxValue;

        //    for (int i = 0; i < ds.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < ds.Count; j++)
        //        {
        //            double d = Math.Sqrt(Math.Pow(ds[i].X - ds[j].X, 2) + Math.Pow(ds[i].Y - ds[j].Y, 2));
        //            if (d < min)
        //            {
        //                min = d;

        //            }
        //        }
        //    }

        //    Console.WriteLine("- Khoang cach: {0} ",min);
        //}
        Point tamO = new Point(0.0, 0.0, "Red");

        
        Circle hinhTron1 = new Circle(5.0, tamO);

       
        hinhTron1.xuat();

        Console.WriteLine("\n--- DI CHUYEN HINH TRON ---");
       
        hinhTron1.Move(3.0, 4.0);

       
        hinhTron1.xuat();
    }
    }// End of class Program
