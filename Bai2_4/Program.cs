using System;
namespace Bai2_4
{
    class Point
    {
        private double x;
        private double y;
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

    }
    class Circle
    {
        private double r;
        private Point c;
        public Circle(double r, Point c)
        {
            this.r = r;
            this.c = c;

        }
        public double Area()
        {
            return 3.14 * r * r;
        }
        public void Move(double dx, double dy)
        {
            c.Move(dx, dy);
        }
        public void xuat()
        {
            Console.WriteLine("Tam c{0},{1}: BanKinh {2}: Area:{3} ", c.X, c.Y, r, Area());
        }
    }
    class Program
    {
        static void Main()
        {
            Point tam0 = new Point(0.0, 0.0);
            Circle hinhTron1 = new Circle(5.0, tam0);
            Console.WriteLine("Hinh tron luc ban dau");
            hinhTron1.xuat();
            hinhTron1.Move(3.0, 4.0);
            Console.WriteLine("Tam hinh tron sau khi move");
            hinhTron1.xuat();
        }
    }

}