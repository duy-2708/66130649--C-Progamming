using Bai2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_4
{
    class Circle
    {
        private double r;
        private Point C;

        public Circle(double r, Point C)
        {
            this.r = r;
            this.C = C;
        }
        public double Area()
        {
            return Math.PI * r * r;
        }
        public void Move(double x, double y)
        {
            C.Move(x, y);

        }
        public void xuat()
        {
            Console.WriteLine("Tam C {0},{1} : BanKinh{2}: Area {3}" ,C.X ,C.Y ,r,Area());
        }
    }
}
