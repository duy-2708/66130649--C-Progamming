using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_2
{   class Shape
    {
        private String name;
        public string Name { get => name; set => name = value; }
        public Shape(string name)
        {
            this.name = name;
        }
        public Shape()
        {

        }
        public virtual void nhap()
        {
            Console.WriteLine("Moi nhap ten hinh ");
            Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ten hinh la " + name);
        }
        public virtual double Area()
        {
            return 0;
        }
    }
    class Rectangle : Shape
    {
        private double width;
        private double height;
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height =value; }
        public Rectangle(string name, double width, double height = 0) : base(name)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle() : base()
        {
            this.width = width;
            this.height = height;
        }
        public virtual void nhapV()
        {
            base.nhap();
        }
        public virtual void xuatV()
        {
            base.xuat();
           
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Chieu dai " + width);
            Console.WriteLine("Chieu rong " + height);
            Console.WriteLine("Dien tich hcn " + Area());
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap chieu dai ");
          width=  double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong");
           height= double.Parse(Console.ReadLine());
        }
     
        public override double Area()
        {
            return width * height;
        }
      
    }
    class Circle: Shape
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }
        public Circle(string name , double raidus ) : base(name)
        {
            this.radius = radius;
        }
        public Circle() : base()
        {
            this.radius = radius;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap ban kinh");
           radius= double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ban kinh " + radius);
            Console.WriteLine("Dien tich hinh tron " + Area());
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        
    }
    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public Triangle(string name , double a , double b , double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle() : base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c");
            c = double.Parse(Console.ReadLine());

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Canh a" + a);
            Console.WriteLine("Canh b" + b);
            Console.WriteLine("Canh c" + c);
            Console.WriteLine("Dien tich tam giac " + Area());
        }
        public override double Area()
        {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Square : Rectangle
    {
        private double canh;
        public double Canh { get => canh; set => canh = value; }
        public Square(String name , double canh) : base()
        {
            this.canh = canh;
        }
        public Square() : base()
        {
            this.canh = canh;
        }
        public override void nhap()
        {
            base.nhapV();
           Console.WriteLine("Nhap canh hinh vuong");
            canh = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuatV();
            Console.WriteLine("Canh hinh vuong: " + canh);
            Console.WriteLine("Dien tich hinh vuong: " + Area());
        }
        public override double Area()
        {
            return canh * canh;
        }
    }
    internal class Program
    {   static void Nhap(List<Shape>s1,int n) 
        {
             for(int i = 0; i < n; i++)
            {
                
                Console.WriteLine("1.Hinh chu nhat");
                Console.WriteLine("2.Hinh tron");
                Console.WriteLine("3.Hinh tam giac");
                Console.WriteLine("4.Hinh vuong");
                int chon = int.Parse(Console.ReadLine());
                if(chon == 1)
                {
                    Rectangle cn1 = new Rectangle();
                    cn1.nhap();
                    s1.Add(cn1);
                }else if(chon == 2)
                {
                    Circle t1 = new Circle();
                    t1.nhap();
                    s1.Add(t1);
                }else if(chon == 3)
                {
                    Triangle tg1 = new Triangle();
                    tg1.nhap();
                    s1.Add(tg1);
                }else if(chon == 4)
                {
                    Square hv1 = new Square();
                    hv1.nhap();
                    s1.Add(hv1);
                }
                
            }
        }
        static void MaxS(List<Shape> s1,int n)
        { double max = s1[0].Area();
            int tam = 0;
               for(int i = 0; i< n; i++)
            {
                if (max < s1[i].Area())
                {
                    max = s1[i].Area();
                    tam++;
                }
            }
            Console.WriteLine("Thong tin dien tich hinh lon nhat");
            s1[tam].xuat();
        }
        static void GiamDan(List<Shape>s1,int n)
        {
            for(int i = 0; i< n-1; i++)
            {
                for(int j = i+1;j< n; j++)
                {
                    if (s1[i].Area() < s1[j].Area())
                    {
                        Shape tam = s1[i];
                        s1[i] = s1[j];
                        s1[j] = tam;

                    }
                }
            }
        }
        static void Xuat(List<Shape>s1)
        {
            foreach(var x in s1)
            {
                x.xuat();
            }
        }
        static void Main(string[] args)
        {
            List<Shape> s1 = new List<Shape>();
            Console.WriteLine("Nhap n hinh ve ");
            int n = int.Parse(Console.ReadLine());
            Nhap(s1, n);
            MaxS(s1, n);
            GiamDan(s1,n);
            Console.WriteLine("Day sau khi giam dan");
            Xuat(s1);
           
        }
    }
}
